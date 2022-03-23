using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using Jint;
using Jint.Runtime;
using Jint.Runtime.Debugger;
using Jint.Runtime.Environments;

using StoryDev.Components;
using StoryDev.Components.Forms;

namespace StoryDev.Scripting
{
    internal class Environment
    {

        private Engine jEngine;

        private List<ScriptError> _errorsForThrow;

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

        private string _currentlyExecutingFilePath;
        private DataStruct _lastUsedStructure;
        private DataField _lastUsedField;

        private Dictionary<string, List<DataField>> fieldsToValidate;

        private Dictionary<string, Form> dataForms;
        private Form currentForm;
        private Dictionary<string, List<Tuple<string, string, string, FieldDisplay>>> syncedFields;

        public Environment()
        {
            jEngine = new Engine(c =>
            {
                c.DebugMode();
            });

            //
            // Data API
            //
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

            //
            // Data Forms API
            //
            jEngine.SetValue("CreateForm", new Action<string>(CreateForm));
            jEngine.SetValue("SyncField", new Action<string, string, FieldDisplay>(SyncField));

            jEngine.SetValue("DISPLAY_DATE", FieldDisplay.Date);
            jEngine.SetValue("DISPLAY_DATETIME", FieldDisplay.DateTime);
            jEngine.SetValue("DISPLAY_DROPDOWN", FieldDisplay.Dropdown);
            jEngine.SetValue("DISPLAY_MULTILINE", FieldDisplay.MultilineText);
            jEngine.SetValue("DISPLAY_NUMERIC", FieldDisplay.Numeric);
            jEngine.SetValue("DISPLAY_SINGLELINE", FieldDisplay.SingleText);
            jEngine.SetValue("DISPLAY_TIME", FieldDisplay.Time);


            jEngine.DebugHandler.Step += DebugHandler_Step;

            fieldsToValidate = new Dictionary<string, List<DataField>>();
            dataForms = new Dictionary<string, Form>();
            syncedFields = new Dictionary<string, List<Tuple<string, string, string, FieldDisplay>>>();

            _errors = new List<ScriptError>();
            _errorsForThrow = new List<ScriptError>();
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
            {
                Validate();

                foreach (var sync in syncedFields)
                {
                    Form form = null;
                    if (dataForms.ContainsKey(sync.Key))
                    {
                        form = dataForms[sync.Key];
                        currentForm = form;
                    }

                    foreach (var field in sync.Value)
                    {
                        ConstructComponent(field.Item1, field.Item2, field.Item3, field.Item4);
                    }
                }
            }
        }

