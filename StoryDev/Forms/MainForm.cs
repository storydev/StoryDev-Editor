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

using StoryDev.Components;

namespace StoryDev.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Globals.GlobalInit();
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFolder = new VistaFolderBrowserDialog();
            openFolder.ShowNewFolderButton = true;
            openFolder.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                Globals.SetProjectFolder(openFolder.SelectedPath);
                var folderName = openFolder.SelectedPath.Substring(openFolder.SelectedPath.LastIndexOf('\\') + 1);
                Text = "StoryDev - " + folderName;

                viewToolStripMenuItem.Enabled = true;
                saveAllToolStripMenuItem.Enabled = true;         
            }
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Globals.SaveAll();
            Cursor = Cursors.Default;
        }

        private void conversationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConversationEditor().Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreferencesForm().ShowDialog();
        }

        private void storyFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tcMain.TabPages.Count; i++)
            {
                var page = tcMain.TabPages[i];
                if (page.Text == "Story Flow")
                {
                    tcMain.SelectedIndex = i;
                    return;
                }
            }

            var wrapper = new StoryFlowWrapper()
            {
                Dock = DockStyle.Fill,
            };
            var tab = new TabPage();
            tab.Text = "Story Flow";
            tab.Controls.Add(wrapper);
            tcMain.TabPages.Add(tab);
        }
    }
}
