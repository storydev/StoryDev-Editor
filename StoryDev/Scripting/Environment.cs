using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
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

        public Engine CurrentEngine
        {
            get => jEngine;
        }

        private string _currentlyExecutingFilePath;
        private DataStruct _lastUsedStructure;
        private DataField _lastUsedField;
        private string _lastSetSyncField;

        private Dictionary<string, List<DataField>> fieldsToValidate;

        private Dictionary<string, Form> dataForms;
        private List<TabControl> tabControls;
        private Form currentForm;
        private Dictionary<string, List<Tuple<string, string, string, FieldDisplay>>> syncedFields;
        private Dictionary<string, List<Tuple<string, dynamic>>> propertyList;
        private List<string> tabs;
        private string currentTabControl;
        private List<Tuple<string, string, string>> tabPages;
        private string currentTabPage;

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
            jEngine.SetValue("SetProperties", new Action<dynamic>(SetProperties));
            jEngine.SetValue("BeginTabs", new Func<string, bool>(BeginTabs));
            jEngine.SetValue("BeginTabPage", new Func<string, bool>(BeginTabPage));
            jEngine.SetValue("EndTabs", new Action(EndTabs));
            jEngine.SetValue("EndTabPage", new Action(EndTabPage));

            jEngine.SetValue("DISPLAY_DATE", FieldDisplay.Date);
            jEngine.SetValue("DISPLAY_DATETIME", FieldDisplay.DateTime);
            jEngine.SetValue("DISPLAY_DROPDOWN", FieldDisplay.Dropdown);
            jEngine.SetValue("DISPLAY_MULTILINE", FieldDisplay.MultilineText);
            jEngine.SetValue("DISPLAY_NUMERIC", FieldDisplay.Numeric);
            jEngine.SetValue("DISPLAY_SINGLELINE", FieldDisplay.SingleText);
            jEngine.SetValue("DISPLAY_TIME", FieldDisplay.Time);
            jEngine.SetValue("DISPLAY_ARRAY", FieldDisplay.Array);


            jEngine.DebugHandler.Step += DebugHandler_Step;

            fieldsToValidate = new Dictionary<string, List<DataField>>();
            dataForms = new Dictionary<string, Form>();
            syncedFields = new Dictionary<string, List<Tuple<string, string, string, FieldDisplay>>>();
            propertyList = new Dictionary<string, List<Tuple<string, dynamic>>>();
            tabs = new List<string>();
            tabPages = new List<Tuple<string, string, string>>();
            tabControls = new List<TabControl>();

            _errors = new List<ScriptError>();
            _errorsForThrow = new List<ScriptError>();
            _structures = new List<DataStruct>();
        }

        private StepMode DebugHandler_Step(object sender, DebugInformation e)
        {
            

            return StepMode.Over;
        }

        public void Clear()
        {
            _structures.Clear();
            _errors.Clear();
            _errorsForThrow.Clear();

            fieldsToValidate.Clear();
            dataForms.Clear();
            syncedFields.Clear();
            propertyList.Clear();
            tabControls.Clear();
            tabs.Clear();
            tabPages.Clear();
            currentTabPage = "";
            currentTabControl = "";

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

                //
                // Currently, the way the codebase here is setup, we need to validate
                // before we can define forms. This is because we need to know if we need to
                // construct components with their respective relationships.
                //
                // If necessary, we may need to divide this up into two separate script categories,
                // which may allow for a cleaner setup here, and easier to code, more specifically,
                // but means more restrictive measures on how scripts can be written.
                //
                // Perhaps functionality should be added to standard script files to allow initialising
                // forms, and hide form generation scripts by default.
                //


                var tabPageNames = new Dictionary<string, List<string>>();
                foreach (var pages in tabPages)
                {
                    if (!tabPageNames.ContainsKey(pages.Item1))
                    {
                        tabPageNames.Add(pages.Item1, new List<string>());
                    }

                    List<string> list = tabPageNames[pages.Item1];
                    bool found = false;
                    foreach (var item in list)
                    {
                        if (item == pages.Item2)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        list.Add(pages.Item2);
                    }
                }

                foreach (var tabControl in tabPageNames)
                {
                    var tc = new TabControl();
                    tc.Tag = tabControl.Key;
                    tc.Dock = DockStyle.Fill;
                    foreach (var page in tabControl.Value)
                    {
                        var tabPage = new TabPage();
                        tabPage.Text = page;
                        var scrollContainer = new Panel();
                        scrollContainer.Dock = DockStyle.Fill;
                        scrollContainer.AutoScroll = true;
                        tabPage.Controls.Add(scrollContainer);

                        tc.TabPages.Add(tabPage);
                    }
                    tabControls.Add(tc);
                }

                foreach (var tc in tabControls)
                {
                    // Assuming we are just using one tab control.
                    // Should be refactored.
                    currentForm.Controls.Add(tc);
                }

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
                
                foreach (var sync in syncedFields)
                {
                    string structName = "";
                    foreach (var field in sync.Value)
                    {
                        if (structName == "")
                        {
                            structName = field.Item1;
                            break;
                        }
                    }
                    SetComponentProperties(structName);
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
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Size = new System.Drawing.Size(1280, 960);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            _lastUsedStructure.DefinedFormName = title;

            dataForms.Add(title, form);
            currentForm = dataForms.ElementAt(dataForms.Count - 1).Value;
        }

        public bool BeginTabs(string id)
        {
            currentTabControl = id;
            return true;
        }

        public bool BeginTabPage(string title)
        {
            currentTabPage = title;
            return true;
        }

        public void EndTabPage()
        {
            currentTabPage = string.Empty;
        }

        public void EndTabs()
        {
            tabs.Add(currentTabPage);
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

            if (!propertyList.ContainsKey(currentForm.Text))
            {
                propertyList.Add(currentForm.Text, new List<Tuple<string, dynamic>>());
            }

            var list = syncedFields[currentForm.Text];
            list.Add(new Tuple<string, string, string, FieldDisplay>(_lastUsedStructure.Name, fieldName, displayText, displayAs));
            if (!string.IsNullOrEmpty(currentTabControl) && !string.IsNullOrEmpty(currentTabPage))
            {
                tabPages.Add(new Tuple<string, string, string>(currentTabControl, currentTabPage, fieldName));
            }

            _lastSetSyncField = displayText;
        }

        public void SetProperties(dynamic obj)
        {
            if (string.IsNullOrEmpty(_lastSetSyncField))
            {
                SubmitValidationError("Function being used without previously having created a synced field.", "SetProperties");
                return;
            }

            if (propertyList.ContainsKey(currentForm.Text))
            {
                propertyList[currentForm.Text].Add(new Tuple<string, dynamic>(_lastSetSyncField, obj));
            }
        }

        private void ConstructComponent(string structRef, string fieldName, string displayText, FieldDisplay displayAs)
        {
            Control parentControl = null;
            foreach (var pages in tabPages)
            {
                var breakout = false;
                if (pages.Item3 == fieldName)
                {
                    foreach (var tc in tabControls)
                    {
                        if ((string)tc.Tag == pages.Item1)
                        {
                            foreach (TabPage page in tc.TabPages)
                            {
                                if (page.Text == pages.Item2)
                                {
                                    parentControl = page.Controls[0];
                                    breakout = true;
                                    break;
                                }
                            }
                        }

                        if (breakout)
                            break;
                    }
                }

                if (breakout)
                    break;
            }

            if (parentControl == null)
                parentControl = currentForm;

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
                    parentControl.Controls.Add(checkbox);
                    parentControl.Controls.SetChildIndex(checkbox, 0);
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

                    parentControl.Controls.Add(datePicker);
                    parentControl.Controls.SetChildIndex(datePicker, 0);
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

                    parentControl.Controls.Add(numeric);
                    parentControl.Controls.SetChildIndex(numeric, 0);
                }
                else if (field.Type == DataFieldType.INTEGER)
                {
                    if (displayAs == FieldDisplay.Dropdown)
                    {
                        var dropdown = new FormDropdown();
                        dropdown.DisplayName = displayText;
                        dropdown.Value = 0;
                        var combo = (ComboBox)dropdown.GetValueControl();
                        combo.Items.AddRange(GetFieldRelationshipValues(jEngine, field));
                        parentControl.Controls.Add(dropdown);
                        parentControl.Controls.SetChildIndex(dropdown, 0);
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

                        parentControl.Controls.Add(numeric);
                        parentControl.Controls.SetChildIndex(numeric, 0);
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

                        parentControl.Controls.Add(textInput);
                        parentControl.Controls.SetChildIndex(textInput, 0);
                    }
                    else if (displayAs == FieldDisplay.MultilineText)
                    {
                        var textInput = new FormTextMultiline();
                        textInput.DisplayName = displayText;
                        textInput.Value = "";
                        textInput.Dock = DockStyle.Top;

                        parentControl.Controls.Add(textInput);
                        parentControl.Controls.SetChildIndex(textInput, 0);
                    }
                }
                else if (field.Type == DataFieldType.OFARRAY)
                {
                    var arrayField = new FormArray();
                    arrayField.DisplayName = displayText;
                    arrayField.SetArrayType(field);
                    arrayField.Dock = DockStyle.Top;

                    parentControl.Controls.Add(arrayField);
                    parentControl.Controls.SetChildIndex(arrayField, 0);
                }
            }
        }

        private void SetComponentProperties(string structRef)
        {
            var str = GetStructByName(structRef);
            if (!string.IsNullOrEmpty(str.DefinedFormName))
            {
                if (propertyList.ContainsKey(str.DefinedFormName))
                {
                    var list = propertyList[str.DefinedFormName];
                    foreach (var prop in list)
                    {
                        var control = GetControlFromForm(str.DefinedFormName, prop.Item1);
                        SetPropertiesFor(control, prop.Item2);
                    }
                }
            }
        }

        private void SetPropertiesFor(Control ctl, dynamic obj)
        {
            IDictionary<string, object> properties = (IDictionary<string, object>)obj;
            foreach (var kv in properties)
            {
                var type = ctl.GetType();
                var property = type.GetProperty(kv.Key);
                if (property != null)
                {
                    var valueType = kv.Value.GetType();
                    if (property.PropertyType == valueType)
                    {
                        property.SetValue(ctl, kv.Value);
                    }
                }
                else
                {
                    SubmitValidationError(
                        string.Format("The property name '{0}' of type '{1}' does not exist.", kv.Key, type.Name), "");
                }
            }
        }

        private Control GetControlFromForm(string formName, string displayName)
        {
            Control result = null;

            if (dataForms.ContainsKey(formName))
            {
                var form = dataForms[formName];
                foreach (Control ctl in form.Controls)
                {
                    if (ctl is IFormComponent)
                    {
                        var casted = (IFormComponent)ctl;
                        if (casted.DisplayName == displayName)
                        {
                            result = ctl;
                            break;
                        }
                    }

                    if (result == null)
                        result = FindInnerControl(ctl, displayName);

                    if (result != null)
                        break;
                }
            }

            return result;
        }

        private Control FindInnerControl(Control control, string displayName)
        {
            Control result = null;
            if (control.Controls.Count > 0)
            {
                foreach (Control inner in control.Controls)
                {
                    if (inner is IFormComponent)
                    {
                        var casted = (IFormComponent)inner;
                        if (casted.DisplayName == displayName)
                        {
                            result = inner;
                            break;
                        }
                    }

                    if (result == null)
                        result = FindInnerControl(inner, displayName);

                    if (result != null)
                        break;
                }
            }

            return result;
        }

        public static string[] GetFieldRelationshipValues(Engine jEngine, DataField field)
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
            _errors.Add(error);
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
