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
    partial class StoryOrderForm : Form
    {

        private int selectedJournal = -1;

        public StoryOrderForm()
        {
            InitializeComponent();

            foreach (var journal in Globals.Journals)
            {

            }

            PopulateOrders();
            PopulateAllFiles();
        }

        private void PopulateAllFiles()
        {
            tvFiles.Nodes.Clear();

            var folder = Globals.CurrentProjectFolder + "\\Chapters";
            var root = new TreeNode();
            root.Text = "Chapters";

            AddFiles(folder, root);

            tvFiles.Nodes.Add(root);
        }

        private void AddFiles(string path, TreeNode parent)
        {
            var directories = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path, "*.sdc");
            foreach (var directory in directories)
            {
                var node = new TreeNode();
                var dirPath = directory.Substring(directory.LastIndexOf('\\') + 1);
                node.Text = dirPath;
                parent.Nodes.Add(node);
                AddFiles(directory, node);
            }

            foreach (var file in files)
            {
                var node = new TreeNode();
                var fPath = file.Substring(file.LastIndexOf('\\') + 1, file.Length - file.LastIndexOf('\\') - 1);
                node.Text = fPath;
                parent.Nodes.Add(node);
            }
        }

        private void PopulateOrders()
        {
            lbStory.SuspendLayout();
            lbStory.Items.Clear();
            cmbAfterStoryPart.Items.Clear();
            cmbAfterStoryPart.AutoCompleteCustomSource.Clear();

            foreach (var order in Globals.StoryOrder.MainStory)
            {
                lbStory.Items.Add(order);
                cmbAfterStoryPart.Items.Add(order);
                cmbAfterStoryPart.AutoCompleteCustomSource.Add(order);
            }
            lbStory.ResumeLayout();
        }

        private void StoryOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.SaveStoryOrder();
        }

        private bool IsFolder(string path)
        {
            return !File.Exists(path) && Directory.Exists(path);
        }

        private bool IsFileAdded(string file)
        {
            foreach (var order in Globals.StoryOrder.MainStory)
            {
                if (file == order)
                {
                    return true;
                }
            }

            foreach (var kv in Globals.StoryOrder.JournalStories)
            {
                foreach (var v in kv.Value)
                {
                    if (file == v)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tvFiles.SelectedNode != null)
            {
                var path = tvFiles.SelectedNode.FullPath;
                if (!IsFileAdded(path) && !IsFolder(Globals.CurrentProjectFolder + "\\" + path))
                {
                    Globals.StoryOrder.MainStory.Add(path);
                    PopulateOrders();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                lbStory.Items.RemoveAt(lbStory.SelectedIndex);
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                var temp = Globals.StoryOrder.MainStory[lbStory.SelectedIndex];
                Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                Globals.StoryOrder.MainStory.Insert(0, temp);
                PopulateOrders();
                lbStory.SelectedIndex = 0;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                var up = lbStory.SelectedIndex - 1;
                if (up > -1)
                {
                    var temp = Globals.StoryOrder.MainStory[lbStory.SelectedIndex];
                    Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                    Globals.StoryOrder.MainStory.Insert(up, temp);
                    PopulateOrders();
                    lbStory.SelectedIndex = up;
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                var down = lbStory.SelectedIndex + 1;
                if (down < lbStory.Items.Count - 1)
                {
                    var temp = Globals.StoryOrder.MainStory[lbStory.SelectedIndex];
                    Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                    Globals.StoryOrder.MainStory.Insert(down, temp);
                    PopulateOrders();
                    lbStory.SelectedIndex = down;
                }
            }
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                var temp = Globals.StoryOrder.MainStory[lbStory.SelectedIndex];
                Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                Globals.StoryOrder.MainStory.Add(temp);
                PopulateOrders();
                lbStory.SelectedIndex = lbStory.Items.Count - 1;
            }
        }
    }
}
