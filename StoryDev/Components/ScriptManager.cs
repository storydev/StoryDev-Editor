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

namespace StoryDev.Components
{
    partial class ScriptManager : UserControl
    {

        private TreeNode lastSelected;

        public ScriptManager()
        {
            InitializeComponent();

            tvScripts.SuspendLayout();
            PopulateFolder(Globals.CurrentProjectFolder + "\\Scripts\\", tvScripts.Nodes[0]);
            PopulateFolder(Globals.CurrentProjectFolder + "\\Events\\", tvScripts.Nodes[1]);
            PopulateFolder(Globals.CurrentProjectFolder + "\\Data Modules\\", tvScripts.Nodes[2]);
            tvScripts.ResumeLayout();
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
                    }
                }
            }
        }

        private void tvScripts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lastSelected = e.Node;
        }
    }
}
