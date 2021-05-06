using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class CodeComponentForm : Form
    {

        ICodeComponent component;

        public CodeComponentForm(ICodeComponent component)
        {
            InitializeComponent();

            this.component = component;

            if (component.IsConditional)
            {
                pnlCondition.Visible = true;
                cmbConditionalOperator.SelectedIndex = 0;
            }

            pnlContent.Controls.Add(component.GetControl());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (component.IsValid())
            {
                var code = component.ToCodeString();
                if (component.IsConditional)
                    code += cmbConditionalOperator.SelectedIndex == 0 ? " &&" : " ||";
                else
                    code += ";";

                CodeStringAdded?.Invoke(code);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(component.GetErrorMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public event OnCodeStringAdded CodeStringAdded;
    }
}
