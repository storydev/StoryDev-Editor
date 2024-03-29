﻿
namespace StoryDev.Forms
{
    partial class StoryOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.lbStory = new System.Windows.Forms.ListBox();
            this.gbJournals = new System.Windows.Forms.GroupBox();
            this.pnlJournalOptions = new System.Windows.Forms.Panel();
            this.cmbAfterStoryPart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbJournalStoryOrder = new System.Windows.Forms.ListBox();
            this.cmbJournals = new System.Windows.Forms.ComboBox();
            this.btnBottomJournals = new System.Windows.Forms.Button();
            this.btnDownJournals = new System.Windows.Forms.Button();
            this.btnUpJournals = new System.Windows.Forms.Button();
            this.btnTopJournals = new System.Windows.Forms.Button();
            this.btnRemoveFromJournals = new System.Windows.Forms.Button();
            this.btnAddToJournals = new System.Windows.Forms.Button();
            this.chbIncludeJournals = new System.Windows.Forms.CheckBox();
            this.gbJournals.SuspendLayout();
            this.pnlJournalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing Files";
            // 
            // tvFiles
            // 
            this.tvFiles.Location = new System.Drawing.Point(22, 38);
            this.tvFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.PathSeparator = "/";
            this.tvFiles.Size = new System.Drawing.Size(306, 710);
            this.tvFiles.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(339, 38);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(339, 83);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 35);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.Image = global::StoryDev.Properties.Resources.ToBottom;
            this.btnBottom.Location = new System.Drawing.Point(339, 262);
            this.btnBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(40, 35);
            this.btnBottom.TabIndex = 7;
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnDown
            // 
            this.btnDown.Image = global::StoryDev.Properties.Resources.Down;
            this.btnDown.Location = new System.Drawing.Point(339, 217);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 35);
            this.btnDown.TabIndex = 6;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::StoryDev.Properties.Resources.Up;
            this.btnUp.Location = new System.Drawing.Point(339, 172);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 35);
            this.btnUp.TabIndex = 5;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::StoryDev.Properties.Resources.ToTop;
            this.btnTop.Location = new System.Drawing.Point(339, 128);
            this.btnTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(40, 35);
            this.btnTop.TabIndex = 4;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // lbStory
            // 
            this.lbStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStory.FormattingEnabled = true;
            this.lbStory.ItemHeight = 25;
            this.lbStory.Location = new System.Drawing.Point(388, 38);
            this.lbStory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStory.Name = "lbStory";
            this.lbStory.Size = new System.Drawing.Size(592, 304);
            this.lbStory.TabIndex = 8;
            // 
            // gbJournals
            // 
            this.gbJournals.Controls.Add(this.pnlJournalOptions);
            this.gbJournals.Controls.Add(this.lbJournalStoryOrder);
            this.gbJournals.Controls.Add(this.cmbJournals);
            this.gbJournals.Location = new System.Drawing.Point(388, 374);
            this.gbJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbJournals.Name = "gbJournals";
            this.gbJournals.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbJournals.Size = new System.Drawing.Size(594, 337);
            this.gbJournals.TabIndex = 9;
            this.gbJournals.TabStop = false;
            this.gbJournals.Text = "Journals";
            // 
            // pnlJournalOptions
            // 
            this.pnlJournalOptions.Controls.Add(this.cmbAfterStoryPart);
            this.pnlJournalOptions.Controls.Add(this.label2);
            this.pnlJournalOptions.Enabled = false;
            this.pnlJournalOptions.Location = new System.Drawing.Point(292, 71);
            this.pnlJournalOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlJournalOptions.Name = "pnlJournalOptions";
            this.pnlJournalOptions.Size = new System.Drawing.Size(292, 252);
            this.pnlJournalOptions.TabIndex = 10;
            // 
            // cmbAfterStoryPart
            // 
            this.cmbAfterStoryPart.FormattingEnabled = true;
            this.cmbAfterStoryPart.Location = new System.Drawing.Point(15, 43);
            this.cmbAfterStoryPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAfterStoryPart.Name = "cmbAfterStoryPart";
            this.cmbAfterStoryPart.Size = new System.Drawing.Size(271, 28);
            this.cmbAfterStoryPart.TabIndex = 1;
            this.cmbAfterStoryPart.SelectedIndexChanged += new System.EventHandler(this.cmbAfterStoryPart_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "After Main Story Part:";
            // 
            // lbJournalStoryOrder
            // 
            this.lbJournalStoryOrder.Enabled = false;
            this.lbJournalStoryOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJournalStoryOrder.FormattingEnabled = true;
            this.lbJournalStoryOrder.ItemHeight = 25;
            this.lbJournalStoryOrder.Location = new System.Drawing.Point(9, 71);
            this.lbJournalStoryOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbJournalStoryOrder.Name = "lbJournalStoryOrder";
            this.lbJournalStoryOrder.Size = new System.Drawing.Size(272, 229);
            this.lbJournalStoryOrder.TabIndex = 9;
            // 
            // cmbJournals
            // 
            this.cmbJournals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbJournals.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbJournals.FormattingEnabled = true;
            this.cmbJournals.Location = new System.Drawing.Point(9, 29);
            this.cmbJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJournals.Name = "cmbJournals";
            this.cmbJournals.Size = new System.Drawing.Size(272, 28);
            this.cmbJournals.TabIndex = 0;
            this.cmbJournals.SelectedIndexChanged += new System.EventHandler(this.cmbJournals_SelectedIndexChanged);
            // 
            // btnBottomJournals
            // 
            this.btnBottomJournals.Image = global::StoryDev.Properties.Resources.ToBottom;
            this.btnBottomJournals.Location = new System.Drawing.Point(339, 618);
            this.btnBottomJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBottomJournals.Name = "btnBottomJournals";
            this.btnBottomJournals.Size = new System.Drawing.Size(40, 35);
            this.btnBottomJournals.TabIndex = 15;
            this.btnBottomJournals.UseVisualStyleBackColor = true;
            // 
            // btnDownJournals
            // 
            this.btnDownJournals.Image = global::StoryDev.Properties.Resources.Down;
            this.btnDownJournals.Location = new System.Drawing.Point(339, 574);
            this.btnDownJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDownJournals.Name = "btnDownJournals";
            this.btnDownJournals.Size = new System.Drawing.Size(40, 35);
            this.btnDownJournals.TabIndex = 14;
            this.btnDownJournals.UseVisualStyleBackColor = true;
            // 
            // btnUpJournals
            // 
            this.btnUpJournals.Image = global::StoryDev.Properties.Resources.Up;
            this.btnUpJournals.Location = new System.Drawing.Point(339, 529);
            this.btnUpJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpJournals.Name = "btnUpJournals";
            this.btnUpJournals.Size = new System.Drawing.Size(40, 35);
            this.btnUpJournals.TabIndex = 13;
            this.btnUpJournals.UseVisualStyleBackColor = true;
            // 
            // btnTopJournals
            // 
            this.btnTopJournals.Image = global::StoryDev.Properties.Resources.ToTop;
            this.btnTopJournals.Location = new System.Drawing.Point(339, 485);
            this.btnTopJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTopJournals.Name = "btnTopJournals";
            this.btnTopJournals.Size = new System.Drawing.Size(40, 35);
            this.btnTopJournals.TabIndex = 12;
            this.btnTopJournals.UseVisualStyleBackColor = true;
            this.btnTopJournals.Click += new System.EventHandler(this.btnTopJournals_Click);
            // 
            // btnRemoveFromJournals
            // 
            this.btnRemoveFromJournals.Location = new System.Drawing.Point(339, 440);
            this.btnRemoveFromJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveFromJournals.Name = "btnRemoveFromJournals";
            this.btnRemoveFromJournals.Size = new System.Drawing.Size(40, 35);
            this.btnRemoveFromJournals.TabIndex = 11;
            this.btnRemoveFromJournals.Text = "<";
            this.btnRemoveFromJournals.UseVisualStyleBackColor = true;
            this.btnRemoveFromJournals.Click += new System.EventHandler(this.btnRemoveFromJournals_Click);
            // 
            // btnAddToJournals
            // 
            this.btnAddToJournals.Location = new System.Drawing.Point(339, 395);
            this.btnAddToJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToJournals.Name = "btnAddToJournals";
            this.btnAddToJournals.Size = new System.Drawing.Size(40, 35);
            this.btnAddToJournals.TabIndex = 10;
            this.btnAddToJournals.Text = ">";
            this.btnAddToJournals.UseVisualStyleBackColor = true;
            this.btnAddToJournals.Click += new System.EventHandler(this.btnAddToJournals_Click);
            // 
            // chbIncludeJournals
            // 
            this.chbIncludeJournals.AutoSize = true;
            this.chbIncludeJournals.Location = new System.Drawing.Point(388, 725);
            this.chbIncludeJournals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbIncludeJournals.Name = "chbIncludeJournals";
            this.chbIncludeJournals.Size = new System.Drawing.Size(245, 24);
            this.chbIncludeJournals.TabIndex = 16;
            this.chbIncludeJournals.Text = "Include Journals in Simulation";
            this.chbIncludeJournals.UseVisualStyleBackColor = true;
            this.chbIncludeJournals.CheckedChanged += new System.EventHandler(this.chbIncludeJournals_CheckedChanged);
            // 
            // StoryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 769);
            this.Controls.Add(this.chbIncludeJournals);
            this.Controls.Add(this.btnBottomJournals);
            this.Controls.Add(this.btnDownJournals);
            this.Controls.Add(this.btnUpJournals);
            this.Controls.Add(this.btnTopJournals);
            this.Controls.Add(this.btnRemoveFromJournals);
            this.Controls.Add(this.btnAddToJournals);
            this.Controls.Add(this.gbJournals);
            this.Controls.Add(this.lbStory);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tvFiles);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoryOrderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Story Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoryOrderForm_FormClosing);
            this.gbJournals.ResumeLayout(false);
            this.pnlJournalOptions.ResumeLayout(false);
            this.pnlJournalOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.ListBox lbStory;
        private System.Windows.Forms.GroupBox gbJournals;
        private System.Windows.Forms.Button btnBottomJournals;
        private System.Windows.Forms.Button btnDownJournals;
        private System.Windows.Forms.Button btnUpJournals;
        private System.Windows.Forms.Button btnTopJournals;
        private System.Windows.Forms.Button btnRemoveFromJournals;
        private System.Windows.Forms.Button btnAddToJournals;
        private System.Windows.Forms.ListBox lbJournalStoryOrder;
        private System.Windows.Forms.ComboBox cmbJournals;
        private System.Windows.Forms.CheckBox chbIncludeJournals;
        private System.Windows.Forms.Panel pnlJournalOptions;
        private System.Windows.Forms.ComboBox cmbAfterStoryPart;
        private System.Windows.Forms.Label label2;
    }
}