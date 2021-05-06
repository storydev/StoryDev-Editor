using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StoryDev.Forms
{
    partial class ChapterBrowserForm : Form
    {
        public ChapterBrowserForm()
        {
            InitializeComponent();

            PopulateChapters();
        }

        private void PopulateChapters()
        {
            lbChapters.Items.Clear();

            foreach (var chapter in Globals.Chapters)
            {
                lbChapters.Items.Add(chapter);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you wish to delete this chapter? You will remove all associated conversations.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                Directory.Delete(Globals.CurrentProjectFolder + "\\" + (string)lbChapters.SelectedItem, true);
                Globals.ReloadChapters();
                PopulateChapters();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var entry = new SimpleEntryForm();
            entry.Text = "Add Chapter";
            if (entry.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(Globals.CurrentProjectFolder + "\\" + entry.Value);
                Globals.ReloadChapters();
                PopulateChapters();
            }
        }
    }
}
