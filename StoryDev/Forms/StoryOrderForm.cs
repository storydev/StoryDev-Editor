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
                cmbJournals.Items.Add(journal.Name);
                cmbJournals.AutoCompleteCustomSource.Add(journal.Name);
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

        private void PopulateJournalOrder(int id)
        {
            var order = Globals.StoryOrder.JournalStories[id];
            lbJournalStoryOrder.Items.Clear();
            foreach (var o in order)
            {
                lbJournalStoryOrder.Items.Add(o);
            }
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
                    var temp = -1;
                    if (selectedJournal > -1)
                    {
                        var journal = Globals.Journals[selectedJournal];
                        temp = Globals.StoryOrder.JournalsAfterPart[journal.ID];
                    }

                    PopulateOrders();

                    if (selectedJournal > -1)
                    {
                        cmbAfterStoryPart.SelectedIndex = temp;
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                for (int i = 0; i < Globals.StoryOrder.JournalsAfterPart.Count; i++)
                {
                    var key = Globals.StoryOrder.JournalsAfterPart.Keys.ElementAt(i);
                    var val = Globals.StoryOrder.JournalsAfterPart.Values.ElementAt(i);
                    if (val > lbStory.SelectedIndex)
                        Globals.StoryOrder.JournalsAfterPart[key] -= 1;
                    else if (val == lbStory.SelectedIndex)
                        Globals.StoryOrder.JournalsAfterPart[key] = -1;
                }

                if (selectedJournal > -1)
                {
                    var journal = Globals.Journals[selectedJournal];
                    cmbAfterStoryPart.SelectedIndex = Globals.StoryOrder.JournalsAfterPart[journal.ID];
                }

                Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                lbStory.Items.RemoveAt(lbStory.SelectedIndex);
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                var temp = Globals.StoryOrder.MainStory[lbStory.SelectedIndex];
                var keysToAdd = new List<int>();
                var keysToModify = new List<int>();
                foreach (var kv in Globals.StoryOrder.JournalsAfterPart)
                {
                    var key = kv.Key;
                    var val = kv.Value;
                    if (val == lbStory.SelectedIndex)
                    {
                        keysToModify.Add(key);
                    }
                    else if (val < lbStory.SelectedIndex)
                    {
                        keysToAdd.Add(key);
                    }
                }

                foreach (var k in keysToModify)
                {
                    Globals.StoryOrder.JournalsAfterPart[k] = 0;
                }

                foreach (var k in keysToAdd)
                {
                    Globals.StoryOrder.JournalsAfterPart[k] += 1;
                }

                Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                Globals.StoryOrder.MainStory.Insert(0, temp);
                PopulateOrders();
                lbStory.SelectedIndex = 0;

                if (selectedJournal > -1)
                {
                    var journal = Globals.Journals[selectedJournal];
                    cmbAfterStoryPart.SelectedIndex = Globals.StoryOrder.JournalsAfterPart[journal.ID];
                }
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

                    for (int i = 0; i < Globals.StoryOrder.JournalsAfterPart.Count; i++)
                    {
                        var kv = Globals.StoryOrder.JournalsAfterPart.ElementAt(i);
                        if (kv.Value == lbStory.SelectedIndex)
                        {
                            Globals.StoryOrder.JournalsAfterPart[kv.Key] = up;
                        }
                        else if (kv.Value == up)
                        {
                            Globals.StoryOrder.JournalsAfterPart[kv.Key] = lbStory.SelectedIndex;
                        }
                    }

                    Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                    Globals.StoryOrder.MainStory.Insert(up, temp);
                    PopulateOrders();
                    lbStory.SelectedIndex = up;

                    if (selectedJournal > -1)
                    {
                        var journal = Globals.Journals[selectedJournal];
                        cmbAfterStoryPart.SelectedIndex = Globals.StoryOrder.JournalsAfterPart[journal.ID];
                    }
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                var down = lbStory.SelectedIndex + 1;
                if (down < lbStory.Items.Count)
                {
                    var temp = Globals.StoryOrder.MainStory[lbStory.SelectedIndex];

                    for (int i = 0; i < Globals.StoryOrder.JournalsAfterPart.Count; i++)
                    {
                        var kv = Globals.StoryOrder.JournalsAfterPart.ElementAt(i);
                        if (kv.Value == lbStory.SelectedIndex)
                        {
                            Globals.StoryOrder.JournalsAfterPart[kv.Key] = down;
                        }
                        else if (kv.Value == down)
                        {
                            Globals.StoryOrder.JournalsAfterPart[kv.Key] = lbStory.SelectedIndex;
                        }
                    }

                    Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                    Globals.StoryOrder.MainStory.Insert(down, temp);
                    PopulateOrders();
                    lbStory.SelectedIndex = down;

                    if (selectedJournal > -1)
                    {
                        var journal = Globals.Journals[selectedJournal];
                        cmbAfterStoryPart.SelectedIndex = Globals.StoryOrder.JournalsAfterPart[journal.ID];
                    }
                }
            }
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            if (lbStory.SelectedIndex > -1)
            {
                var temp = Globals.StoryOrder.MainStory[lbStory.SelectedIndex];
                var keysToAdd = new List<int>();
                var keysToModify = new List<int>();
                foreach (var kv in Globals.StoryOrder.JournalsAfterPart)
                {
                    var key = kv.Key;
                    var val = kv.Value;
                    if (val == lbStory.SelectedIndex)
                    {
                        keysToModify.Add(key);
                    }
                    else if (val > lbStory.SelectedIndex)
                    {
                        keysToAdd.Add(key);
                    }
                }

                foreach (var k in keysToModify)
                {
                    Globals.StoryOrder.JournalsAfterPart[k] = cmbAfterStoryPart.Items.Count - 1;
                }

                foreach (var k in keysToAdd)
                {
                    Globals.StoryOrder.JournalsAfterPart[k] -= 1;
                }

                Globals.StoryOrder.MainStory.RemoveAt(lbStory.SelectedIndex);
                Globals.StoryOrder.MainStory.Add(temp);
                PopulateOrders();
                lbStory.SelectedIndex = lbStory.Items.Count - 1;

                if (selectedJournal > -1)
                {
                    var journal = Globals.Journals[selectedJournal];
                    cmbAfterStoryPart.SelectedIndex = Globals.StoryOrder.JournalsAfterPart[journal.ID];
                }
            }
        }

        private void cmbJournals_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedJournal = cmbJournals.SelectedIndex;

            if (selectedJournal > -1)
            {
                var journal = Globals.Journals[selectedJournal];
                if (Globals.StoryOrder.JournalStories.ContainsKey(journal.ID))
                {
                    PopulateJournalOrder(journal.ID);
                    var afterPart = Globals.StoryOrder.JournalsAfterPart[journal.ID];

                    lbJournalStoryOrder.Enabled = true;
                    pnlJournalOptions.Enabled = true;
                    cmbAfterStoryPart.SelectedIndexChanged -= cmbAfterStoryPart_SelectedIndexChanged;
                    cmbAfterStoryPart.SelectedIndex = afterPart;
                    cmbAfterStoryPart.SelectedIndexChanged += cmbAfterStoryPart_SelectedIndexChanged;
                }
                else
                {
                    var list = new List<string>();
                    Globals.StoryOrder.JournalStories.Add(journal.ID, list);
                    lbJournalStoryOrder.Items.Clear();
                    lbJournalStoryOrder.Enabled = true;
                    Globals.StoryOrder.JournalsAfterPart.Add(journal.ID, -1);
                    cmbAfterStoryPart.SelectedIndexChanged -= cmbAfterStoryPart_SelectedIndexChanged;
                    cmbAfterStoryPart.SelectedIndex = -1;
                    cmbAfterStoryPart.SelectedIndexChanged += cmbAfterStoryPart_SelectedIndexChanged;
                    pnlJournalOptions.Enabled = true;
                }
            }
            else
            {
                lbJournalStoryOrder.Items.Clear();
                lbJournalStoryOrder.Enabled = false;
                pnlJournalOptions.Enabled = false;
            }
        }

        private void cmbAfterStoryPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedJournal > -1)
            {
                var journal = Globals.Journals[selectedJournal];
                if (Globals.StoryOrder.JournalsAfterPart.ContainsKey(journal.ID))
                {
                    Globals.StoryOrder.JournalsAfterPart[journal.ID] = cmbAfterStoryPart.SelectedIndex;
                }
            }
        }

        private void btnAddToJournals_Click(object sender, EventArgs e)
        {
            if (selectedJournal > -1 && tvFiles.SelectedNode != null)
            {
                var journal = Globals.Journals[selectedJournal];
                var path = tvFiles.SelectedNode.FullPath;
                if (!IsFileAdded(path) && !IsFolder(Globals.CurrentProjectFolder + "\\" + path))
                {
                    var list = Globals.StoryOrder.JournalStories[journal.ID];
                    list.Add(path);
                    PopulateJournalOrder(journal.ID);
                }
            }
        }

        private void btnRemoveFromJournals_Click(object sender, EventArgs e)
        {
            if (selectedJournal > -1 && lbJournalStoryOrder.SelectedIndex > -1)
            {
                var journal = Globals.Journals[selectedJournal];
                Globals.StoryOrder.JournalStories[journal.ID].RemoveAt(lbJournalStoryOrder.SelectedIndex);
                lbJournalStoryOrder.Items.RemoveAt(lbJournalStoryOrder.SelectedIndex);
            }
        }

        private void btnTopJournals_Click(object sender, EventArgs e)
        {
            if (selectedJournal > -1 && lbJournalStoryOrder.SelectedIndex > -1)
            {

            }
        }
    }
}
