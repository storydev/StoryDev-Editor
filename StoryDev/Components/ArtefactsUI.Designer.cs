namespace StoryDev.Components
{
    partial class ArtefactsUI
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.clbOnUseContext = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlFragments = new System.Windows.Forms.Panel();
            this.txtFragmentName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveFragment = new System.Windows.Forms.Button();
            this.btnAddFragment = new System.Windows.Forms.Button();
            this.lbFragments = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAcquireFrequency = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSeeFrequency = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chbUnlockedByDefault = new System.Windows.Forms.CheckBox();
            this.cmbRarity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSetUseContexts = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            this.pnlFragments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcquireFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeeFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(16, 729);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1041, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 32);
            this.btnSave.TabIndex = 28;
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
            this.pnlContent.Controls.Add(this.clbOnUseContext);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Controls.Add(this.pnlFragments);
            this.pnlContent.Controls.Add(this.btnRemoveFragment);
            this.pnlContent.Controls.Add(this.btnAddFragment);
            this.pnlContent.Controls.Add(this.lbFragments);
            this.pnlContent.Controls.Add(this.label8);
            this.pnlContent.Controls.Add(this.label7);
            this.pnlContent.Controls.Add(this.nudAcquireFrequency);
            this.pnlContent.Controls.Add(this.label6);
            this.pnlContent.Controls.Add(this.nudSeeFrequency);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.chbUnlockedByDefault);
            this.pnlContent.Controls.Add(this.cmbRarity);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Enabled = false;
            this.pnlContent.Location = new System.Drawing.Point(296, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(860, 705);
            this.pnlContent.TabIndex = 27;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // clbOnUseContext
            // 
            this.clbOnUseContext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clbOnUseContext.FormattingEnabled = true;
            this.clbOnUseContext.Location = new System.Drawing.Point(273, 334);
            this.clbOnUseContext.Name = "clbOnUseContext";
            this.clbOnUseContext.Size = new System.Drawing.Size(247, 142);
            this.clbOnUseContext.TabIndex = 23;
            this.clbOnUseContext.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbOnUseContext_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 777);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 233);
            this.panel1.TabIndex = 22;
            // 
            // pnlFragments
            // 
            this.pnlFragments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFragments.Controls.Add(this.txtFragmentName);
            this.pnlFragments.Controls.Add(this.label9);
            this.pnlFragments.Controls.Add(this.label3);
            this.pnlFragments.Enabled = false;
            this.pnlFragments.Location = new System.Drawing.Point(335, 565);
            this.pnlFragments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFragments.Name = "pnlFragments";
            this.pnlFragments.Size = new System.Drawing.Size(354, 206);
            this.pnlFragments.TabIndex = 21;
            // 
            // txtFragmentName
            // 
            this.txtFragmentName.Location = new System.Drawing.Point(92, 132);
            this.txtFragmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFragmentName.Name = "txtFragmentName";
            this.txtFragmentName.Size = new System.Drawing.Size(218, 26);
            this.txtFragmentName.TabIndex = 2;
            this.txtFragmentName.TextChanged += new System.EventHandler(this.txtFragmentName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Icon:";
            // 
            // btnRemoveFragment
            // 
            this.btnRemoveFragment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveFragment.Enabled = false;
            this.btnRemoveFragment.Location = new System.Drawing.Point(282, 520);
            this.btnRemoveFragment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveFragment.Name = "btnRemoveFragment";
            this.btnRemoveFragment.Size = new System.Drawing.Size(42, 35);
            this.btnRemoveFragment.TabIndex = 20;
            this.btnRemoveFragment.Text = "-";
            this.btnRemoveFragment.UseVisualStyleBackColor = true;
            this.btnRemoveFragment.Click += new System.EventHandler(this.btnRemoveFragment_Click);
            // 
            // btnAddFragment
            // 
            this.btnAddFragment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddFragment.Location = new System.Drawing.Point(146, 520);
            this.btnAddFragment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFragment.Name = "btnAddFragment";
            this.btnAddFragment.Size = new System.Drawing.Size(42, 35);
            this.btnAddFragment.TabIndex = 19;
            this.btnAddFragment.Text = "+";
            this.btnAddFragment.UseVisualStyleBackColor = true;
            this.btnAddFragment.Click += new System.EventHandler(this.btnAddFragment_Click);
            // 
            // lbFragments
            // 
            this.lbFragments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFragments.FormattingEnabled = true;
            this.lbFragments.ItemHeight = 20;
            this.lbFragments.Location = new System.Drawing.Point(146, 565);
            this.lbFragments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbFragments.Name = "lbFragments";
            this.lbFragments.Size = new System.Drawing.Size(178, 204);
            this.lbFragments.TabIndex = 18;
            this.lbFragments.SelectedIndexChanged += new System.EventHandler(this.lbFragments_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 487);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fragments";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "On Use Context:";
            // 
            // nudAcquireFrequency
            // 
            this.nudAcquireFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudAcquireFrequency.DecimalPlaces = 2;
            this.nudAcquireFrequency.Location = new System.Drawing.Point(565, 285);
            this.nudAcquireFrequency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAcquireFrequency.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAcquireFrequency.Name = "nudAcquireFrequency";
            this.nudAcquireFrequency.Size = new System.Drawing.Size(124, 26);
            this.nudAcquireFrequency.TabIndex = 14;
            this.nudAcquireFrequency.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudAcquireFrequency.ValueChanged += new System.EventHandler(this.nudAcquireFrequency_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Acquire Frequency:";
            // 
            // nudSeeFrequency
            // 
            this.nudSeeFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSeeFrequency.DecimalPlaces = 2;
            this.nudSeeFrequency.Location = new System.Drawing.Point(273, 285);
            this.nudSeeFrequency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSeeFrequency.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSeeFrequency.Name = "nudSeeFrequency";
            this.nudSeeFrequency.Size = new System.Drawing.Size(124, 26);
            this.nudSeeFrequency.TabIndex = 12;
            this.nudSeeFrequency.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSeeFrequency.ValueChanged += new System.EventHandler(this.nudSeeFrequency_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "See Frequency:";
            // 
            // chbUnlockedByDefault
            // 
            this.chbUnlockedByDefault.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbUnlockedByDefault.AutoSize = true;
            this.chbUnlockedByDefault.Location = new System.Drawing.Point(146, 231);
            this.chbUnlockedByDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbUnlockedByDefault.Name = "chbUnlockedByDefault";
            this.chbUnlockedByDefault.Size = new System.Drawing.Size(178, 24);
            this.chbUnlockedByDefault.TabIndex = 10;
            this.chbUnlockedByDefault.Text = "Unlocked by Default";
            this.chbUnlockedByDefault.UseVisualStyleBackColor = true;
            this.chbUnlockedByDefault.CheckedChanged += new System.EventHandler(this.chbUnlockedByDefault_CheckedChanged);
            // 
            // cmbRarity
            // 
            this.cmbRarity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRarity.FormattingEnabled = true;
            this.cmbRarity.Items.AddRange(new object[] {
            "Common",
            "Rare",
            "Extra Rare"});
            this.cmbRarity.Location = new System.Drawing.Point(471, 229);
            this.cmbRarity.Name = "cmbRarity";
            this.cmbRarity.Size = new System.Drawing.Size(222, 28);
            this.cmbRarity.TabIndex = 9;
            this.cmbRarity.SelectedIndexChanged += new System.EventHandler(this.cmbRarity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rarity:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(301, 65);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(328, 158);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(301, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 32);
            this.btnDelete.TabIndex = 26;
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
            this.lbResults.Location = new System.Drawing.Point(16, 60);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(272, 664);
            this.lbResults.TabIndex = 25;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(16, 20);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 32);
            this.btnCreate.TabIndex = 24;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSetUseContexts
            // 
            this.btnSetUseContexts.Location = new System.Drawing.Point(296, 20);
            this.btnSetUseContexts.Name = "btnSetUseContexts";
            this.btnSetUseContexts.Size = new System.Drawing.Size(156, 32);
            this.btnSetUseContexts.TabIndex = 30;
            this.btnSetUseContexts.Text = "Set Use Contexts";
            this.btnSetUseContexts.UseVisualStyleBackColor = true;
            this.btnSetUseContexts.Click += new System.EventHandler(this.btnSetUseContexts_Click);
            // 
            // ArtefactsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSetUseContexts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArtefactsUI";
            this.Size = new System.Drawing.Size(1172, 786);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlFragments.ResumeLayout(false);
            this.pnlFragments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcquireFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeeFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ComboBox cmbRarity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chbUnlockedByDefault;
        private System.Windows.Forms.NumericUpDown nudAcquireFrequency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSeeFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlFragments;
        private System.Windows.Forms.TextBox txtFragmentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveFragment;
        private System.Windows.Forms.Button btnAddFragment;
        private System.Windows.Forms.ListBox lbFragments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox clbOnUseContext;
        private System.Windows.Forms.Button btnSetUseContexts;
    }
}
