using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Forms
{
    partial class SimpleEntryForm : Form
    {

        public string Value
        {
            get { return txtEnterField.Text; }
            set { txtEnterField.Text = value; }
        }

        public bool NotEmpty
        {
            get; set;
        }

        public string RegexPattern
        {
            get; set;
        }

        public string ErrorValue
        {
            get; set;
        }

        public SimpleEntryForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (NotEmpty)
            {
                if (txtEnterField.Text == "")
                {
                    MessageBox.Show("Field must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(RegexPattern))
            {
                var regex = new Regex(RegexPattern);
                if (!regex.IsMatch(txtEnterField.Text))
                {
                    var error = "";
                    if (!string.IsNullOrEmpty(ErrorValue))
                        error = ErrorValue;
                    else
                        error = "The value entered does not follow the given pattern: " + RegexPattern + ".";

                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }
    }
}
