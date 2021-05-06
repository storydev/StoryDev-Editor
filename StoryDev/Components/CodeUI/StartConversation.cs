using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace StoryDev.Components.CodeUI
{
    partial class StartConversation : UserControl, ICodeComponent
    {
        public StartConversation()
        {
            InitializeComponent();
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("StartConversation(".Length, code.LastIndexOf(')') - "StartConversation(".Length);
            if (result.StartsWith("\""))
                result = result.Trim('"');
            else if (result.StartsWith("'"))
                result = result.Trim('\'');

            cmbConvoFile.Text = result;
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (string.IsNullOrEmpty(cmbConvoFile.Text))
                return "File path value is empty.";

            if (!File.Exists(Globals.CurrentProjectFolder + "\\" + cmbConvoFile.Text))
                return "File path given does not exist.";

            return "";
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(cmbConvoFile.Text))
                return false;

            if (!File.Exists(Globals.CurrentProjectFolder + "\\" + cmbConvoFile.Text))
                return false;

            return true;
        }

        public string ToCodeString()
        {
            return string.Format("StartConversation('{0}')", cmbConvoFile.Text);
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            var folderStart = Globals.CurrentProjectFolder;
            if (!string.IsNullOrEmpty(cmbConvoFile.Text))
            {
                var folder = cmbConvoFile.Text;
                folderStart = folder.Substring(0, folder.LastIndexOf('\\'));
            }

            var open = new OpenFileDialog();
            open.Filter = "StoryDev Conversations|*.sdc";
            open.InitialDirectory = folderStart;
            open.Title = "Find Conversation";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.FileName.StartsWith(Globals.CurrentProjectFolder))
                {
                    cmbConvoFile.Text = open.FileName.Substring(Globals.CurrentProjectFolder.Length + 1);
                }
                else
                {
                    MessageBox.Show("You must select a file that exists within the current project's folder path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
