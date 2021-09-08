using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Forms;
using StoryDev.Data;

namespace StoryDev.Components
{
    partial class ScriptManager : UserControl
    {

        private TreeNode lastSelected;
        private TreeNode lastFileNode;
        private string lastFile;
        private bool requiresSave;

        public ScriptManager()
        {
            InitializeComponent();

            tvScripts.SuspendLayout();
            PopulateFolder(Globals.CurrentProjectFolder + "\\Scripts\\", tvScripts.Nodes[0]);
            PopulateFolder(Globals.CurrentProjectFolder + "\\Events\\", tvScripts.Nodes[1]);
            PopulateFolder(Globals.CurrentProjectFolder + "\\Data Modules\\", tvScripts.Nodes[2]);
            tvScripts.ResumeLayout();

            editor.CurrentLanguage = Language.HaxeScript;
        }

        private void PopulateFolder(string folder, TreeNode parent)
        {
            parent.Nodes.Clear();

            foreach (var path in Directory.GetDirectories(folder))
            {
                var dirName = Globals.ShortenName(path);
                var node = new TreeNode();
                node.Text = dirName;
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;
                node.ContextMenuStrip = cmsRootOptions;

                parent.Nodes.Add(node);

                PopulateFolder(folder + dirName + "\\", node);
            }

            foreach (var file in Directory.GetFiles(folder, "*.hxs"))
            {
                var fileName = Globals.ShortenName(file);
                var node = new TreeNode();
                node.Text = fileName;
                node.ImageIndex = 1;
                node.SelectedImageIndex = 1;

                parent.Nodes.Add(node);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lastSelected != null)
            {
                var currentPath = lastSelected.FullPath;
                if (Directory.Exists(Globals.CurrentProjectFolder + "\\" + currentPath))
                {
                    var entry = new SimpleEntryForm();
                    entry.Text = "New Folder";
                    if (entry.ShowDialog() == DialogResult.OK)
                    {
                        Directory.CreateDirectory(Globals.CurrentProjectFolder + "\\" + currentPath + "\\" + entry.Value);
                        tvScripts.SuspendLayout();
                        PopulateFolder(Globals.CurrentProjectFolder + "\\" + currentPath + "\\", lastSelected);
                        tvScripts.ResumeLayout();
                    }
                }
            }
        }

        private void scriptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lastSelected != null)
            {
                var currentPath = lastSelected.FullPath;
                if (Directory.Exists(Globals.CurrentProjectFolder + "\\" + currentPath))
                {
                    var entry = new SimpleEntryForm();
                    entry.Text = "New Script File";
                    if (entry.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(Globals.CurrentProjectFolder + "\\" + currentPath + "\\" + entry.Value + ".hxs", "");
                        tvScripts.SuspendLayout();
                        PopulateFolder(Globals.CurrentProjectFolder + "\\" + currentPath + "\\", lastSelected);
                        tvScripts.ResumeLayout();

                        lastSelected.Expand();
                    }
                }
            }
        }

        private void tvScripts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lastSelected = e.Node;

            pnlFileOptions.Controls.Clear();

            if (lastSelected.FullPath == "Data Modules")
            {
                var properties = new Scripting.DataModuleFolderProperties() { Dock = DockStyle.Fill };
                properties.RequestDataModuleRefresh += () =>
                {
                    RequestDataModuleRefresh?.Invoke();
                };
                pnlFileOptions.Controls.Add(properties);
                pnlFileOptions.Enabled = true;
            }

            if (lastSelected.FullPath.EndsWith(".hxs"))
            {
                if (lastSelected.FullPath.StartsWith("Scripts"))
                {
                    ScriptFileData data;
                    if (!Globals.ScriptData.ContainsKey(lastSelected.FullPath))
                    {
                        Globals.ScriptData.Add(lastSelected.FullPath, new ScriptFileData());
                    }

                    data = Globals.ScriptData[lastSelected.FullPath];

                    var properties = new Scripting.ScriptFileProperties(data);
                    properties.Dock = DockStyle.Fill;
                    pnlFileOptions.Controls.Add(properties);
                    pnlFileOptions.Enabled = true;

                    Globals.SaveScriptData();
                }

                var contents = File.ReadAllText(Globals.CurrentProjectFolder + "\\" + lastSelected.FullPath);
                editor.Text = contents;

                lastFile = Globals.CurrentProjectFolder + "\\" + lastSelected.FullPath;
                lastFileNode = lastSelected;

                editor.Enabled = true;
                TabNameChanged?.Invoke(lastSelected.Text);
                SaveStateChanged?.Invoke(false);
            }
        }

        private void editor_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
            requiresSave = true;
            SaveStateChanged?.Invoke(requiresSave);
        }

        private void editor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                requiresSave = false;
                SaveStateChanged?.Invoke(requiresSave);
                File.WriteAllText(lastFile, editor.Text);
            }
        }

        private void tvScripts_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(lastFile) && requiresSave)
            {
                var response = MessageBox.Show("Would you like to save the script before continuing?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    requiresSave = false;
                    File.WriteAllText(lastFile, editor.Text);
                }
                else if (response == DialogResult.No)
                {
                    requiresSave = false;
                }
                else if (response == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        public event OnTabNameChange TabNameChanged;
        public event OnSaveStateChanged SaveStateChanged;
        public event OnRequestDataModuleRefresh RequestDataModuleRefresh;
    }
}
