using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Jint;
using Jint.Runtime;
using Jint.Runtime.Debugger;
using Jint.Runtime.Environments;

using StoryDev.DBO;
using StoryDev.DBO.Scripting;
using StoryDev.Forms;
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

        private Dictionary<string, List<DataField>> fieldsToValidate;

        private Dictionary<string, NewDataEntryForm> dataForms;
        private List<TabControl> tabControls;
        private NewDataEntryForm currentForm;
        private Dictionary<string, List<Tuple<string, string, string, FieldDisplay>>> syncedFields;
        private Dictionary<string, List<Tuple<string, dynamic>>> propertyList;
        private List<string> tabs;
        private List<Tuple<string, string, string>> tabPages;
        private List<Tuple<string, string, int>> layouts;
        private Dictionary<string, Control> pages;
        private Control lastControl;


        private int numColumns;
        private int previouslySetNumColumns;

        public Environment()
        {
            jEngine = new Engine(c =>
            {
                c.DebugMode();
            });

            //
            // Data API
            //
            jEngine.SetValue("CreateStructure", new Action<string>(CreateStructure));
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

            jEngine.SetValue("SOURCE_FILE", SourceType.File);
            jEngine.SetValue("SOURCE_DATABASE", SourceType.Database);

            jEngine.SetValue("DB_NONE", DatabaseVendor.None);
            jEngine.SetValue("DB_SQLITE", DatabaseVendor.SQLite);


            //
            // Data Forms API
            //
            jEngine.SetValue("CreateForm", new Action<string, string>(CreateForm));
            jEngine.SetValue("SyncField", new Action<string, string, FieldDisplay>(SyncField));
            jEngine.SetValue("SetProperties", new Action<dynamic>(SetProperties));
            jEngine.SetValue("BeginTabs", new Func<string, bool>(BeginTabs));
            jEngine.SetValue("BeginTabPage", new Func<string, bool>(BeginTabPage));
            jEngine.SetValue("EndTabs", new Action(EndTabs));
            jEngine.SetValue("EndTabPage", new Action(EndTabPage));
            jEngine.SetValue("BeginColumns", new Action<int, int, string>(BeginColumns));
            jEngine.SetValue("EndColumns", new Action(EndColumns));
            jEngine.SetValue("NextColumn", new Action(NextColumn));
            jEngine.SetValue("BeginPages", new Func<string, bool>(BeginPages));
            jEngine.SetValue("BeginPage", new Func<string, bool>(BeginPage));
            jEngine.SetValue("EndPages", new Action(EndPages));
            jEngine.SetValue("EndPage", new Action(EndPage));

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
            dataForms = new Dictionary<string, NewDataEntryForm>();
            syncedFields = new Dictionary<string, List<Tuple<string, string, string, FieldDisplay>>>();
            propertyList = new Dictionary<string, List<Tuple<string, dynamic>>>();
            tabs = new List<string>();
            tabPages = new List<Tuple<string, string, string>>();
            tabControls = new List<TabControl>();
            currentContainer = new List<ControlMethod>();
            layouts = new List<Tuple<string, string, int>>();
            pages = new Dictionary<string, Control>();
            numColumns = 0;

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
            currentContainer.Clear();
            layouts.Clear();
            pages.Clear();
            numColumns = 0;

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
                CreateTypes();

                var formsFile = Globals.CurrentProjectFolder + "\\Scripts\\Data\\Forms.js";
                if (File.Exists(formsFile))
                {
                    RunScript(formsFile);
                }
            }
        }

        public void CreateTypes()
        {
            ItemConstructor.Init();
            foreach (var str in _structures)
            {
                ItemConstructor.CreateType(str, typeof(DBO.Json.DBObject));
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

        public void CreateStructure(string name)
        {
            var structure = new DataStruct();
            structure.Name = name;
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

        private List<ControlMethod> currentContainer;

        public void CreateForm(string title, string structRef)
        {
            _lastUsedStructure = GetStructByName(structRef);


            if (_lastUsedStructure == null)
            {
                SubmitValidationError("Structure reference, '" + structRef + "', has not been defined.", "CreateForm");
                return;
            }

            if (currentContainer == null)
                currentContainer = new List<ControlMethod>();

            NewDataEntryForm form = new NewDataEntryForm();
            form.Text = title;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Padding = new Padding(15);
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Size = new Size(1280, 960);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Load += (object sender, EventArgs e) =>
            {
                foreach (var layout in layouts)
                {
                    if (layout.Item1 != title)
                        continue;

                    Control ctl = FindInnerControl(form, layout.Item2);
                    if (ctl != null)
                    {
                        if (ctl.GetType() == typeof(FlowLayoutPanel))
                        {
                            var columnWidth = ctl.Width / layout.Item3;
                            foreach (Control child in ctl.Controls)
                            {
                                child.Width = columnWidth;
                            }

                            break;
                        }
                    }
                }
            };

            _lastUsedStructure.DefinedFormName = title;

            dataForms.Add(title, form);
            currentForm = dataForms.ElementAt(dataForms.Count - 1).Value;
            currentContainer.Add(new ControlMethod()
            {
                Type = ControlType.Standard,
                Container = currentForm.GetContainer()
            });
        }

        public bool BeginPages(string id)
        {
            Control container = null;
            if (currentContainer == null || currentContainer.Count == 0)
            {
                SubmitValidationError("Forms API method being used without first calling CreateForm.", "BeginPages");
                return false;
            }

            var lastMethod = currentContainer[currentContainer.Count - 1];

            if (lastMethod.Type == ControlType.Standard)
                container = lastMethod.Container;
            else if (lastMethod.Type == ControlType.Pages)
                container = lastMethod.ContentContainer;

            var pnlContainer = new Panel();
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Padding = new Padding(0);

            var pnlPagesSide = new Panel();
            pnlPagesSide.Dock = DockStyle.Left;
            pnlPagesSide.Width = 250;
            pnlPagesSide.AutoScroll = true;
            pnlPagesSide.BackColor = Color.White;

            var pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Padding = new Padding(8);
            pnlContent.Tag = id;

            pnlContainer.SuspendLayout();
            pnlContainer.Controls.Add(pnlContent);
            pnlContainer.Controls.Add(pnlPagesSide);
            pnlContainer.ResumeLayout();

            currentContainer.Add(new ControlMethod()
            {
                Type = ControlType.Pages,
                Container = pnlPagesSide,
                ContentContainer = pnlContent
            });

            pnlPagesSide.SuspendLayout();
            pnlContent.SuspendLayout();

            container.Controls.Add(pnlContainer);

            return true;
        }

        public bool BeginPage(string text)
        {
            if (currentContainer == null || currentContainer.Count == 0)
            {
                SubmitValidationError("Forms API method being used without first calling CreateForm.", "BeginPage");
                return false;
            }

            ControlMethod lastMethod = currentContainer[currentContainer.Count - 1];
            if (lastMethod.Type != ControlType.Pages)
            {
                SubmitValidationError("BeginPage being used before calling BeginPages.", "BeginPage");
                return false;
            }

            var radio = new RadioButton();
            radio.Text = text;
            radio.ForeColor = Color.Black;
            radio.Height = 40;
            radio.Dock = DockStyle.Top;
            radio.Appearance = Appearance.Button;
            radio.Padding = new Padding(6);
            radio.Checked = false;
            radio.FlatStyle = FlatStyle.Flat;
            radio.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 48, 196);
            radio.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 48, 196);
            radio.FlatAppearance.BorderSize = 0;
            radio.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 128, 255);

            var contentWrapper = new Panel();
            contentWrapper.Dock = DockStyle.Fill;
            contentWrapper.AutoScroll = true;
            pages.Add(lastMethod.ContentContainer.Tag + "#" + text, contentWrapper);
            currentContainer.Add(new ControlMethod()
            {
                Type = ControlType.Standard,
                Container = contentWrapper
            });

            radio.CheckedChanged += (object sender, EventArgs e) =>
            {
                lastMethod.ContentContainer.Controls.Clear();
                var id = lastMethod.ContentContainer.Tag + "#" + text;
                if (pages.ContainsKey(id))
                {
                    pages[id].Location = new Point(0, 0);
                    pages[id].Size = new Size(lastMethod.ContentContainer.Width, lastMethod.ContentContainer.Height);
                    lastMethod.ContentContainer.Controls.Add(pages[id]);

                    foreach (var layout in layouts)
                    {
                        if (layout.Item1 != currentForm.Text)
                            continue;

                        Control ctl = FindInnerControl(lastMethod.ContentContainer, layout.Item2);
                        if (ctl != null)
                        {
                            if (ctl.GetType() == typeof(FlowLayoutPanel))
                            {
                                var columnWidth = ctl.Width / layout.Item3;
                                foreach (Control child in ctl.Controls)
                                {
                                    child.Width = columnWidth;
                                }

                                break;
                            }
                        }
                    }
                }
            };

            lastMethod.Container.Controls.Add(radio);
            lastMethod.Container.Controls.SetChildIndex(radio, 0);

            return true;
        }

        public void EndPage()
        {
            currentContainer.RemoveAt(currentContainer.Count - 1);
        }

        public void EndPages()
        {
            var lastMethod = currentContainer[currentContainer.Count - 1];
            lastMethod.Container.ResumeLayout();
            currentContainer.RemoveAt(currentContainer.Count - 1);
        }

        public bool BeginTabs(string id)
        {
            Control container = null;
            if (currentContainer == null || currentContainer.Count == 0)
            {
                SubmitValidationError("Forms API method being used without first calling CreateForm.", "BeginTabs");
                return false;
            }

            var lastMethod = currentContainer[currentContainer.Count - 1];

            if (lastMethod.Type == ControlType.Standard)
                container = lastMethod.Container;
            else if (lastMethod.Type == ControlType.Pages)
                container = lastMethod.ContentContainer;

            var tabControl = new TabControl();
            tabControl.Tag = id;
            tabControl.Dock = DockStyle.Fill;
            container.Controls.Add(tabControl);
            currentContainer.Add(new ControlMethod()
            {
                Type = ControlType.Standard,
                Container = tabControl
            });

            return true;
        }

        public bool BeginTabPage(string title)
        {
            Control container = null;
            var lastMethod = currentContainer[currentContainer.Count - 1];

            if (lastMethod.Type == ControlType.Standard)
                container = lastMethod.Container;
            else if (lastMethod.Type == ControlType.Pages)
                container = lastMethod.ContentContainer;

            if (container.GetType() != typeof(TabControl))
            {
                SubmitValidationError("BeginTabPage being called before BeginTabs.", "BeginTabPage");
                return false;
            }

            var tabPage = new TabPage();
            tabPage.Text = title;
            var tabContainer = new Panel();
            tabContainer.AutoScroll = true;
            tabContainer.Dock = DockStyle.Fill;
            tabContainer.Padding = new Padding(8);
            tabContainer.SuspendLayout();

            tabPage.Controls.Add(tabContainer);
            container.Controls.Add(tabPage);
            currentContainer.Add(new ControlMethod()
            {
                Type = ControlType.Standard,
                Container = tabContainer
            });

            return true;
        }

        public void EndTabPage()
        {
            var lastMethod = currentContainer[currentContainer.Count - 1];

            Control container = null;
            if (lastMethod.Type == ControlType.Standard)
                container = lastMethod.Container;
            else if (lastMethod.Type == ControlType.Pages)
                container = lastMethod.ContentContainer;

            container.ResumeLayout();
            currentContainer.RemoveAt(currentContainer.Count - 1);
        }

        public void EndTabs()
        {
            currentContainer.RemoveAt(currentContainer.Count - 1);
        }

        public void BeginColumns(int columns, int maxHeight = 150, string id = "")
        {
            if (id == null)
                id = "";

            Control container = null;
            if (currentContainer == null || currentContainer.Count == 0)
            {
                SubmitValidationError("Forms API method being used without first calling CreateForm.", "BeginColumns");
                return;
            }

            previouslySetNumColumns = numColumns = columns;

            var lastMethod = currentContainer[currentContainer.Count - 1];

            if (lastMethod.Type == ControlType.Standard)
                container = lastMethod.Container;
            else if (lastMethod.Type == ControlType.Pages)
                container = lastMethod.ContentContainer;

            var containerPanel = new FlowLayoutPanel();
            if (id != "")
                containerPanel.Tag = id;
            else
                containerPanel.Tag = "ContainerPanel" + (layouts.Count + 1);

            containerPanel.Size = new System.Drawing.Size(0, maxHeight);
            containerPanel.Dock = DockStyle.Top;
            containerPanel.Padding = new Padding(0);
            containerPanel.AutoScroll = true;
            containerPanel.FlowDirection = FlowDirection.LeftToRight;
            container.Controls.Add(containerPanel);
            layouts.Add(new Tuple<string, string, int>(currentForm.Text, (string)containerPanel.Tag, columns));

            currentContainer.Add(new ControlMethod()
            {
                Type = ControlType.Standard,
                Container = containerPanel
            });

            for (int i = 0; i < columns; i++)
            {
                var panel = new Panel();
                var width = container.Width / columns;
                panel.Size = new System.Drawing.Size(width, containerPanel.Height);
                panel.Margin = new Padding(0);
                panel.Padding = new Padding(8);
                containerPanel.Controls.Add(panel);
            }

            for (int i = columns - 1; i > -1; i--)
            {
                currentContainer.Add(new ControlMethod()
                {
                    Type = ControlType.Standard,
                    Container = containerPanel.Controls[i]
                });
            }
        }

        public void NextColumn()
        {
            if (numColumns - 1 > 0)
            {
                currentContainer.RemoveAt(currentContainer.Count - 1);
                numColumns -= 1;
            }
        }

        public void EndColumns()
        {
            currentContainer.RemoveAt(currentContainer.Count - 1);
            Control container = null;
            var lastMethod = currentContainer[currentContainer.Count - 1];

            if (lastMethod.Type == ControlType.Standard)
                container = lastMethod.Container;
            else if (lastMethod.Type == ControlType.Pages)
                container = lastMethod.ContentContainer;

            foreach (Control ctl in container.Controls)
            {
                ctl.Width = container.Width / previouslySetNumColumns;
            }

            previouslySetNumColumns = 0;
            currentContainer.RemoveAt(currentContainer.Count - 1);
        }

        public void SyncField(string fieldName, string displayText, FieldDisplay displayAs)
        {
            if (currentContainer == null || currentContainer.Count == 0 || _lastUsedStructure == null)
            {
                SubmitValidationError("Forms API method being used without first calling CreateForm.", "SyncField");
                return;
            }

            ConstructComponent(_lastUsedStructure.Name, fieldName, displayText, displayAs);
        }

        public void SetProperties(dynamic obj)
        {
            if (lastControl == null)
            {
                SubmitValidationError("SetProperties being called when no Field Component has been created.", "SetProperties");
                return;
            }

            SetPropertiesFor(lastControl, obj);
        }

        private void ConstructComponent(string structRef, string fieldName, string displayText, FieldDisplay displayAs)
        {
            Control container = null;
            if (currentContainer == null || currentContainer.Count == 0 || _lastUsedStructure == null)
            {
                SubmitValidationError("Forms API method being used without first calling CreateForm.", "SyncField");
                return;
            }

            var lastMethod = currentContainer[currentContainer.Count - 1];

            if (lastMethod.Type == ControlType.Standard)
                container = lastMethod.Container;
            else if (lastMethod.Type == ControlType.Pages)
                container = lastMethod.ContentContainer;

            DataStruct str = _lastUsedStructure;
            DataField field = GetFieldByName(str, fieldName);
            field.DisplayedAs = displayAs;
            if (field != null)
            {
                if (field.Type == DataFieldType.BOOLEAN)
                {
                    var checkbox = new FormCheckBox();
                    checkbox.DisplayName = displayText;
                    checkbox.Value = false;
                    checkbox.Dock = DockStyle.Top;
                    container.Controls.Add(checkbox);
                    container.Controls.SetChildIndex(checkbox, 0);
                    currentForm.AddFieldReference(field, checkbox);
                    lastControl = checkbox;
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

                    container.Controls.Add(datePicker);
                    container.Controls.SetChildIndex(datePicker, 0);
                    currentForm.AddFieldReference(field, datePicker);
                    lastControl = datePicker;
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

                    container.Controls.Add(numeric);
                    container.Controls.SetChildIndex(numeric, 0);
                    currentForm.AddFieldReference(field, numeric);
                    lastControl = numeric;
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
                        container.Controls.Add(dropdown);
                        container.Controls.SetChildIndex(dropdown, 0);
                        currentForm.AddFieldReference(field, dropdown);
                        lastControl = dropdown;
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

                        container.Controls.Add(numeric);
                        container.Controls.SetChildIndex(numeric, 0);
                        currentForm.AddFieldReference(field, numeric);
                        lastControl = numeric;
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

                        container.Controls.Add(textInput);
                        container.Controls.SetChildIndex(textInput, 0);
                        currentForm.AddFieldReference(field, textInput);
                        lastControl = textInput;
                    }
                    else if (displayAs == FieldDisplay.MultilineText)
                    {
                        var textInput = new FormTextMultiline();
                        textInput.DisplayName = displayText;
                        textInput.Value = "";
                        textInput.Dock = DockStyle.Top;

                        container.Controls.Add(textInput);
                        container.Controls.SetChildIndex(textInput, 0);
                        currentForm.AddFieldReference(field, textInput);
                        lastControl = textInput;
                    }
                }
                else if (field.Type == DataFieldType.OFARRAY)
                {
                    var arrayField = new FormArray();
                    arrayField.DisplayName = displayText;
                    arrayField.SetArrayType(field);
                    arrayField.Dock = DockStyle.Top;

                    container.Controls.Add(arrayField);
                    container.Controls.SetChildIndex(arrayField, 0);
                    currentForm.AddFieldReference(field, arrayField);
                    lastControl = arrayField;
                }
            }
        }

        private Control FindInnerControl(Control ctl, string tag)
        {
            foreach (Control child in ctl.Controls)
            {
                if ((string)child.Tag == tag)
                {         
                    return child;
                }
            }

            foreach (Control child in ctl.Controls)
            {
                return FindInnerControl(child, tag);
            }

            return null;
        }

        private void SetPropertiesFor(Control ctl, dynamic obj)
        {
            if (!(ctl is IFormComponent))
            {
                SubmitValidationError("The control being modified must be a field previously synced.", "SetProperties");
                return;
            }

            IFormComponent control = (IFormComponent)ctl;

            IDictionary<string, object> properties = (IDictionary<string, object>)obj;
            foreach (var kv in properties)
            {
                var inner = control.GetValueControl();
                var type = inner.GetType();
                var property = type.GetProperty(kv.Key);
                if (property != null)
                {
                    var valueType = kv.Value.GetType();
                    if (property.PropertyType == valueType)
                    {
                        property.SetValue(inner, kv.Value);
                    }
                }
                else
                {
                    SubmitValidationError(
                        string.Format("The property name '{0}' of type '{1}' does not exist.", kv.Key, type.Name), "");
                }
            }
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
