using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Jint;
using Jint.Runtime;
using Jint.Runtime.Debugger;
using Jint.Runtime.Environments;

namespace StoryDev.Scripting
{
    internal class Environment
    {

        private Engine jEngine;

        private List<ScriptError> _errors;
        public IEnumerable<ScriptError> Errors
        {
            get => _errors;
        }

        private List<DataStruct> _structures;
        public IEnumerable<DataStruct> Structures
        {
            get => _structures;
        }

        private DataStruct _lastUsedStructure;
        private DataField _lastUsedField;

        private Dictionary<string, List<DataField>> fieldsToValidate;

        public Environment()
        {
            jEngine = new Engine(c =>
            {
                c.DebugMode();
            });
            jEngine.SetValue("CreateStructure", new Action<string, string>(CreateStructure));
            jEngine.SetValue("AddField", new Action<string, DataFieldType, DataFieldType>(AddField));

            jEngine.SetValue("SetFieldRelationship", new Action<string, string, string>(SetFieldRelationship));
            jEngine.SetValue("SetFieldRelationshipCustom", new Action<string[]>(SetFieldRelationshipCustom));
            jEngine.SetValue("SetFieldRelationshipCustom", new Action<string>(SetFieldRelationshipCustom));


            jEngine.SetValue("FIELDTYPE_INTEGER", DataFieldType.INTEGER);
            jEngine.SetValue("FIELDTYPE_FLOAT", DataFieldType.FLOAT);
            jEngine.SetValue("FIELDTYPE_STRING", DataFieldType.STRING);
            jEngine.SetValue("FIELDTYPE_BOOLEAN", DataFieldType.BOOLEAN);
            jEngine.SetValue("FIELDTYPE_DATETIME", DataFieldType.DATETIME);
            jEngine.SetValue("FIELDTYPE_ARRAY", DataFieldType.OFARRAY);

            jEngine.DebugHandler.Step += DebugHandler_Step;

            fieldsToValidate = new Dictionary<string, List<DataField>>();
            _errors = new List<ScriptError>();
            _structures = new List<DataStruct>();

            Clear();
        }

        private StepMode DebugHandler_Step(object sender, DebugInformation e)
        {
            

            return StepMode.Over;
        }

        public void Clear()
        {
            _structures.Clear();
            _errors.Clear();

            jEngine.ResetCallStack();
            jEngine.ResetConstraints();
        }

        public void RunAllScripts()
        {
            Clear();
            var files = Directory.GetFiles(Globals.CurrentProjectFolder + "\\Scripts\\Data\\", "*.hxs", SearchOption.AllDirectories);
            var hadErrors = false;
            foreach (string file in files)
            {
                if (!RunScript(file))
                {
                    hadErrors = true;
                }
            }

            if (!hadErrors)
                Validate();
        }

