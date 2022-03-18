using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Scripting;
using StoryDev.Components;

namespace StoryDev.Forms
{
    internal partial class ScriptEditorForm : Form
    {

        private List<string> openPaths;

        public ScriptEditorForm()
        {
            InitializeComponent();

            if (!Directory.Exists(Globals.CurrentProjectFolder + "\\Scripts\\Game Functions\\"))
            {
                Directory.CreateDirectory(Globals.CurrentProjectFolder + "\\Scripts\\Game Functions\\");
            }

            if (!Directory.Exists(Globals.CurrentProjectFolder + "\\Scripts\\Data\\"))
            {
                Directory.CreateDirectory(Globals.CurrentProjectFolder + "\\Scripts\\Data\\");
            }

            openPaths = new List<string>();

            PopulateTreeList();
        }

        private void PopulateTreeList()
        {
            tvScriptFiles.Nodes.Clear();
            var root = new TreeNode();
            root.Text = "Scripts";
            root.ImageIndex = 1;
            root.SelectedImageIndex = 1;
            tvScriptFiles.Nodes.Add(root);

            PopulateTreeNode(root, Globals.CurrentProjectFolder + "\\Scripts\\");
        }

        private void PopulateTreeNode(TreeNode node, string path)
        {
            string[] directories = Directory.GetDirectories(path);
            
            node.Nodes.Clear();
            foreach (string dir in directories)
            {
                TreeNode dirNode = new TreeNode();
                dirNode.Text = dir.Substring(dir.LastIndexOf('\\') + 1);
                dirNode.ImageIndex = 1;
                dirNode.SelectedImageIndex = 1;

                PopulateTreeNode(dirNode, dir);
                node.Nodes.Add(dirNode);
            }

            string[] files = Directory.GetFiles(path, "*.hxs");
            foreach (string file in files)
            {
                TreeNode fileNode = new TreeNode();
                fileNode.ImageIndex = 0;
                fileNode.SelectedImageIndex = 0;
                fileNode.Text = Path.GetFileName(file);
                node.Nodes.Add(fileNode);
            }
        }

        private TreeNode GetNodeByPath(string path, TreeNode root = null)
        {
            if (path.StartsWith("Scripts"))
            {
                path = path.Substring("Scripts".Length + 1);
            }

            string[] splitted = path.Split('/');
            TreeNode temp = null;
            if (root == null)
            {
                temp = tvScriptFiles.Nodes[0];
            }
            else
            {
                temp = root;
            }

            foreach (TreeNode node in temp.Nodes)
            {
                if (node.Text == splitted[0])
                {
                    if (splitted.Length == 1)
                    {
                        return node;
                    }
                    else
                    {
                        string next = "";
                        for (int i = 1; i < splitted.Length; i++)
                        {
                            if (i < splitted.Length - 1)
                                next += splitted[i] + "/";
                            else
                                next += splitted[i];
                        }
                        return GetNodeByPath(next, node);
                    }
                }
            }

            return null;
        }

        private void tvScriptFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var path = e.Node.FullPath;

            foreach (string open in openPaths)
            {
                if (path == open)
                    return;
            }

            if (!File.Exists(Globals.CurrentProjectFolder + "\\" + path))
                return;

            var tabPage = new TabPage();
            var codeEditor = new CodeEditor();
            codeEditor.CurrentLanguage = Language.HaxeScript;
            codeEditor.OpenFile(Globals.CurrentProjectFolder + "\\" + path);
            codeEditor.Dock = DockStyle.Fill;
            tabPage.Text = Path.GetFileName(path);
            tabPage.Controls.Add(codeEditor);
            tcMain.TabPages.Add(tabPage);
            openPaths.Add(path);

            tcMain.SelectedIndex = tcMain.TabPages.Count - 1;
            saveToolStripMenuItem.Enabled = tcMain.SelectedIndex > -1;
        }

