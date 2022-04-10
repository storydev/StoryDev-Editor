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

namespace StoryDev.Forms
{
    partial class EditArrayItemForm : Form
    {

        private DataFieldType type;

        public object NewValue { get; private set; }

        public EditArrayItemForm(DataFieldType type, FieldDisplay display, object currentValue)
        {
            InitializeComponent();

            this.type = type;

            if (type == DataFieldType.BOOLEAN)
            {
                pnlEntryValue.SuspendLayout();

                var combo = new ComboBox();
                combo.Items.AddRange(new string[] { "False", "True" });
                combo.Size = new Size(250, 0);
                combo.Dock = DockStyle.Left;
                combo.SelectedIndex = (Convert.ToBoolean(currentValue)) ? 1 : 0;

                pnlEntryValue.ResumeLayout();
            }
            else if (type == DataFieldType.DATETIME)
            {
                var dtp = new DateTimePicker();
                dtp.Size = new Size(250, 0);
                dtp.Dock = DockStyle.Left;
                dtp.Value = Convert.ToDateTime(currentValue);
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                if (display == FieldDisplay.Date)
                {
                    dtp.CustomFormat = "dd/MM/yyyy";
                }
                else if (display == FieldDisplay.DateTime)
                {
                    dtp.CustomFormat = "dd/MM/yyyy hh:mm:ss";
                }
                else if (display == FieldDisplay.Time)
                {
                    dtp.CustomFormat = "hh:mm:ss";
                }

                pnlEntryValue.Controls.Add(dtp);
            }
            else if (type == DataFieldType.FLOAT)
            {
                var numeric = new NumericUpDown();
                numeric.Value = Convert.ToDecimal(currentValue);
                numeric.DecimalPlaces = 2;
                numeric.Increment = 0.1m;
                numeric.Maximum = 999999999m;
                numeric.Size = new Size(250, 0);
                numeric.Dock = DockStyle.Left;

                pnlEntryValue.Controls.Add(numeric);
            }
            else if (type == DataFieldType.INTEGER)
            {
                var numeric = new NumericUpDown();
                numeric.Value = Convert.ToDecimal(currentValue);
                numeric.DecimalPlaces = 0;
                numeric.Maximum = 999999999m;
                numeric.Size = new Size(250, 0);
                numeric.Dock = DockStyle.Left;

                pnlEntryValue.Controls.Add(numeric);
            }
            else if (type == DataFieldType.STRING)
            {
                var textInput = new TextBox();
                textInput.Text = Convert.ToString(currentValue);
                textInput.Size = new Size(250, 0);
                textInput.Dock = DockStyle.Left;

                pnlEntryValue.Controls.Add(textInput);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var ctl = pnlEntryValue.Controls[0];
            if (ctl.GetType() == typeof(TextBox))
            {
                var casted = (TextBox)ctl;
                NewValue = casted.Text;
            }
            else if (ctl.GetType() == typeof(ComboBox))
            {
                var casted = (ComboBox)ctl;
                NewValue = casted.SelectedIndex == 1;
            }
            else if (ctl.GetType() == typeof(NumericUpDown))
            {
                var casted = (NumericUpDown)ctl;
                if (type == DataFieldType.FLOAT)
                    NewValue = (float)casted.Value;
                else if (type == DataFieldType.INTEGER)
                    NewValue = (int)casted.Value;
            }
            else if (ctl.GetType() == typeof(DateTimePicker))
            {
                var casted = (DateTimePicker)ctl;
                NewValue = casted.Value;
            }

            DialogResult = DialogResult.OK;
        }


    }
}
