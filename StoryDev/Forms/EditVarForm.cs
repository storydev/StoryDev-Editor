using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;

namespace StoryDev.Forms
{
    partial class EditVarForm : Form
    {

        private Variable variable;
        private NumericUpDown numberValue;
        private TextBox stringValue;
        private ComboBox boolValue;

        public Variable Variable
        {
            get { return variable; }
        }

        public EditVarForm(Variable variable)
        {
            InitializeComponent();

            numberValue = new NumericUpDown();
            numberValue.Width = 200;
            numberValue.DecimalPlaces = 2;
            numberValue.Maximum = 99999999;
            numberValue.Minimum = -99999999;
            numberValue.Value = 0;
            numberValue.ValueChanged += NumberValue_ValueChanged;

            stringValue = new TextBox();
            stringValue.Width = 200;
            stringValue.Text = "";
            stringValue.TextChanged += StringValue_TextChanged;

            boolValue = new ComboBox();
            boolValue.Items.AddRange(new string[] { "False", "True" });
            boolValue.SelectedIndex = 0;
            boolValue.Width = 200;
            boolValue.DropDownStyle = ComboBoxStyle.DropDownList;
            boolValue.SelectedIndexChanged += BoolValue_SelectedIndexChanged;

            foreach (var chapter in Globals.Chapters)
            {
                cmbChapters.Items.Add(chapter);
            }

            this.variable = variable;
            cmbType.SelectedIndex = variable.Type;
            txtName.Text = variable.Name;
            cmbChapters.SelectedItem = variable.DeclaredScope;
            SwitchTypeControl();
        }

        private void BoolValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            variable.DefaultValue = boolValue.SelectedIndex == 1;
        }

        private void StringValue_TextChanged(object sender, EventArgs e)
        {
            variable.DefaultValue = stringValue.Text;
        }

        private void NumberValue_ValueChanged(object sender, EventArgs e)
        {
            variable.DefaultValue = numberValue.Value;
        }

        private void SwitchTypeControl()
        {
            pnlValueComponent.Controls.Clear();

            if (cmbType.SelectedIndex == 0)
            {
                pnlValueComponent.Controls.Add(boolValue);
                variable.DefaultValue = boolValue.SelectedIndex == 1;
            }
            else if (cmbType.SelectedIndex == 1)
            {
                pnlValueComponent.Controls.Add(numberValue);
                variable.DefaultValue = numberValue.Value;
            }
            else if (cmbType.SelectedIndex == 2)
            {
                pnlValueComponent.Controls.Add(stringValue);
                variable.DefaultValue = stringValue.Text;
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            variable.Type = cmbType.SelectedIndex;
            SwitchTypeControl();
        }

        private void cmbChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            variable.DeclaredScope = (string)cmbChapters.SelectedItem;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            variable.Name = txtName.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var found = Globals.Variables.Find((v) => v.Name == txtName.Text);
            if (found != null)
            {
                MessageBox.Show("You cannot have two variables with the same name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
