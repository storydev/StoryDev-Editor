
namespace StoryDev.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placesOfInterestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artefactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.achievementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconSetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator4,
            this.preferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.openProjectToolStripMenuItem.Text = "Open Project...";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Enabled = false;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.saveAllToolStripMenuItem.Text = "Save all...";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(226, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaptersToolStripMenuItem,
            this.conversationsToolStripMenuItem,
            this.toolStripSeparator1,
            this.charactersToolStripMenuItem,
            this.characterGroupsToolStripMenuItem,
            this.placesOfInterestToolStripMenuItem,
            this.journalToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.artefactsToolStripMenuItem,
            this.specialFeatureToolStripMenuItem,
            this.toolStripSeparator2,
            this.achievementsToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 30);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.chaptersToolStripMenuItem.Text = "Chapters...";
            this.chaptersToolStripMenuItem.Click += new System.EventHandler(this.chaptersToolStripMenuItem_Click);
            // 
            // conversationsToolStripMenuItem
            // 
            this.conversationsToolStripMenuItem.Name = "conversationsToolStripMenuItem";
            this.conversationsToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.conversationsToolStripMenuItem.Text = "Conversations...";
            this.conversationsToolStripMenuItem.Click += new System.EventHandler(this.conversationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(248, 6);
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.charactersToolStripMenuItem.Text = "Characters";
            this.charactersToolStripMenuItem.Click += new System.EventHandler(this.charactersToolStripMenuItem_Click);
            // 
            // characterGroupsToolStripMenuItem
            // 
            this.characterGroupsToolStripMenuItem.Name = "characterGroupsToolStripMenuItem";
            this.characterGroupsToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.characterGroupsToolStripMenuItem.Text = "Character Groups";
            this.characterGroupsToolStripMenuItem.Click += new System.EventHandler(this.characterGroupsToolStripMenuItem_Click);
            // 
            // placesOfInterestToolStripMenuItem
            // 
            this.placesOfInterestToolStripMenuItem.Name = "placesOfInterestToolStripMenuItem";
            this.placesOfInterestToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.placesOfInterestToolStripMenuItem.Text = "Places of Interest";
            this.placesOfInterestToolStripMenuItem.Click += new System.EventHandler(this.placesOfInterestToolStripMenuItem_Click);
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.journalToolStripMenuItem.Text = "Journal";
            this.journalToolStripMenuItem.Click += new System.EventHandler(this.journalToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // artefactsToolStripMenuItem
            // 
            this.artefactsToolStripMenuItem.Name = "artefactsToolStripMenuItem";
            this.artefactsToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.artefactsToolStripMenuItem.Text = "Artefacts";
            this.artefactsToolStripMenuItem.Click += new System.EventHandler(this.artefactsToolStripMenuItem_Click);
            // 
            // specialFeatureToolStripMenuItem
            // 
            this.specialFeatureToolStripMenuItem.Name = "specialFeatureToolStripMenuItem";
            this.specialFeatureToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.specialFeatureToolStripMenuItem.Text = "Special Feature";
            this.specialFeatureToolStripMenuItem.Click += new System.EventHandler(this.specialFeatureToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(248, 6);
            // 
            // achievementsToolStripMenuItem
            // 
            this.achievementsToolStripMenuItem.Name = "achievementsToolStripMenuItem";
            this.achievementsToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.achievementsToolStripMenuItem.Text = "Achievements";
            this.achievementsToolStripMenuItem.Click += new System.EventHandler(this.achievementsToolStripMenuItem_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconSetsToolStripMenuItem});
            this.resourcesToolStripMenuItem.Enabled = false;
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(107, 30);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // iconSetsToolStripMenuItem
            // 
            this.iconSetsToolStripMenuItem.Name = "iconSetsToolStripMenuItem";
            this.iconSetsToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.iconSetsToolStripMenuItem.Text = "Icon Sets...";
            this.iconSetsToolStripMenuItem.Click += new System.EventHandler(this.iconSetsToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validateToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem});
            this.projectToolStripMenuItem.Enabled = false;
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(82, 30);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.validateToolStripMenuItem.Text = "Validate";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 36);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1179, 713);
            this.tcMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 749);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "StoryDev";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placesOfInterestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artefactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialFeatureToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem achievementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconSetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
    }
}

