﻿
namespace StoryDev.Forms
{
    partial class CustomVariablesForm
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
            this.components = new System.ComponentModel.Container();
            this.sbtnAddVar = new StoryDev.Components.SplitButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVars = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChapters = new System.Windows.Forms.ComboBox();
            this.lvResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsEditMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbtnAddVar
            // 
            this.sbtnAddVar.Location = new System.Drawing.Point(26, 21);
            this.sbtnAddVar.Name = "sbtnAddVar";
            this.sbtnAddVar.Size = new System.Drawing.Size(136, 36);
            this.sbtnAddVar.TabIndex = 0;
            this.sbtnAddVar.Text = "Add";
            this.sbtnAddVar.UseVisualStyleBackColor = true;
            this.sbtnAddVar.Click += new System.EventHandler(this.sbtnAddVar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Variables:";
            // 
            // cmbVars
            // 
            this.cmbVars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVars.FormattingEnabled = true;
            this.cmbVars.Items.AddRange(new object[] {
            "All",
            "Booleans",
            "Numbers",
            "Strings"});
            this.cmbVars.Location = new System.Drawing.Point(263, 26);
            this.cmbVars.Name = "cmbVars";
            this.cmbVars.Size = new System.Drawing.Size(123, 28);
            this.cmbVars.TabIndex = 3;
            this.cmbVars.SelectedIndexChanged += new System.EventHandler(this.cmbVars_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Declared Chapter:";
            // 
            // cmbChapters
            // 
            this.cmbChapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChapters.FormattingEnabled = true;
            this.cmbChapters.Location = new System.Drawing.Point(546, 26);
            this.cmbChapters.Name = "cmbChapters";
            this.cmbChapters.Size = new System.Drawing.Size(191, 28);
            this.cmbChapters.TabIndex = 5;
            this.cmbChapters.SelectedIndexChanged += new System.EventHandler(this.cmbChapters_SelectedIndexChanged);
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvResults.ContextMenuStrip = this.cmsEditMenu;
            this.lvResults.FullRowSelect = true;
            this.lvResults.HideSelection = false;
            this.lvResults.Location = new System.Drawing.Point(26, 63);
            this.lvResults.MultiSelect = false;
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(711, 472);
            this.lvResults.TabIndex = 6;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            this.lvResults.DoubleClick += new System.EventHandler(this.lvResults_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Declared";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Default Value";
            this.columnHeader4.Width = 142;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "You can use the dollar sign ($) to retrieve the value of a variable and insert it" +
    " into dialogue in conversations.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(623, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsEditMenu
            // 
            this.cmsEditMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyNameToolStripMenuItem});
            this.cmsEditMenu.Name = "cmsEditMenu";
            this.cmsEditMenu.Size = new System.Drawing.Size(241, 69);
            this.cmsEditMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsEditMenu_Opening);
            // 
            // copyNameToolStripMenuItem
            // 
            this.copyNameToolStripMenuItem.Enabled = false;
            this.copyNameToolStripMenuItem.Name = "copyNameToolStripMenuItem";
            this.copyNameToolStripMenuItem.Size = new System.Drawing.Size(178, 32);
            this.copyNameToolStripMenuItem.Text = "Copy Name";
            this.copyNameToolStripMenuItem.Click += new System.EventHandler(this.copyNameToolStripMenuItem_Click);
            // 
            // CustomVariablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 603);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.cmbChapters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbtnAddVar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomVariablesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Variables";
            this.cmsEditMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.SplitButton sbtnAddVar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChapters;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsEditMenu;
        private System.Windows.Forms.ToolStripMenuItem copyNameToolStripMenuItem;
    }
}