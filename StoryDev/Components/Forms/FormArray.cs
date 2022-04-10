using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.DBO.Scripting;

namespace StoryDev.Components.Forms
{
    partial class FormArray : UserControl, IFormComponent
    {

        private DataFieldType arrayType;
        private FieldDisplay display;
        private List<object> arrayValues;

        public FormArray()
        {
            InitializeComponent();

            arrayValues = new List<object>();
        }

        public string DisplayName
        {
            get => lblHeader.Text;
            set => lblHeader.Text = value;
        }

        public object Value
        {
            get => GetResultArray();
            set => SetResultArray((object[])value);
        }

        public void SetArrayType(DataField field)
        {
            arrayType = field.ArrayType;
            display = field.DisplayedAs;

            if (field.ArrayType == DataFieldType.BOOLEAN)
            {
                pnlEnterValue.SuspendLayout();

                var btnTrue = new Button();
                btnTrue.Dock = DockStyle.Left;
                btnTrue.Text = "True";
                btnTrue.Click += BtnTrue_Click;
                pnlEnterValue.Controls.Add(btnTrue);

                var btnFalse = new Button();
                btnFalse.Dock = DockStyle.Left;
                btnFalse.Text = "False";
                btnFalse.Click += BtnFalse_Click;
                pnlEnterValue.Controls.Add(btnFalse);

                pnlEnterValue.ResumeLayout();
            }
            else if (field.ArrayType == DataFieldType.DATETIME)
            {
                var dtp = new DateTimePicker();
                dtp.Size = new Size(250, 0);
                dtp.Dock = DockStyle.Left;
                dtp.Value = DateTime.Now;
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                if (field.DisplayedAs == FieldDisplay.Date)
                {
                    dtp.CustomFormat = "dd/MM/yyyy";
                }
                else if (field.DisplayedAs == FieldDisplay.DateTime)
                {
                    dtp.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                }
                else if (field.DisplayedAs == FieldDisplay.Time)
                {
                    dtp.CustomFormat = "hh:mm:ss";
                }

                dtp.KeyUp += Enter_KeyUp;
                pnlEnterValue.Controls.Add(dtp);
            }
            else if (field.ArrayType == DataFieldType.FLOAT)
            {
                var numeric = new NumericUpDown();
                numeric.Value = 0.0m;
                numeric.DecimalPlaces = 2;
                numeric.Increment = 0.1m;
                numeric.Maximum = 999999999m;
                numeric.Size = new Size(250, 0);
                numeric.Dock = DockStyle.Left;

                numeric.KeyUp += Enter_KeyUp;
                pnlEnterValue.Controls.Add(numeric);
            }
            else if (field.ArrayType == DataFieldType.INTEGER)
            {
                var numeric = new NumericUpDown();
                numeric.Value = 0.0m;
                numeric.DecimalPlaces = 0;
                numeric.Maximum = 999999999m;
                numeric.Size = new Size(250, 0);
                numeric.Dock = DockStyle.Left;

                numeric.KeyUp += Enter_KeyUp;
                pnlEnterValue.Controls.Add(numeric);
            }
            else if (field.ArrayType == DataFieldType.STRING)
            {
                var textInput = new TextBox();
                textInput.Text = "";
                textInput.Size = new Size(250, 0);
                textInput.Dock = DockStyle.Left;

                textInput.KeyUp += Enter_KeyUp;
                pnlEnterValue.Controls.Add(textInput);
            }
        }

        private void BtnFalse_Click(object sender, EventArgs e)
        {
            arrayValues.Add(false);
            PopulateList();
            FormModified?.Invoke();
        }

        private void BtnTrue_Click(object sender, EventArgs e)
        {
            arrayValues.Add(true);
            PopulateList();
            FormModified?.Invoke();
        }

        private void Enter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender.GetType() == typeof(TextBox))
                {
                    var casted = (TextBox)sender;
                    arrayValues.Add(casted.Text);
                }
                else if (sender.GetType() == typeof(NumericUpDown))
                {
                    var casted = (NumericUpDown)sender;
                    arrayValues.Add(casted.Value);
                }
                else if (sender.GetType() == typeof(DateTimePicker))
                {
                    var casted = (DateTimePicker)sender;
                    arrayValues.Add(casted.Value);
                }

                PopulateList();
                FormModified?.Invoke();
            }
        }

        private void PopulateList()
        {
            pnlResults.Controls.Clear();
            pnlResults.SuspendLayout();

            for (int i = 0; i < arrayValues.Count; i++)
            {
                object val = arrayValues[i];
                var result = new FormArrayItem(i, arrayType, display);
                result.ItemValue = "" + (i + 1) + ": " + val.ToString();
                result.RawValue = val;
                result.Dock = DockStyle.Top;
                result.FormArrayItemDeleted += Result_FormArrayItemDeleted;
                result.FormArrayItemEdited += Result_FormArrayItemEdited;
                pnlResults.Controls.Add(result);
                pnlResults.Controls.SetChildIndex(result, 0);
            }

            pnlResults.ResumeLayout();
        }

        private void Result_FormArrayItemEdited(int index, object newValue)
        {
            arrayValues[index] = newValue;
            FormModified?.Invoke();
        }

        private void Result_FormArrayItemDeleted(int index)
        {
            arrayValues.RemoveAt(index);
            PopulateList();
            FormModified?.Invoke();
        }

        public object[] GetResultArray()
        {
            object[] result = arrayValues.ToArray();
            return result;
        }

        public Control GetValueControl()
        {
            return null;
        }

        public void SetResultArray(object[] values)
        {
            arrayValues.Clear();
            foreach (object val in values)
            {
                arrayValues.Add(val);
            }
        }

        public event OnFormArrayModified FormModified;
    }
}
