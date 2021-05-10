
namespace StoryDev.Components
{
    partial class JournalUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlRequirements = new System.Windows.Forms.Panel();
            this.cmbChapters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStoryProgress = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chbAccessedViaScript = new System.Windows.Forms.CheckBox();
            this.pnlAvailableUntil = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAvailableUntilProgress = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAvailableUntilChapter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeletePage = new System.Windows.Forms.Button();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.tcJournalPages = new System.Windows.Forms.TabControl();
            this.chbMainStory = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRefreshChapterLists = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoryProgress)).BeginInit();
            this.pnlAvailableUntil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableUntilProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1040, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.pnlRequirements);
            this.pnlContent.Controls.Add(this.chbAccessedViaScript);
            this.pnlContent.Controls.Add(this.pnlAvailableUntil);
            this.pnlContent.Controls.Add(this.btnDeletePage);
            this.pnlContent.Controls.Add(this.btnAddPage);
            this.pnlContent.Controls.Add(this.tcJournalPages);
            this.pnlContent.Controls.Add(this.chbMainStory);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Enabled = false;
            this.pnlContent.Location = new System.Drawing.Point(294, 55);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(859, 704);
            this.pnlContent.TabIndex = 13;
            // 
            // pnlRequirements
            // 
            this.pnlRequirements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRequirements.Controls.Add(this.cmbChapters);
            this.pnlRequirements.Controls.Add(this.label2);
            this.pnlRequirements.Controls.Add(this.nudStoryProgress);
            this.pnlRequirements.Controls.Add(this.label3);
            this.pnlRequirements.Location = new System.Drawing.Point(93, 111);
            this.pnlRequirements.Name = "pnlRequirements";
            this.pnlRequirements.Size = new System.Drawing.Size(660, 35);
            this.pnlRequirements.TabIndex = 13;
            // 
            // cmbChapters
            // 
            this.cmbChapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChapters.FormattingEnabled = true;
            this.cmbChapters.Location = new System.Drawing.Point(113, 4);
            this.cmbChapters.Name = "cmbChapters";
            this.cmbChapters.Size = new System.Drawing.Size(196, 28);
            this.cmbChapters.TabIndex = 9;
            this.cmbChapters.SelectedIndexChanged += new System.EventHandler(this.cmbChapters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chapter:";
            // 
            // nudStoryProgress
            // 
            this.nudStoryProgress.Location = new System.Drawing.Point(397, 5);
            this.nudStoryProgress.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudStoryProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStoryProgress.Name = "nudStoryProgress";
            this.nudStoryProgress.Size = new System.Drawing.Size(180, 26);
            this.nudStoryProgress.TabIndex = 11;
            this.nudStoryProgress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStoryProgress.ValueChanged += new System.EventHandler(this.nudStoryProgress_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Progress:";
            // 
            // chbAccessedViaScript
            // 
            this.chbAccessedViaScript.AutoSize = true;
            this.chbAccessedViaScript.Enabled = false;
            this.chbAccessedViaScript.Location = new System.Drawing.Point(444, 85);
            this.chbAccessedViaScript.Name = "chbAccessedViaScript";
            this.chbAccessedViaScript.Size = new System.Drawing.Size(173, 24);
            this.chbAccessedViaScript.TabIndex = 12;
            this.chbAccessedViaScript.Text = "Accessed via Script";
            this.chbAccessedViaScript.UseVisualStyleBackColor = true;
            this.chbAccessedViaScript.CheckedChanged += new System.EventHandler(this.chbAccessedViaScript_CheckedChanged);
            // 
            // pnlAvailableUntil
            // 
            this.pnlAvailableUntil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAvailableUntil.Controls.Add(this.label6);
            this.pnlAvailableUntil.Controls.Add(this.nudAvailableUntilProgress);
            this.pnlAvailableUntil.Controls.Add(this.label4);
            this.pnlAvailableUntil.Controls.Add(this.cmbAvailableUntilChapter);
            this.pnlAvailableUntil.Controls.Add(this.label5);
            this.pnlAvailableUntil.Location = new System.Drawing.Point(93, 152);
            this.pnlAvailableUntil.Name = "pnlAvailableUntil";
            this.pnlAvailableUntil.Size = new System.Drawing.Size(660, 63);
            this.pnlAvailableUntil.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Available Until";
            // 
            // nudAvailableUntilProgress
            // 
            this.nudAvailableUntilProgress.Location = new System.Drawing.Point(397, 33);
            this.nudAvailableUntilProgress.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudAvailableUntilProgress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAvailableUntilProgress.Name = "nudAvailableUntilProgress";
            this.nudAvailableUntilProgress.Size = new System.Drawing.Size(180, 26);
            this.nudAvailableUntilProgress.TabIndex = 3;
            this.nudAvailableUntilProgress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAvailableUntilProgress.ValueChanged += new System.EventHandler(this.nudAvailableUntilProgress_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Progress:";
            // 
            // cmbAvailableUntilChapter
            // 
            this.cmbAvailableUntilChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailableUntilChapter.FormattingEnabled = true;
            this.cmbAvailableUntilChapter.Location = new System.Drawing.Point(113, 32);
            this.cmbAvailableUntilChapter.Name = "cmbAvailableUntilChapter";
            this.cmbAvailableUntilChapter.Size = new System.Drawing.Size(196, 28);
            this.cmbAvailableUntilChapter.TabIndex = 1;
            this.cmbAvailableUntilChapter.SelectedIndexChanged += new System.EventHandler(this.cmbAvailableUntilChapter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chapter:";
            // 
            // btnDeletePage
            // 
            this.btnDeletePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletePage.Enabled = false;
            this.btnDeletePage.Location = new System.Drawing.Point(206, 221);
            this.btnDeletePage.Name = "btnDeletePage";
            this.btnDeletePage.Size = new System.Drawing.Size(113, 33);
            this.btnDeletePage.TabIndex = 6;
            this.btnDeletePage.Text = "Delete Page";
            this.btnDeletePage.UseVisualStyleBackColor = true;
            this.btnDeletePage.Click += new System.EventHandler(this.btnDeletePage_Click);
            // 
            // btnAddPage
            // 
            this.btnAddPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddPage.Location = new System.Drawing.Point(93, 221);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(107, 33);
            this.btnAddPage.TabIndex = 5;
            this.btnAddPage.Text = "Add Page";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // tcJournalPages
            // 
            this.tcJournalPages.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tcJournalPages.Location = new System.Drawing.Point(93, 260);
            this.tcJournalPages.Name = "tcJournalPages";
            this.tcJournalPages.SelectedIndex = 0;
            this.tcJournalPages.Size = new System.Drawing.Size(660, 418);
            this.tcJournalPages.TabIndex = 4;
            // 
            // chbMainStory
            // 
            this.chbMainStory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbMainStory.AutoSize = true;
            this.chbMainStory.Location = new System.Drawing.Point(250, 85);
            this.chbMainStory.Name = "chbMainStory";
            this.chbMainStory.Size = new System.Drawing.Size(188, 24);
            this.chbMainStory.TabIndex = 2;
            this.chbMainStory.Text = "Part of the Main Story";
            this.chbMainStory.UseVisualStyleBackColor = true;
            this.chbMainStory.CheckedChanged += new System.EventHandler(this.chbMainStory_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(250, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(420, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 20;
            this.lbResults.Location = new System.Drawing.Point(16, 55);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(272, 664);
            this.lbResults.TabIndex = 11;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(16, 16);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 33);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefreshChapterLists
            // 
            this.btnRefreshChapterLists.Location = new System.Drawing.Point(294, 16);
            this.btnRefreshChapterLists.Name = "btnRefreshChapterLists";
            this.btnRefreshChapterLists.Size = new System.Drawing.Size(200, 33);
            this.btnRefreshChapterLists.TabIndex = 15;
            this.btnRefreshChapterLists.Text = "Refresh Chapter Lists";
            this.btnRefreshChapterLists.UseVisualStyleBackColor = true;
            this.btnRefreshChapterLists.Click += new System.EventHandler(this.btnRefreshChapterLists_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(16, 725);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 34);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // JournalUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefreshChapterLists);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnCreate);
            this.Name = "JournalUI";
            this.Size = new System.Drawing.Size(1171, 786);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlRequirements.ResumeLayout(false);
            this.pnlRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoryProgress)).EndInit();
            this.pnlAvailableUntil.ResumeLayout(false);
            this.pnlAvailableUntil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableUntilProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbMainStory;
        private System.Windows.Forms.Button btnDeletePage;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.TabControl tcJournalPages;
        private System.Windows.Forms.NumericUpDown nudStoryProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChapters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAvailableUntil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAvailableUntilProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAvailableUntilChapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbAccessedViaScript;
        private System.Windows.Forms.Panel pnlRequirements;
        private System.Windows.Forms.Button btnRefreshChapterLists;
        private System.Windows.Forms.Button btnSearch;
    }
}
