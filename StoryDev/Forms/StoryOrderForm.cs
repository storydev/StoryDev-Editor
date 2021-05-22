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
        public StoryOrderForm()
        {
            InitializeComponent();

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
            foreach (var order in Globals.StoryOrder.MainStory)
            {
                lbStory.Items.Add(order);
                cmbAfterStoryPart.Items.Add(order);
                cmbAfterStoryPart.AutoCompleteCustomSource.Add(order);
            }
        }

        private void StoryOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.SaveStoryOrder();
        }
    }
}