        private void cmsFolderOptions_Opening(object sender, CancelEventArgs e)
        {
            if (tvScriptFiles.SelectedNode == null)
            {
                e.Cancel = true;
            }
            else
            {
                var path = tvScriptFiles.SelectedNode.FullPath;
                if (path == "Scripts")
                {
                    e.Cancel = true;
                }

                createToolStripMenuItem.Enabled = Directory.Exists(Globals.CurrentProjectFolder + "\\" + path);
            }
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entry = new SimpleEntryForm();
            entry.Text = "New Folder";
            entry.NotEmpty = true;
            if (entry.ShowDialog() == DialogResult.OK)
            {
                var path = tvScriptFiles.SelectedNode.FullPath;
                Directory.CreateDirectory(Globals.CurrentProjectFolder + "\\" + path + "\\" + entry.Value);
                var node = GetNodeByPath(Globals.CurrentProjectFolder + "\\" + path);
                PopulateTreeNode(node, Globals.CurrentProjectFolder + "\\" + path);
                node.Expand();
            }
        }

        private void scriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entry = new SimpleEntryForm();
            entry.Text = "New Script File";
            entry.NotEmpty = true;
            if (entry.ShowDialog() == DialogResult.OK)
            {
                var path = tvScriptFiles.SelectedNode.FullPath;
                File.WriteAllText(Globals.CurrentProjectFolder + "\\" + path + "\\" + entry.Value + ".hxs", "");
                var node = GetNodeByPath(path);
                PopulateTreeNode(node, Globals.CurrentProjectFolder + "\\" + path);
                node.Expand();
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvScriptFiles.SelectedNode != null)
            {
                var currentPath = tvScriptFiles.SelectedNode.FullPath;
                var entry = new SimpleEntryForm();
                entry.Value = tvScriptFiles.SelectedNode.Text;
                entry.Text = "Rename";
                if (entry.ShowDialog() == DialogResult.OK)
                {
                    string path = currentPath.Substring(0, currentPath.LastIndexOf('/'));
                    Directory.Move(Globals.CurrentProjectFolder + "\\" + currentPath, Globals.CurrentProjectFolder + "\\" + path + "\\" + entry.Value);
                    tvScriptFiles.SelectedNode.Text = entry.Value;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvScriptFiles.SelectedNode != null)
            {
                var currentPath = tvScriptFiles.SelectedNode.FullPath;
                var response = MessageBox.Show(string.Format("Delete '{0}'?", tvScriptFiles.SelectedNode.Text), "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    if (currentPath == "Scripts/Data" || currentPath == "Scripts/Game Functions")
                    {
                        MessageBox.Show("You cannot delete this folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Directory.Exists(Globals.CurrentProjectFolder + "\\" + currentPath))
                    {
                        var files = Directory.GetFiles(Globals.CurrentProjectFolder + "\\" + currentPath);
                        foreach (var file in files)
                        {
                            File.Delete(file);
                        }
                        
                        Directory.Delete(Globals.CurrentProjectFolder + "\\" + currentPath);
                        var nodePath = currentPath.Substring(0, currentPath.LastIndexOf('/'));
                        var node = GetNodeByPath(nodePath);
                        PopulateTreeNode(node, Globals.CurrentProjectFolder + "\\" + nodePath);
                        if (node.Nodes.Count > 0)
                            node.Expand();
                    }
                    else
                    {
                        File.Delete(Globals.CurrentProjectFolder + "\\" + currentPath);
                        var nodePath = currentPath.Substring(0, currentPath.LastIndexOf('/'));
                        var node = GetNodeByPath(nodePath);
                        PopulateTreeNode(node, Globals.CurrentProjectFolder + "\\" + nodePath);
                        if (node.Nodes.Count > 0)
                            node.Expand();
                    }
                }
            }
        }

        private void testRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scripting.Environment.TestEnv.RunAllScripts();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab != null)
            {
                var casted = (CodeEditor)tcMain.SelectedTab.Controls[0];
                casted.SaveToFile(Globals.CurrentProjectFolder + "\\" + openPaths[tcMain.SelectedIndex], Encoding.UTF8);
            }
        }
    }
}
