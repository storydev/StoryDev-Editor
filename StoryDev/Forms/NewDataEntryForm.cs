using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;
using StoryDev.Components.Forms;
using StoryDev.Scripting;
using StoryDev.DBO;
using StoryDev.DBO.Scripting;

namespace StoryDev.Forms
{
    partial class NewDataEntryForm : Form
    {

        private bool isEditing;
        private IDBObject instance;
        private IInstanceManager manager;

        private List<DataFieldRef> references;
        private Dictionary<string, FieldInfo> fields;

        public NewDataEntryForm(IInstanceManager manager, IDBObject obj = null)
        {
            InitializeComponent();

            references = new List<DataFieldRef>();
            fields = new Dictionary<string, FieldInfo>();

            this.manager = manager;

            if (obj != null)
            {
                instance = obj;
            }
            else
            {
                var type = ItemConstructor.ResolvedTypes[manager.StructReference.Name];
                instance = (IDBObject)Activator.CreateInstance(type);
            }

            foreach (var field in instance.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                fields.Add(field.Name, field);
            }
        }

        public Control GetContainer()
        {
            return pnlContent;
        }

        public void SetInitialValues(Dictionary<string, object> values)
        {
            foreach (var kv in values)
            {
                var item = references.Find((df) => df.FieldRef.Name == kv.Key);
                item.Value = kv.Value;

                if (item.ValueControl.GetType() == typeof(TextBox))
                {
                    ((TextBox)item.ValueControl).Text = Convert.ToString(kv.Value);
                }
                else if (item.ValueControl.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)item.ValueControl).Value = Convert.ToDecimal(kv.Value);
                }
                else if (item.ValueControl.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)item.ValueControl).Checked = Convert.ToBoolean(kv.Value);
                }
                else if (item.ValueControl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)item.ValueControl).Value = Convert.ToDateTime(kv.Value);
                }
                else if (item.ValueControl.GetType() == typeof(ComboBox))
                {
                    if (!string.IsNullOrEmpty(item.FieldRef.StructReference))
                    {

                    }

                    ((ComboBox)item.ValueControl).SelectedIndex = Convert.ToInt32(kv.Value);
                }
            }
        }

        public void UpdateField(string name, object value)
        {
            fields.TryGetValue(name, out FieldInfo info);
            if (info != null)
            {
                if (info.FieldType == typeof(decimal))
                    info.SetValue(instance, Convert.ToDecimal(value));
                else if (info.FieldType == typeof(int))
                    info.SetValue(instance, Convert.ToInt32(value));
                else if (info.FieldType == typeof(uint))
                    info.SetValue(instance, Convert.ToUInt32(value));
                else if (info.FieldType == typeof(short))
                    info.SetValue(instance, Convert.ToInt16(value));
                else if (info.FieldType == typeof(ushort))
                    info.SetValue(instance, Convert.ToUInt16(value));
                else if (info.FieldType == typeof(sbyte))
                    info.SetValue(instance, Convert.ToSByte(value));
                else if (info.FieldType == typeof(byte))
                    info.SetValue(instance, Convert.ToByte(value));
                else if (info.FieldType == typeof(long))
                    info.SetValue(instance, Convert.ToInt64(value));
                else if (info.FieldType == typeof(ulong))
                    info.SetValue(instance, Convert.ToUInt64(value));
                else if (info.FieldType == typeof(float))
                    info.SetValue(instance, Convert.ToSingle(value));
                else if (info.FieldType == typeof(bool))
                    info.SetValue(instance, Convert.ToBoolean(value));
                else if (info.FieldType == typeof(DateTime))
                    info.SetValue(instance, Convert.ToDateTime(value));
                else
                {
                    info.SetValue(instance, value);
                }
            }
        }


        public void AddFieldReference(DataField field, Control ctl)
        {
            int nextIndex = references.Count;

            DataFieldRef fieldRef = new DataFieldRef();
            fieldRef.FieldRef = field;

            if (field.Type == DataFieldType.BOOLEAN)
            {
                var casted = (CheckBox)((IFormComponent)ctl).GetValueControl();
                casted.CheckedChanged += (object sender, EventArgs e) =>
                {
                    references[nextIndex].Value = casted.Checked;
                    UpdateField(field.Name, references[nextIndex].Value);
                };
                fieldRef.ValueControl = casted;
            }
            else if (field.Type == DataFieldType.DATETIME)
            {
                var casted = (DateTimePicker)((IFormComponent)ctl).GetValueControl();
                casted.ValueChanged += (object sender, EventArgs e) =>
                {
                    references[nextIndex].Value = casted.Value;
                    UpdateField(field.Name, references[nextIndex].Value);

                };
                fieldRef.ValueControl = casted;
            }
            else if (field.Type == DataFieldType.FLOAT)
            {
                var casted = (NumericUpDown)((IFormComponent)ctl).GetValueControl();
                casted.ValueChanged += (object sender, EventArgs e) =>
                {
                    references[nextIndex].Value = casted.Value;
                    UpdateField(field.Name, references[nextIndex].Value);

                };
                fieldRef.ValueControl = casted;
            }
            else if (field.Type == DataFieldType.INTEGER)
            {
                if (field.DisplayedAs == FieldDisplay.Dropdown)
                {
                    var casted = (ComboBox)((IFormComponent)ctl).GetValueControl();
                    casted.SelectedIndexChanged += (object sender, EventArgs e) =>
                    {
                        references[nextIndex].Value = casted.SelectedIndex;
                        UpdateField(field.Name, references[nextIndex].Value);

                    };
                    fieldRef.ValueControl = casted;
                }
                else if (field.DisplayedAs == FieldDisplay.Numeric)
                {
                    var casted = (NumericUpDown)((IFormComponent)ctl).GetValueControl();
                    casted.ValueChanged += (object sender, EventArgs e) =>
                    {
                        references[nextIndex].Value = casted.Value;
                        UpdateField(field.Name, references[nextIndex].Value);

                    };
                    fieldRef.ValueControl = casted;
                }
            }
            else if (field.Type == DataFieldType.STRING)
            {
                var casted = (TextBox)((IFormComponent)ctl).GetValueControl();
                casted.TextChanged += (object sender, EventArgs e) =>
                {
                    references[nextIndex].Value = casted.Text;
                    UpdateField(field.Name, references[nextIndex].Value);

                };
                fieldRef.ValueControl = casted;
            }
            else if (field.Type == DataFieldType.OFARRAY)
            {
                var casted = (FormArray)ctl;
                casted.FormModified += () =>
                {
                    references[nextIndex].Value = casted.Value;
                    UpdateField(field.Name, references[nextIndex].Value);

                };
                fieldRef.ValueControl = casted;
            }

            references.Add(fieldRef);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
                instance.Update();
            else
                instance.Insert();

            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isEditing)
                instance.Delete();

            Close();
        }
    }
}
