
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
            this.convoFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meditationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconSetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.resourcesToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 33);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
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
            this.convoFinderToolStripMenuItem,
            this.scriptEditorToolStripMenuItem,
            this.storyOrderToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chaptersToolStripMenuItem.Text = "Chapters...";
            // 
            // conversationsToolStripMenuItem
            // 
            this.conversationsToolStripMenuItem.Name = "conversationsToolStripMenuItem";
            this.conversationsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.conversationsToolStripMenuItem.Text = "Conversations...";
            this.conversationsToolStripMenuItem.Click += new System.EventHandler(this.conversationsToolStripMenuItem_Click);
            // 
            // convoFinderToolStripMenuItem
            // 
            this.convoFinderToolStripMenuItem.Name = "convoFinderToolStripMenuItem";
            this.convoFinderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.convoFinderToolStripMenuItem.Text = "Convo Finder...";
            this.convoFinderToolStripMenuItem.Click += new System.EventHandler(this.convoFinderToolStripMenuItem_Click);
            // 
            // scriptEditorToolStripMenuItem
            // 
            this.scriptEditorToolStripMenuItem.Name = "scriptEditorToolStripMenuItem";
            this.scriptEditorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.scriptEditorToolStripMenuItem.Text = "Script Editor...";
            this.scriptEditorToolStripMenuItem.Click += new System.EventHandler(this.scriptEditorToolStripMenuItem_Click);
            // 
            // storyOrderToolStripMenuItem
            // 
            this.storyOrderToolStripMenuItem.Name = "storyOrderToolStripMenuItem";
            this.storyOrderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.storyOrderToolStripMenuItem.Text = "Story Order...";
            this.storyOrderToolStripMenuItem.Click += new System.EventHandler(this.storyOrderToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.gameObjectsToolStripMenuItem,
            this.meditationsToolStripMenuItem,
            this.toolStripSeparator1,
            this.mapsToolStripMenuItem});
            this.dataToolStripMenuItem.Enabled = false;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.charactersToolStripMenuItem.Text = "Characters...";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.itemsToolStripMenuItem.Text = "Items...";
            // 
            // gameObjectsToolStripMenuItem
            // 
            this.gameObjectsToolStripMenuItem.Name = "gameObjectsToolStripMenuItem";
            this.gameObjectsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gameObjectsToolStripMenuItem.Text = "Game Objects...";
            // 
            // meditationsToolStripMenuItem
            // 
            this.meditationsToolStripMenuItem.Name = "meditationsToolStripMenuItem";
            this.meditationsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.meditationsToolStripMenuItem.Text = "Meditations...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // mapsToolStripMenuItem
            // 
            this.mapsToolStripMenuItem.Name = "mapsToolStripMenuItem";
            this.mapsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mapsToolStripMenuItem.Text = "Maps...";
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconSetsToolStripMenuItem});
            this.resourcesToolStripMenuItem.Enabled = false;
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.resourcesToolStripMenuItem.Text = "Resources";
            // 
            // iconSetsToolStripMenuItem
            // 
            this.iconSetsToolStripMenuItem.Name = "iconSetsToolStripMenuItem";
            this.iconSetsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.iconSetsToolStripMenuItem.Text = "Icon Sets...";
            this.iconSetsToolStripMenuItem.Click += new System.EventHandler(this.iconSetsToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.projectToolStripMenuItem.Enabled = false;
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.outputToolStripMenuItem.Text = "Output...";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.outputToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 749);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "StoryDev Story Creator";
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
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconSetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convoFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meditationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storyOrderToolStripMenuItem;
    }
}

