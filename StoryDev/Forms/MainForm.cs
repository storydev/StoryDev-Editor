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
                Text = "StoryDev Story Creator - " + folderName;

                viewToolStripMenuItem.Enabled = true;
                resourcesToolStripMenuItem.Enabled = true;
                saveAllToolStripMenuItem.Enabled = true;
                dataToolStripMenuItem.Enabled = true;
                projectToolStripMenuItem.Enabled = true;
            }
        }

        private void iconSetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IconSetsForm().ShowDialog();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Globals.SaveAll();
            Cursor = Cursors.Default;
        }

        private void conversationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConversationEditor().Show(this);
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PreferencesForm().ShowDialog();
        }

        private void convoFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var finder = new ConvoFinderForm();
            finder.RequestOpenForm += RequestOpenForm;
            finder.Show(this);
        }

        private void RequestOpenForm(FormType type, string[] data)
        {
            if (type == FormType.Form_ConversationEditor)
            {
                var editor = new ConversationEditor();
                editor.OpenFile(data[0]);
                editor.Show(this);
            }
        }

        private void scriptEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ScriptEditorForm().Show(this);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProjectSettingsForm().Show(this);
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void storyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StoryOrderForm().Show(this);
        }
    }
}
