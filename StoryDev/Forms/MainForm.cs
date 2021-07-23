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
using StoryDev.Scripting;

namespace StoryDev.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Globals.GlobalInit();
        }

        public void SelectJournal(int index)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Journals")
                {
                    var ui = (JournalUI)tp.Controls[0];
                    ui.SelectJournalIndex(index);
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Journals";
            var journalUI = new JournalUI() { Dock = DockStyle.Fill };
            journalUI.SelectJournalIndex(index);
            tab.Controls.Add(journalUI);

            tcMain.TabPages.Add(tab);
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
                resourcesToolStripMenuItem.Enabled = true;
                saveAllToolStripMenuItem.Enabled = true;
                scriptsToolStripMenuItem.Enabled = true;

                var moduleCount = ScriptEngine.Instance.DataModules.Count;
                modulesToolStripMenuItem.Visible = moduleCount > 0;
                foreach (var module in ScriptEngine.Instance.DataModules)
                {
                    var menuItem = new ToolStripMenuItem();
                    menuItem.Text = module.Name + "...";
                    modulesToolStripMenuItem.DropDownItems.Add(menuItem);
                }
            }
        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Characters")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Characters";
            tab.Controls.Add(new CharacterUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
        }

        private void characterGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Character Groups")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Character Groups";
            tab.Controls.Add(new CharacterGroupUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inlineEditor = new AddJournalInlineCodeForm();
            inlineEditor.ShowDialog();
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Journals")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Journals";
            tab.Controls.Add(new JournalUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
        }

        private void chaptersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChapterBrowserForm().ShowDialog();
        }

        private void placesOfInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Places of Interest")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Places of Interest";
            tab.Controls.Add(new PlaceUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
        }

        private void iconSetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IconSetsForm().ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Items")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Items";
            tab.Controls.Add(new ItemUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
        }

        private void artefactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Artefacts")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Artefacts";
            tab.Controls.Add(new ArtefactsUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
        }

        private void specialFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Special Feature")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Special Feature";
            tab.Controls.Add(new SpecialFeatureUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
        }

        private void achievementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Achievements")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Achievements";
            tab.Controls.Add(new AchievementsUI() { Dock = DockStyle.Fill });

            tcMain.TabPages.Add(tab);
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

        private void mapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MapsForm().Show();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tcMain.TabPages)
            {
                if (tp.Text == "Script Manager")
                {
                    tcMain.SelectedTab = tp;
                    return;
                }
            }

            var tab = new TabPage();
            tab.Text = "Script Manager";
            var ui = new ScriptManager() { Dock = DockStyle.Fill };
            ui.TabNameChanged += (string text) =>
            {
                tab.Text = "Script Manager - " + text;
            };
            ui.SaveStateChanged += (bool value) =>
            {
                if (value)
                {
                    if (!tab.Text.StartsWith("*"))
                        tab.Text = "*" + tab.Text;
                }
                else
                {
                    if (tab.Text.StartsWith("*"))
                        tab.Text = tab.Text.Substring(1);
                }
            };

            tab.Controls.Add(ui);

            tcMain.TabPages.Add(tab);
            tcMain.SelectedTab = tab;
        }
    }
}
