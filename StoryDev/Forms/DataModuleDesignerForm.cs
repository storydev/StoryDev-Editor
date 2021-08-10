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
    partial class DataModuleDesignerForm : Form
    {

        private FormProperties properties;

        public DataModuleDesignerForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            InitializeComponent();

            properties = new FormProperties();
            
            if (Globals.Settings.FormComponents != null)
            {
                if (Globals.Settings.FormComponents.Count > 0)
                {
                    properties.FormComponents = Globals.Settings.FormComponents;
                }
                else
                {
                    properties.FormComponents = Globals.GetDefaultComponentSettings();
                }
            }
            else
            {
                properties.FormComponents = Globals.GetDefaultComponentSettings();
            }

            txtFormName.Text = properties.FormName;
            txtInstanceName.Text = properties.InstanceName;
            properties.Margin = 10;
            properties.GlobalPadding = 10;
            properties.AllMargins = true;
            properties.AutoWidthFields = true;
        }

        private void txtFormName_TextChanged(object sender, EventArgs e)
        {
            properties.FormName = txtFormName.Text;
        }

        private void txtInstanceName_Leave(object sender, EventArgs e)
        {
            if (!IsValidName(txtInstanceName.Text))
            {
                MessageBox.Show("The name supplied for the instance of this form is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInstanceName.Focus();
            }
            else
            {
                properties.InstanceName = txtInstanceName.Text;
            }
        }

        private bool IsValidName(string name)
        {
            var first = true;
            for (int i = 0; i < name.Length; i++)
            {
                if (first)
                {
                    if (!(name[i] == '_' || (name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z')))
                        return false;

                    first = false;
                }
                else
                {
                    if (!(name[i] == '_' || (name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= '0' && name[i] <= '9')))
                        return false;
                }
            }

            return true;
        }

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            new DataModuleFormPropertiesForm(properties).ShowDialog();
        }
    }
}
