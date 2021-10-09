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

namespace StoryDev.Forms.Project
{
    partial class ProjectSettingsForm : Form
    {
        public ProjectSettingsForm()
        {
            InitializeComponent();

            PopulateFields();
        }

        private void PopulateFields()
        {
            txtSourcePath.Text = Globals.Settings.SourcePath;
            txtSubFolder.Text = Globals.Settings.SubFolder;

            chbAchievements.Checked = Globals.Settings.AchievementsModule;
            chbActivities.Checked = Globals.Settings.ActivitiesModule;
            chbArtefacts.Checked = Globals.Settings.ArtefactsModule;
            chbCharactersModule.Checked = Globals.Settings.CharactersModule;
            chbGossips.Checked = Globals.Settings.GossipsSystem;
            chbItems.Checked = Globals.Settings.ItemsModule;
            chbPlaces.Checked = Globals.Settings.PlacesModule;
            chbSpecialFeature.Checked = Globals.Settings.SpecialFeature;
            chbVendors.Checked = Globals.Settings.VendorsModule;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var browseFolder = new VistaFolderBrowserDialog();
            browseFolder.Description = "Find Source Path";
            browseFolder.UseDescriptionForTitle = true;
            if (browseFolder.ShowDialog() == DialogResult.OK)
            {
                txtSourcePath.Text = browseFolder.SelectedPath;
                Globals.Settings.SourcePath = browseFolder.SelectedPath;
            }
        }

        private void txtSourcePath_TextChanged(object sender, EventArgs e)
        {
            Globals.Settings.SourcePath = txtSourcePath.Text;
        }

        private void txtSubFolder_TextChanged(object sender, EventArgs e)
        {
            Globals.Settings.SubFolder = txtSubFolder.Text;
        }

        private void chbCharactersModule_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Settings.CharactersModule = chbCharactersModule.Checked;
        }

        private void chbPlaces_CheckedChanged(object sender, EventArgs e)
        {
            chbActivities.Enabled = chbPlaces.Checked;
            Globals.Settings.PlacesModule = chbPlaces.Checked;
            if (!chbPlaces.Checked)
                Globals.Settings.ActivitiesModule = false;
            else
                Globals.Settings.ActivitiesModule = chbActivities.Checked;
        }

        private void chbActivities_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Settings.ActivitiesModule = chbActivities.Checked;
        }

        private void chbArtefacts_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Settings.ArtefactsModule = chbArtefacts.Checked;
        }

        private void chbAchievements_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Settings.AchievementsModule = chbAchievements.Checked;
        }

        private void chbItems_CheckedChanged(object sender, EventArgs e)
        {
            chbVendors.Enabled = chbItems.Checked;
            Globals.Settings.ItemsModule = chbItems.Checked;
            if (!chbItems.Checked)
                Globals.Settings.VendorsModule = false;
            else
                Globals.Settings.VendorsModule = chbVendors.Checked;
        }

        private void chbVendors_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Settings.VendorsModule = chbVendors.Checked;
        }

        private void chbSpecialFeature_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Settings.SpecialFeature = chbSpecialFeature.Checked;
        }

        private void chbGossips_CheckedChanged(object sender, EventArgs e)
        {
            Globals.Settings.GossipsSystem = chbGossips.Checked;
        }

        private void ProjectSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.SaveSettings();
        }
    }
}