        public bool RunScript(string filename)
        {
            _currentlyExecutingFilePath = filename;
            var contents = File.ReadAllText(filename);
            try
            {
                jEngine.Execute(contents);

                if (_errorsForThrow.Count > 0)
                {
                    return false;
                }

                return true;
            }
            catch (JavaScriptException jEx)
            {
                var error = new ScriptError();
                error.Type = ErrorType.Standard;
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

        public void ShowForm(string name)
        {
            if (dataForms.ContainsKey(name))
            {
                dataForms[name].ShowDialog();
            }
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

        //
        // Data Forms Scripting API
        //

        public void CreateForm(string title)
        {
            if (_lastUsedStructure == null)
            {
                SubmitValidationError("Function is being used without first defining a data structure.", "CreateForm");
                return;
            }

            Form form = new Form();
            form.Text = title;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Padding = new Padding(15);
            _lastUsedStructure.DefinedFormName = title;

            dataForms.Add(title, form);
            currentForm = dataForms.ElementAt(dataForms.Count - 1).Value;
        }

        public void SyncField(string fieldName, string displayText, FieldDisplay displayAs)
        {
            if (currentForm == null)
            {
                SubmitValidationError("Function is being used without first calling `CreateForm`.", "SyncField");
                return;
            }

            if (_lastUsedStructure == null)
            {
                SubmitValidationError("Function is being used without first defining a data structure.", "SyncField");
                return;
            }

            if (!syncedFields.ContainsKey(currentForm.Text))
            {
                syncedFields.Add(currentForm.Text, new List<Tuple<string, string, string, FieldDisplay>>());
            }

            var list = syncedFields[currentForm.Text];
            list.Add(new Tuple<string, string, string, FieldDisplay>(_lastUsedStructure.Name, fieldName, displayText, displayAs));
        }

        private void ConstructComponent(string structRef, string fieldName, string displayText, FieldDisplay displayAs)
        {
            DataStruct str = GetStructByName(structRef);
            DataField field = GetFieldByName(str, fieldName);
            if (field != null)
            {
                if (field.Type == DataFieldType.BOOLEAN)
                {
                    var checkbox = new FormCheckBox();
                    checkbox.DisplayName = displayText;
                    checkbox.Value = false;
                    checkbox.Dock = DockStyle.Top;
                    currentForm.Controls.Add(checkbox);
                    currentForm.Controls.SetChildIndex(checkbox, 0);
                }
                else if (field.Type == DataFieldType.DATETIME)
                {
                    var datePicker = new FormDateTime();
                    datePicker.DisplayName = displayText;
                    datePicker.Value = DateTime.Now;
                    datePicker.Dock = DockStyle.Top;
                    var picker = (DateTimePicker)datePicker.GetValueControl();

                    if (displayAs == FieldDisplay.Date)
                    {
                        picker.CustomFormat = "dd/MM/yyyy";
                    }
                    else if (displayAs == FieldDisplay.DateTime)
                    {
                        picker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                    }
                    else if (displayAs == FieldDisplay.Time)
                    {
                        picker.CustomFormat = "hh:mm:ss";
                    }

                    currentForm.Controls.Add(datePicker);
                    currentForm.Controls.SetChildIndex(datePicker, 0);
                }
                else if (field.Type == DataFieldType.FLOAT)
                {
                    var numeric = new FormNumber();
                    numeric.DisplayName = displayText;
                    numeric.Value = 0.0m;
                    numeric.Dock = DockStyle.Top;

                    var nud = (NumericUpDown)numeric.GetValueControl();
                    nud.DecimalPlaces = 2;
                    nud.Increment = 0.1m;
                    nud.Maximum = 999999999m;

                    currentForm.Controls.Add(numeric);
                    currentForm.Controls.SetChildIndex(numeric, 0);
                }
                else if (field.Type == DataFieldType.INTEGER)
                {
                    if (displayAs == FieldDisplay.Dropdown)
                    {
                        var dropdown = new FormDropdown();
                        dropdown.DisplayName = displayText;
                        dropdown.Value = 0;
                        var combo = (ComboBox)dropdown.GetValueControl();
                        combo.Items.AddRange(GetFieldRelationshipValues(field));
                        currentForm.Controls.Add(dropdown);
                        currentForm.Controls.SetChildIndex(dropdown, 0);
                    }
                    else if (displayAs == FieldDisplay.Numeric)
                    {
                        var numeric = new FormNumber();
                        numeric.DisplayName = displayText;
                        numeric.Value = 0.0m;
                        numeric.Dock = DockStyle.Top;

                        var nud = (NumericUpDown)numeric.GetValueControl();
                        nud.DecimalPlaces = 0;
                        nud.Maximum = 999999999m;

                        currentForm.Controls.Add(numeric);
                        currentForm.Controls.SetChildIndex(numeric, 0);
                    }
                }
                else if (field.Type == DataFieldType.STRING)
                {
                    if (displayAs == FieldDisplay.SingleText)
                    {
                        var textInput = new FormTextInput();
                        textInput.DisplayName = displayText;
                        textInput.Value = "";
                        textInput.Dock = DockStyle.Top;

                        currentForm.Controls.Add(textInput);
                        currentForm.Controls.SetChildIndex(textInput, 0);
                    }
                    else if (displayAs == FieldDisplay.MultilineText)
                    {
                        var textInput = new FormTextMultiline();
                        textInput.DisplayName = displayText;
                        textInput.Value = "";
                        textInput.Dock = DockStyle.Top;

                        currentForm.Controls.Add(textInput);
                        currentForm.Controls.SetChildIndex(textInput, 0);
                    }
                }
            }
        }

        private string[] GetFieldRelationshipValues(DataField field)
        {
            string[] results = null;

            if (!string.IsNullOrEmpty(field.StructReference))
            {
                // @TODO
            }
            else if (!string.IsNullOrEmpty(field.CustomReferenceSource))
            {
                var value = jEngine.GetValue(field.CustomReferenceSource);
                if (value != null)
                {
                    if (value.IsArray())
                    {
                        results = (string[])value.AsArray().ToObject();
                    }
                }
            }
            else if (field.CustomDisplayReference != null)
            {
                results = field.CustomDisplayReference;
            }

            return results;
        }


        private void SubmitValidationError(string message, string context)
        {
            var error = new ScriptError();
            error.Type = ErrorType.Validation;
            error.Message = message;
            error.FilePath = _currentlyExecutingFilePath;
            error.Context = context;
            _errorsForThrow.Add(error);
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
