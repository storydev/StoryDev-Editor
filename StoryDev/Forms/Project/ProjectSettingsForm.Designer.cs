
namespace StoryDev.Forms.Project
{
    partial class ProjectSettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbCharactersModule = new System.Windows.Forms.CheckBox();
            this.chbPlaces = new System.Windows.Forms.CheckBox();
            this.chbActivities = new System.Windows.Forms.CheckBox();
            this.chbArtefacts = new System.Windows.Forms.CheckBox();
            this.chbAchievements = new System.Windows.Forms.CheckBox();
            this.chbItems = new System.Windows.Forms.CheckBox();
            this.chbVendors = new System.Windows.Forms.CheckBox();
            this.chbSpecialFeature = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chbGossips = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(861, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.txtSubFolder);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtSourcePath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(853, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Path:";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(139, 28);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(325, 26);
            this.txtSourcePath.TabIndex = 1;
            this.txtSourcePath.TextChanged += new System.EventHandler(this.txtSourcePath_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbGossips);
            this.groupBox1.Controls.Add(this.chbSpecialFeature);
            this.groupBox1.Controls.Add(this.chbVendors);
            this.groupBox1.Controls.Add(this.chbItems);
            this.groupBox1.Controls.Add(this.chbAchievements);
            this.groupBox1.Controls.Add(this.chbArtefacts);
            this.groupBox1.Controls.Add(this.chbActivities);
            this.groupBox1.Controls.Add(this.chbPlaces);
            this.groupBox1.Controls.Add(this.chbCharactersModule);
            this.groupBox1.Location = new System.Drawing.Point(36, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 335);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modules";
            // 
            // chbCharactersModule
            // 
            this.chbCharactersModule.AutoSize = true;
            this.chbCharactersModule.Checked = true;
            this.chbCharactersModule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCharactersModule.Enabled = false;
            this.chbCharactersModule.Location = new System.Drawing.Point(25, 40);
            this.chbCharactersModule.Name = "chbCharactersModule";
            this.chbCharactersModule.Size = new System.Drawing.Size(113, 24);
            this.chbCharactersModule.TabIndex = 3;
            this.chbCharactersModule.Text = "Characters";
            this.chbCharactersModule.UseVisualStyleBackColor = true;
            this.chbCharactersModule.CheckedChanged += new System.EventHandler(this.chbCharactersModule_CheckedChanged);
            // 
            // chbPlaces
            // 
            this.chbPlaces.AutoSize = true;
            this.chbPlaces.Checked = true;
            this.chbPlaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPlaces.Location = new System.Drawing.Point(25, 81);
            this.chbPlaces.Name = "chbPlaces";
            this.chbPlaces.Size = new System.Drawing.Size(159, 24);
            this.chbPlaces.TabIndex = 3;
            this.chbPlaces.Text = "Places of Interest";
            this.chbPlaces.UseVisualStyleBackColor = true;
            this.chbPlaces.CheckedChanged += new System.EventHandler(this.chbPlaces_CheckedChanged);
            // 
            // chbActivities
            // 
            this.chbActivities.AutoSize = true;
            this.chbActivities.Checked = true;
            this.chbActivities.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActivities.Location = new System.Drawing.Point(57, 120);
            this.chbActivities.Name = "chbActivities";
            this.chbActivities.Size = new System.Drawing.Size(97, 24);
            this.chbActivities.TabIndex = 4;
            this.chbActivities.Text = "Activities";
            this.chbActivities.UseVisualStyleBackColor = true;
            this.chbActivities.CheckedChanged += new System.EventHandler(this.chbActivities_CheckedChanged);
            // 
            // chbArtefacts
            // 
            this.chbArtefacts.AutoSize = true;
            this.chbArtefacts.Checked = true;
            this.chbArtefacts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbArtefacts.Location = new System.Drawing.Point(25, 159);
            this.chbArtefacts.Name = "chbArtefacts";
            this.chbArtefacts.Size = new System.Drawing.Size(100, 24);
            this.chbArtefacts.TabIndex = 5;
            this.chbArtefacts.Text = "Artefacts";
            this.chbArtefacts.UseVisualStyleBackColor = true;
            this.chbArtefacts.CheckedChanged += new System.EventHandler(this.chbArtefacts_CheckedChanged);
            // 
            // chbAchievements
            // 
            this.chbAchievements.AutoSize = true;
            this.chbAchievements.Checked = true;
            this.chbAchievements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAchievements.Location = new System.Drawing.Point(25, 198);
            this.chbAchievements.Name = "chbAchievements";
            this.chbAchievements.Size = new System.Drawing.Size(135, 24);
            this.chbAchievements.TabIndex = 6;
            this.chbAchievements.Text = "Achievements";
            this.chbAchievements.UseVisualStyleBackColor = true;
            this.chbAchievements.CheckedChanged += new System.EventHandler(this.chbAchievements_CheckedChanged);
            // 
            // chbItems
            // 
            this.chbItems.AutoSize = true;
            this.chbItems.Checked = true;
            this.chbItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbItems.Location = new System.Drawing.Point(25, 237);
            this.chbItems.Name = "chbItems";
            this.chbItems.Size = new System.Drawing.Size(75, 24);
            this.chbItems.TabIndex = 7;
            this.chbItems.Text = "Items";
            this.chbItems.UseVisualStyleBackColor = true;
            this.chbItems.CheckedChanged += new System.EventHandler(this.chbItems_CheckedChanged);
            // 
            // chbVendors
            // 
            this.chbVendors.AutoSize = true;
            this.chbVendors.Checked = true;
            this.chbVendors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVendors.Location = new System.Drawing.Point(57, 277);
            this.chbVendors.Name = "chbVendors";
            this.chbVendors.Size = new System.Drawing.Size(95, 24);
            this.chbVendors.TabIndex = 8;
            this.chbVendors.Text = "Vendors";
            this.chbVendors.UseVisualStyleBackColor = true;
            this.chbVendors.CheckedChanged += new System.EventHandler(this.chbVendors_CheckedChanged);
            // 
            // chbSpecialFeature
            // 
            this.chbSpecialFeature.AutoSize = true;
            this.chbSpecialFeature.Checked = true;
            this.chbSpecialFeature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSpecialFeature.Location = new System.Drawing.Point(254, 40);
            this.chbSpecialFeature.Name = "chbSpecialFeature";
            this.chbSpecialFeature.Size = new System.Drawing.Size(147, 24);
            this.chbSpecialFeature.TabIndex = 3;
            this.chbSpecialFeature.Text = "Special Feature";
            this.chbSpecialFeature.UseVisualStyleBackColor = true;
            this.chbSpecialFeature.CheckedChanged += new System.EventHandler(this.chbSpecialFeature_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sub Folder:";
            // 
            // txtSubFolder
            // 
            this.txtSubFolder.Location = new System.Drawing.Point(139, 60);
            this.txtSubFolder.Name = "txtSubFolder";
            this.txtSubFolder.Size = new System.Drawing.Size(325, 26);
            this.txtSubFolder.TabIndex = 4;
            this.txtSubFolder.TextChanged += new System.EventHandler(this.txtSubFolder_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(470, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 32);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chbGossips
            // 
            this.chbGossips.AutoSize = true;
            this.chbGossips.Checked = true;
            this.chbGossips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGossips.Location = new System.Drawing.Point(254, 81);
            this.chbGossips.Name = "chbGossips";
            this.chbGossips.Size = new System.Drawing.Size(93, 24);
            this.chbGossips.TabIndex = 6;
            this.chbGossips.Text = "Gossips";
            this.chbGossips.UseVisualStyleBackColor = true;
            this.chbGossips.CheckedChanged += new System.EventHandler(this.chbGossips_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(853, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Behaviours";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(853, 547);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Interface";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ProjectSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 580);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectSettingsForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbCharactersModule;
        private System.Windows.Forms.CheckBox chbSpecialFeature;
        private System.Windows.Forms.CheckBox chbVendors;
        private System.Windows.Forms.CheckBox chbItems;
        private System.Windows.Forms.CheckBox chbAchievements;
        private System.Windows.Forms.CheckBox chbArtefacts;
        private System.Windows.Forms.CheckBox chbActivities;
        private System.Windows.Forms.CheckBox chbPlaces;
        private System.Windows.Forms.TextBox txtSubFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chbGossips;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}