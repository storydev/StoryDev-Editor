﻿
namespace StoryDev.Components
{
    partial class ItemUI
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
            this.cmbItemUseContext = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbConsumed = new System.Windows.Forms.CheckBox();
            this.nudUseCooldown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOnUseScript = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSellPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRarity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbSpecial = new System.Windows.Forms.CheckBox();
            this.chbIsUnique = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnIconIndex = new StoryDev.Components.IconSelect();
            this.pnlContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUseCooldown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(11, 475);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 22);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(694, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 21;
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
            this.pnlContent.Controls.Add(this.btnIconIndex);
            this.pnlContent.Controls.Add(this.cmbItemUseContext);
            this.pnlContent.Controls.Add(this.label8);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.nudSellPrice);
            this.pnlContent.Controls.Add(this.label6);
            this.pnlContent.Controls.Add(this.nudBuyPrice);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Controls.Add(this.cmbRarity);
            this.pnlContent.Controls.Add(this.label4);
            this.pnlContent.Controls.Add(this.chbSpecial);
            this.pnlContent.Controls.Add(this.chbIsUnique);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Enabled = false;
            this.pnlContent.Location = new System.Drawing.Point(197, 40);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(573, 458);
            this.pnlContent.TabIndex = 20;
            // 
            // cmbItemUseContext
            // 
            this.cmbItemUseContext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbItemUseContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemUseContext.FormattingEnabled = true;
            this.cmbItemUseContext.Items.AddRange(new object[] {
            "Feed",
            "Thirst",
            "Knowledge",
            "Wound",
            "Antidote",
            "Melee Combat",
            "Ranged Combat",
            "Miscellaneous"});
            this.cmbItemUseContext.Location = new System.Drawing.Point(221, 230);
            this.cmbItemUseContext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbItemUseContext.Name = "cmbItemUseContext";
            this.cmbItemUseContext.Size = new System.Drawing.Size(123, 21);
            this.cmbItemUseContext.TabIndex = 16;
            this.cmbItemUseContext.SelectedIndexChanged += new System.EventHandler(this.cmbItemUseContext_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Item Use Context:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.chbConsumed);
            this.groupBox1.Controls.Add(this.nudUseCooldown);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtOnUseScript);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(105, 264);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(365, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scripting";
            // 
            // chbConsumed
            // 
            this.chbConsumed.AutoSize = true;
            this.chbConsumed.Location = new System.Drawing.Point(51, 132);
            this.chbConsumed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbConsumed.Name = "chbConsumed";
            this.chbConsumed.Size = new System.Drawing.Size(113, 17);
            this.chbConsumed.TabIndex = 7;
            this.chbConsumed.Text = "Consumed on Use";
            this.chbConsumed.UseVisualStyleBackColor = true;
            this.chbConsumed.CheckedChanged += new System.EventHandler(this.chbConsumed_CheckedChanged);
            // 
            // nudUseCooldown
            // 
            this.nudUseCooldown.Location = new System.Drawing.Point(248, 131);
            this.nudUseCooldown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudUseCooldown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudUseCooldown.Name = "nudUseCooldown";
            this.nudUseCooldown.Size = new System.Drawing.Size(99, 20);
            this.nudUseCooldown.TabIndex = 6;
            this.nudUseCooldown.ValueChanged += new System.EventHandler(this.nudUseCooldown_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Use Cooldown:";
            // 
            // txtOnUseScript
            // 
            this.txtOnUseScript.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOnUseScript.Location = new System.Drawing.Point(94, 23);
            this.txtOnUseScript.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOnUseScript.Multiline = true;
            this.txtOnUseScript.Name = "txtOnUseScript";
            this.txtOnUseScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOnUseScript.Size = new System.Drawing.Size(255, 104);
            this.txtOnUseScript.TabIndex = 4;
            this.txtOnUseScript.TextChanged += new System.EventHandler(this.txtOnUseScript_TextChanged);
            this.txtOnUseScript.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOnUseScript_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "On Use Script:";
            // 
            // nudSellPrice
            // 
            this.nudSellPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSellPrice.DecimalPlaces = 2;
            this.nudSellPrice.Location = new System.Drawing.Point(346, 194);
            this.nudSellPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSellPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudSellPrice.Name = "nudSellPrice";
            this.nudSellPrice.Size = new System.Drawing.Size(91, 20);
            this.nudSellPrice.TabIndex = 13;
            this.nudSellPrice.ValueChanged += new System.EventHandler(this.nudSellPrice_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sell Price:";
            // 
            // nudBuyPrice
            // 
            this.nudBuyPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudBuyPrice.DecimalPlaces = 2;
            this.nudBuyPrice.Location = new System.Drawing.Point(251, 194);
            this.nudBuyPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudBuyPrice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudBuyPrice.Name = "nudBuyPrice";
            this.nudBuyPrice.Size = new System.Drawing.Size(91, 20);
            this.nudBuyPrice.TabIndex = 11;
            this.nudBuyPrice.ValueChanged += new System.EventHandler(this.nudBuyPrice_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Buy Price:";
            // 
            // cmbRarity
            // 
            this.cmbRarity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbRarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRarity.FormattingEnabled = true;
            this.cmbRarity.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Super",
            "Impossible"});
            this.cmbRarity.Location = new System.Drawing.Point(323, 149);
            this.cmbRarity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRarity.Name = "cmbRarity";
            this.cmbRarity.Size = new System.Drawing.Size(149, 21);
            this.cmbRarity.TabIndex = 9;
            this.cmbRarity.SelectedIndexChanged += new System.EventHandler(this.cmbRarity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rarity:";
            // 
            // chbSpecial
            // 
            this.chbSpecial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbSpecial.AutoSize = true;
            this.chbSpecial.Location = new System.Drawing.Point(185, 150);
            this.chbSpecial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbSpecial.Name = "chbSpecial";
            this.chbSpecial.Size = new System.Drawing.Size(61, 17);
            this.chbSpecial.TabIndex = 7;
            this.chbSpecial.Text = "Special";
            this.chbSpecial.UseVisualStyleBackColor = true;
            this.chbSpecial.CheckedChanged += new System.EventHandler(this.chbSpecial_CheckedChanged);
            // 
            // chbIsUnique
            // 
            this.chbIsUnique.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbIsUnique.AutoSize = true;
            this.chbIsUnique.Location = new System.Drawing.Point(123, 150);
            this.chbIsUnique.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbIsUnique.Name = "chbIsUnique";
            this.chbIsUnique.Size = new System.Drawing.Size(60, 17);
            this.chbIsUnique.TabIndex = 6;
            this.chbIsUnique.Text = "Unique";
            this.chbIsUnique.UseVisualStyleBackColor = true;
            this.chbIsUnique.CheckedChanged += new System.EventHandler(this.chbIsUnique_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Icon:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(275, 42);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(220, 104);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(275, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 21);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(11, 40);
            this.lbResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(183, 433);
            this.lbResults.TabIndex = 18;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 14);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 21);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnIconIndex
            // 
            this.btnIconIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIconIndex.IconIndex = -1;
            this.btnIconIndex.IconSet = null;
            this.btnIconIndex.Location = new System.Drawing.Point(138, 21);
            this.btnIconIndex.Name = "btnIconIndex";
            this.btnIconIndex.Size = new System.Drawing.Size(68, 68);
            this.btnIconIndex.TabIndex = 17;
            this.btnIconIndex.UseVisualStyleBackColor = true;
            // 
            // ItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnCreate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ItemUI";
            this.Size = new System.Drawing.Size(781, 511);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUseCooldown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbSpecial;
        private System.Windows.Forms.CheckBox chbIsUnique;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRarity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBuyPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbItemUseContext;
        private System.Windows.Forms.TextBox txtOnUseScript;
        private System.Windows.Forms.NumericUpDown nudUseCooldown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbConsumed;
        private IconSelect btnIconIndex;
    }
}
