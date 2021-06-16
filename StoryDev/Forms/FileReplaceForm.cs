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

namespace StoryDev.Forms
{
    partial class FileReplaceForm : Form
    {

        private string filename;
        private string ext;

        private string fileToCopy;
        public string FileToCopy
        {
            get
            {
                return fileToCopy;
            }
            set
            {
                fileToCopy = value;
                ext = Path.GetExtension(fileToCopy);
                var file = Path.GetFileName(fileToCopy);
                filename = file.Substring(0, file.LastIndexOf('.'));
            }
        }

        public string ResultPath
        {
            get; set;
        }

        public FileReplaceForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbReplaceExisting.Checked)
            {
                var resourcePath = Globals.GetResourcesPath();
                File.Copy(fileToCopy, resourcePath + "\\" + filename + ext, true);
                ResultPath = resourcePath + "\\" + filename + ext;
                DialogResult = DialogResult.OK;
            }
            else if (rdbMakeNewCopy.Checked)
            {
                int index = 1;
                while (CheckCopy(index)) index++;

                var resourcePath = Globals.GetResourcesPath();
                File.Copy(fileToCopy, resourcePath + "\\" + filename + "(" + index + ")" + ext);
                ResultPath = resourcePath + "\\" + filename + "(" + index + ")" + ext;
                DialogResult = DialogResult.OK;
            }
            else if (rdbSetNewName.Checked)
            {
                if (!string.IsNullOrEmpty(txtNewName.Text))
                {
                    var resourcePath = Globals.GetResourcesPath();
                    if (!File.Exists(resourcePath + "\\" + txtNewName.Text + ext))
                    {
                        File.Copy(fileToCopy, resourcePath + "\\" + txtNewName.Text + ext);
                        ResultPath = resourcePath + "\\" + txtNewName.Text + ext;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("The file with the name '" + txtNewName.Text + "' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool CheckCopy(int index)
        {
            var newName = filename + "(" + index + ")";
            var resourcePath = Globals.GetResourcesPath();
            return File.Exists(resourcePath + "\\" + newName + ext);
        }
    }
}
