using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;

using StoryDev.Data;

namespace StoryDev.Forms
{
    partial class ProjectSettingsForm : Form
    {

        public ProjectSettingsForm()
        {
            InitializeComponent();

            
        }

        private void txtKhaProjectFolder_TextChanged(object sender, EventArgs e)
        {
            Globals.CurrentProject.KhaProjectPath = txtKhaProjectFolder.Text;
        }

        private void txtScriptsOutput_TextChanged(object sender, EventArgs e)
        {
            Globals.CurrentProject.ScriptsOutput = txtScriptsOutput.Text;

        }

        private void txtResourcesOutput_TextChanged(object sender, EventArgs e)
        {
            Globals.CurrentProject.ResourcesOutput = txtResourcesOutput.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Globals.CurrentProject.ConversationsOutput = txtConversationOutput.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFolder = new VistaFolderBrowserDialog();
            openFolder.ShowNewFolderButton = true;
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                txtKhaProjectFolder.Text = openFolder.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveProjectSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
