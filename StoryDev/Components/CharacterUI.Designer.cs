
namespace StoryDev.Components
{
    partial class CharacterUI
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
            this.components = new System.ComponentModel.Container();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNPCInfo = new System.Windows.Forms.Panel();
            this.btnRefreshGroups = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.chbIsVendor = new System.Windows.Forms.CheckBox();
            this.cmbCharacterGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPlayerData = new System.Windows.Forms.Panel();
            this.lvTraits = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lvAttitudes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.cmbInitialAttitude = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbIsPlayerCharacter = new System.Windows.Forms.CheckBox();
            this.txtAppearance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDialogueColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlNPCInfo.SuspendLayout();
            this.cmsListOptions.SuspendLayout();
            this.pnlPlayerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 15);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 33);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 20;
            this.lbResults.Location = new System.Drawing.Point(17, 54);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(272, 664);
            this.lbResults.TabIndex = 1;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.pnlNPCInfo);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.pnlPlayerData);
            this.pnlContent.Controls.Add(this.chbIsPlayerCharacter);
            this.pnlContent.Controls.Add(this.txtAppearance);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.btnDialogueColor);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.txtLastName);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtFirstName);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Enabled = false;
            this.pnlContent.Location = new System.Drawing.Point(295, 54);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(859, 704);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlNPCInfo
            // 
            this.pnlNPCInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNPCInfo.Controls.Add(this.btnRefreshGroups);
            this.pnlNPCInfo.Controls.Add(this.lvItems);
            this.pnlNPCInfo.Controls.Add(this.label10);
            this.pnlNPCInfo.Controls.Add(this.chbIsVendor);
            this.pnlNPCInfo.Controls.Add(this.cmbCharacterGroup);
            this.pnlNPCInfo.Controls.Add(this.label9);
            this.pnlNPCInfo.Location = new System.Drawing.Point(24, 681);
            this.pnlNPCInfo.Name = "pnlNPCInfo";
            this.pnlNPCInfo.Size = new System.Drawing.Size(784, 251);
            this.pnlNPCInfo.TabIndex = 13;
            // 
            // btnRefreshGroups
            // 
            this.btnRefreshGroups.Location = new System.Drawing.Point(405, 0);
            this.btnRefreshGroups.Name = "btnRefreshGroups";
            this.btnRefreshGroups.Size = new System.Drawing.Size(77, 28);
            this.btnRefreshGroups.TabIndex = 6;
            this.btnRefreshGroups.Text = "Refresh";
            this.btnRefreshGroups.UseVisualStyleBackColor = true;
            this.btnRefreshGroups.Click += new System.EventHandler(this.btnRefreshGroups_Click);
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvItems.ContextMenuStrip = this.cmsListOptions;
            this.lvItems.FullRowSelect = true;
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(162, 84);
            this.lvItems.MultiSelect = false;
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(439, 153);
            this.lvItems.TabIndex = 5;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 110;
            // 
            // cmsListOptions
            // 
            this.cmsListOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsListOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cmsListOptions.Name = "cmsListOptions";
            this.cmsListOptions.Size = new System.Drawing.Size(149, 100);
            this.cmsListOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListOptions_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Vendor Items";
            // 
            // chbIsVendor
            // 
            this.chbIsVendor.AutoSize = true;
            this.chbIsVendor.Location = new System.Drawing.Point(162, 34);
            this.chbIsVendor.Name = "chbIsVendor";
            this.chbIsVendor.Size = new System.Drawing.Size(104, 24);
            this.chbIsVendor.TabIndex = 2;
            this.chbIsVendor.Text = "Is Vendor";
            this.chbIsVendor.UseVisualStyleBackColor = true;
            this.chbIsVendor.CheckedChanged += new System.EventHandler(this.chbIsVendor_CheckedChanged);
            // 
            // cmbCharacterGroup
            // 
            this.cmbCharacterGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterGroup.FormattingEnabled = true;
            this.cmbCharacterGroup.Location = new System.Drawing.Point(162, 0);
            this.cmbCharacterGroup.Name = "cmbCharacterGroup";
            this.cmbCharacterGroup.Size = new System.Drawing.Size(237, 28);
            this.cmbCharacterGroup.TabIndex = 1;
            this.cmbCharacterGroup.SelectedIndexChanged += new System.EventHandler(this.cmbCharacterGroup_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Group:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 938);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 12;
            // 
            // pnlPlayerData
            // 
            this.pnlPlayerData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPlayerData.Controls.Add(this.lvTraits);
            this.pnlPlayerData.Controls.Add(this.label8);
            this.pnlPlayerData.Controls.Add(this.lvAttitudes);
            this.pnlPlayerData.Controls.Add(this.label7);
            this.pnlPlayerData.Controls.Add(this.cmbInitialAttitude);
            this.pnlPlayerData.Controls.Add(this.label6);
            this.pnlPlayerData.Location = new System.Drawing.Point(24, 440);
            this.pnlPlayerData.Name = "pnlPlayerData";
            this.pnlPlayerData.Size = new System.Drawing.Size(784, 235);
            this.pnlPlayerData.TabIndex = 11;
            this.pnlPlayerData.Visible = false;
            // 
            // lvTraits
            // 
            this.lvTraits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvTraits.ContextMenuStrip = this.cmsListOptions;
            this.lvTraits.FullRowSelect = true;
            this.lvTraits.HideSelection = false;
            this.lvTraits.Location = new System.Drawing.Point(399, 66);
            this.lvTraits.MultiSelect = false;
            this.lvTraits.Name = "lvTraits";
            this.lvTraits.Size = new System.Drawing.Size(370, 153);
            this.lvTraits.TabIndex = 5;
            this.lvTraits.UseCompatibleStateImageBehavior = false;
            this.lvTraits.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Start Value";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Max";
            this.columnHeader6.Width = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Traits";
            // 
            // lvAttitudes
            // 
            this.lvAttitudes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAttitudes.ContextMenuStrip = this.cmsListOptions;
            this.lvAttitudes.FullRowSelect = true;
            this.lvAttitudes.HideSelection = false;
            this.lvAttitudes.Location = new System.Drawing.Point(14, 66);
            this.lvAttitudes.MultiSelect = false;
            this.lvAttitudes.Name = "lvAttitudes";
            this.lvAttitudes.Size = new System.Drawing.Size(370, 153);
            this.lvAttitudes.TabIndex = 3;
            this.lvAttitudes.UseCompatibleStateImageBehavior = false;
            this.lvAttitudes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Character";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Initial Attitude";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Real Attitude";
            this.columnHeader3.Width = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Attitudes";
            // 
            // cmbInitialAttitude
            // 
            this.cmbInitialAttitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInitialAttitude.FormattingEnabled = true;
            this.cmbInitialAttitude.Items.AddRange(new object[] {
            "Hate (-50)",
            "Angry (-30)",
            "Upset (-10)",
            "Content (0)",
            "Happy (+10)",
            "Joyous (+30)",
            "Love (+50)"});
            this.cmbInitialAttitude.Location = new System.Drawing.Point(162, 0);
            this.cmbInitialAttitude.Name = "cmbInitialAttitude";
            this.cmbInitialAttitude.Size = new System.Drawing.Size(237, 28);
            this.cmbInitialAttitude.TabIndex = 1;
            this.cmbInitialAttitude.SelectedIndexChanged += new System.EventHandler(this.cmbInitialAttitude_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Initial Attitude:";
            // 
            // chbIsPlayerCharacter
            // 
            this.chbIsPlayerCharacter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbIsPlayerCharacter.AutoSize = true;
            this.chbIsPlayerCharacter.Location = new System.Drawing.Point(346, 63);
            this.chbIsPlayerCharacter.Name = "chbIsPlayerCharacter";
            this.chbIsPlayerCharacter.Size = new System.Drawing.Size(169, 24);
            this.chbIsPlayerCharacter.TabIndex = 10;
            this.chbIsPlayerCharacter.Text = "Is Player Character";
            this.chbIsPlayerCharacter.UseVisualStyleBackColor = true;
            this.chbIsPlayerCharacter.CheckedChanged += new System.EventHandler(this.chbIsPlayerCharacter_CheckedChanged);
            // 
            // txtAppearance
            // 
            this.txtAppearance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAppearance.Location = new System.Drawing.Point(186, 268);
            this.txtAppearance.Multiline = true;
            this.txtAppearance.Name = "txtAppearance";
            this.txtAppearance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppearance.Size = new System.Drawing.Size(564, 166);
            this.txtAppearance.TabIndex = 9;
            this.txtAppearance.TextChanged += new System.EventHandler(this.txtAppearance_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Appearance:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(186, 96);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(564, 166);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // btnDialogueColor
            // 
            this.btnDialogueColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDialogueColor.BackColor = System.Drawing.Color.White;
            this.btnDialogueColor.Location = new System.Drawing.Point(222, 58);
            this.btnDialogueColor.Name = "btnDialogueColor";
            this.btnDialogueColor.Size = new System.Drawing.Size(118, 32);
            this.btnDialogueColor.TabIndex = 5;
            this.btnDialogueColor.UseVisualStyleBackColor = false;
            this.btnDialogueColor.Click += new System.EventHandler(this.btnDialogueColor_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dialogue Colour:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLastName.Location = new System.Drawing.Point(519, 26);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(231, 26);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFirstName.Location = new System.Drawing.Point(186, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(231, 26);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1041, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(17, 724);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 33);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CharacterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnCreate);
            this.Name = "CharacterUI";
            this.Size = new System.Drawing.Size(1171, 786);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlNPCInfo.ResumeLayout(false);
            this.pnlNPCInfo.PerformLayout();
            this.cmsListOptions.ResumeLayout(false);
            this.pnlPlayerData.ResumeLayout(false);
            this.pnlPlayerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDialogueColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbIsPlayerCharacter;
        private System.Windows.Forms.TextBox txtAppearance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPlayerData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInitialAttitude;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvAttitudes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvTraits;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip cmsListOptions;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlNPCInfo;
        private System.Windows.Forms.ComboBox cmbCharacterGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbIsVendor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefreshGroups;
        private System.Windows.Forms.Button btnSearch;
    }
}