        public bool RunScript(string filename)
        {
            var contents = File.ReadAllText(filename);
            try
            {
                jEngine.Execute(contents);

                return true;
            }
            catch (JavaScriptException jEx)
            {
                var error = new ScriptError();
                error.Column = jEx.Column;
                error.LineNumber = jEx.LineNumber;
                error.Message = jEx.Message;
                error.FilePath = filename;
                _errors.Add(error);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void Validate()
        {
            foreach (var kv in fieldsToValidate)
            {
                DataStruct str = GetStructByName(kv.Key);
                if (str != null)
                {
                    List<DataField> fields = kv.Value;
                    foreach (var field in fields)
                    {
                        DataStruct relationship = GetStructByName(field.StructReference);
                        if (relationship == null)
                        {
                            throw new Exception(
                                string.Format("StructReference for the field '{0}' in struct '{1}' could not be found.", 
                                field.Name, str.Name));
                        }

                        DataField fieldReference = GetFieldByName(relationship, field.FieldReference);
                        if (fieldReference == null)
                        {
                            throw new Exception(
                                string.Format("FieldReference for the field '{0}' in struct '{1}' could not be found.",
                                field.Name, str.Name));
                        }

                        if (field.Type != fieldReference.Type)
                        {
                            throw new Exception(string.Format(
                                "Type of the field '{0}' of struct '{1}' must match the type of the field '{2}' of struct '{3}'.",
                                field.Name, str.Name, fieldReference.Name, relationship.Name));
                        }

                        DataField displayReference = null;
                        if (!string.IsNullOrEmpty(field.DisplayReference))
                        {
                            displayReference = GetFieldByName(relationship, field.DisplayReference);
                            if (displayReference == null)
                            {
                                throw new Exception(
                                    string.Format("DisplayReference for the field '{0}' in struct '{1}' could not be found.",
                                    field.Name, str.Name));
                            }
                        }
                        else if (!string.IsNullOrEmpty(field.CustomReferenceSource))
                        {
                            var customValue = jEngine.GetValue(field.CustomReferenceSource);
                            if (customValue == null)
                            {
                                throw new Exception(
                                    string.Format("CustomReferenceSource '{0}' for field '{1}' in struct '{2}' has not been declared or defined.",
                                    field.CustomReferenceSource, field.Name, str.Name));
                            }
                            else if (!customValue.IsArray())
                            {
                                throw new Exception(
                                    string.Format("CustomReferenceSource '{0}' for field '{1}' in struct '{2}' is not an Array type.",
                                    field.CustomReferenceSource, field.Name, str.Name));
                            }
                        }
                        else if (field.CustomDisplayReference != null)
                        {
                            if (field.CustomDisplayReference.Length == 0)
                            {
                                throw new Exception(
                                    string.Format("CustomDisplayReference for field '{1}' in struct '{2}' must contain values.",
                                    field.Name, str.Name));
                            }
                        }
                        else
                        {
                            throw new Exception(
                                string.Format("Field '{0}' of struct '{1}' has a relationship defined but no display value.",
                                field.Name, str.Name));
                        }
                    }
                }
            }
        }

        private DataStruct GetStructByName(string name)
        {
            foreach (DataStruct str in _structures)
            {
                if (str.Name == name)
                {
                    return str;
                }
            }

            return null;
        }

        private DataField GetFieldByName(DataStruct str, string fieldName)
        {
            foreach (DataField field in str.Fields)
            {
                if (field.Name == fieldName)
                    return field;
            }

            return null;
        }

        //
        // Data Scripting API
        //

        public void CreateStructure(string name, string sourceFile)
        {
            var structure = new DataStruct();
            structure.Name = name;
            structure.SourceFile = sourceFile;
            _structures.Add(structure);
            _lastUsedStructure = _structures[_structures.Count - 1];
        }

        public void AddField(string fieldName, DataFieldType type, DataFieldType subtype = DataFieldType.NONE)
        {
            if (_lastUsedStructure == null)
            {
                return;
            }

            var field = new DataField();
            field.Name = fieldName;
            field.Type = type;
            if (type == DataFieldType.OFARRAY)
                field.ArrayType = subtype;

            _lastUsedStructure.Fields.Add(field);
            _lastUsedField = _lastUsedStructure.Fields[_lastUsedStructure.Fields.Count - 1];
        }

        public void SetFieldRelationship(string structRef, string fieldRef, string displayRef = "")
        {
            // get the current struct name
            var currentName = _lastUsedStructure.Name;
            if (!fieldsToValidate.ContainsKey(currentName))
            {
                fieldsToValidate.Add(currentName, new List<DataField>());
            }

            _lastUsedField.StructReference = structRef;
            _lastUsedField.FieldReference = fieldRef;
            _lastUsedField.DisplayReference = displayRef;

            fieldsToValidate[currentName].Add(_lastUsedField);
        }

        public void SetFieldRelationshipCustom(string[] source)
        {
            _lastUsedField.CustomDisplayReference = source;
        }

        public void SetFieldRelationshipCustom(string sourceName)
        {
            _lastUsedField.CustomReferenceSource = sourceName;
        }


        private static Environment _testEnv;
        public static Environment TestEnv
        {
            get
            {
                if (_testEnv == null)
                    _testEnv = new Environment();
                return _testEnv;
            }
        }

        private static Environment _mainEnv;
        public static Environment MainEnv
        {
            get
            {
                if (_mainEnv == null)
                    _mainEnv = new Environment();
                return _mainEnv;
            }
        }

    }
}
