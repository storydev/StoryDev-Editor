
namespace StoryDev.Forms
{
    partial class EditActivityForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTraits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudProgressOnComplete = new System.Windows.Forms.NumericUpDown();
            this.nudProgressOnPart = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbParts = new System.Windows.Forms.ListBox();
            this.pnlPartContent = new System.Windows.Forms.Panel();
            this.btnBrowseEndJournals = new System.Windows.Forms.Button();
            this.btnBrowseStartJournals = new System.Windows.Forms.Button();
            this.cmbEndPage = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStartPage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbSameJournal = new System.Windows.Forms.CheckBox();
            this.cmbEndingJournal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStartJournal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTraitInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chbHiddenUntilDiscovered = new System.Windows.Forms.CheckBox();
            this.btnBrowseTraits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgressOnComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgressOnPart)).BeginInit();
            this.pnlPartContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(380, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(156, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(380, 159);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Character Trait:";
            // 
            // cmbTraits
            // 
            this.cmbTraits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTraits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTraits.FormattingEnabled = true;
            this.cmbTraits.Location = new System.Drawing.Point(677, 35);
            this.cmbTraits.Name = "cmbTraits";
            this.cmbTraits.Size = new System.Drawing.Size(239, 28);
            this.cmbTraits.TabIndex = 5;
            this.cmbTraits.SelectedIndexChanged += new System.EventHandler(this.cmbTraits_SelectedIndexChanged);
            this.cmbTraits.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbTraits_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Progress On Complete:";
            // 
            // nudProgressOnComplete
            // 
            this.nudProgressOnComplete.Location = new System.Drawing.Point(732, 114);
            this.nudProgressOnComplete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProgressOnComplete.Name = "nudProgressOnComplete";
            this.nudProgressOnComplete.Size = new System.Drawing.Size(72, 26);
            this.nudProgressOnComplete.TabIndex = 7;
            this.nudProgressOnComplete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProgressOnComplete.ValueChanged += new System.EventHandler(this.nudProgressOnComplete_ValueChanged);
            // 
            // nudProgressOnPart
            // 
            this.nudProgressOnPart.Location = new System.Drawing.Point(950, 114);
            this.nudProgressOnPart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProgressOnPart.Name = "nudProgressOnPart";
            this.nudProgressOnPart.Size = new System.Drawing.Size(72, 26);
            this.nudProgressOnPart.TabIndex = 9;
            this.nudProgressOnPart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProgressOnPart.ValueChanged += new System.EventHandler(this.nudProgressOnPart_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(810, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Progress On Part:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Parts";
            // 
            // lbParts
            // 
            this.lbParts.FormattingEnabled = true;
            this.lbParts.ItemHeight = 20;
            this.lbParts.Location = new System.Drawing.Point(61, 262);
            this.lbParts.Name = "lbParts";
            this.lbParts.Size = new System.Drawing.Size(211, 224);
            this.lbParts.TabIndex = 11;
            this.lbParts.SelectedIndexChanged += new System.EventHandler(this.lbParts_SelectedIndexChanged);
            // 
            // pnlPartContent
            // 
            this.pnlPartContent.Controls.Add(this.btnBrowseEndJournals);
            this.pnlPartContent.Controls.Add(this.btnBrowseStartJournals);
            this.pnlPartContent.Controls.Add(this.cmbEndPage);
            this.pnlPartContent.Controls.Add(this.label10);
            this.pnlPartContent.Controls.Add(this.cmbStartPage);
            this.pnlPartContent.Controls.Add(this.label9);
            this.pnlPartContent.Controls.Add(this.chbSameJournal);
            this.pnlPartContent.Controls.Add(this.cmbEndingJournal);
            this.pnlPartContent.Controls.Add(this.label8);
            this.pnlPartContent.Controls.Add(this.cmbStartJournal);
            this.pnlPartContent.Controls.Add(this.label7);
            this.pnlPartContent.Enabled = false;
            this.pnlPartContent.Location = new System.Drawing.Point(278, 262);
            this.pnlPartContent.Name = "pnlPartContent";
            this.pnlPartContent.Size = new System.Drawing.Size(344, 225);
            this.pnlPartContent.TabIndex = 12;
            // 
            // btnBrowseEndJournals
            // 
            this.btnBrowseEndJournals.Location = new System.Drawing.Point(308, 83);
            this.btnBrowseEndJournals.Name = "btnBrowseEndJournals";
            this.btnBrowseEndJournals.Size = new System.Drawing.Size(33, 28);
            this.btnBrowseEndJournals.TabIndex = 22;
            this.btnBrowseEndJournals.Text = "...";
            this.btnBrowseEndJournals.UseVisualStyleBackColor = true;
            this.btnBrowseEndJournals.Click += new System.EventHandler(this.btnBrowseEndJournals_Click);
            // 
            // btnBrowseStartJournals
            // 
            this.btnBrowseStartJournals.Location = new System.Drawing.Point(308, 19);
            this.btnBrowseStartJournals.Name = "btnBrowseStartJournals";
            this.btnBrowseStartJournals.Size = new System.Drawing.Size(33, 28);
            this.btnBrowseStartJournals.TabIndex = 21;
            this.btnBrowseStartJournals.Text = "...";
            this.btnBrowseStartJournals.UseVisualStyleBackColor = true;
            this.btnBrowseStartJournals.Click += new System.EventHandler(this.btnBrowseStartJournals_Click);
            // 
            // cmbEndPage
            // 
            this.cmbEndPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndPage.FormattingEnabled = true;
            this.cmbEndPage.Location = new System.Drawing.Point(141, 151);
            this.cmbEndPage.Name = "cmbEndPage";
            this.cmbEndPage.Size = new System.Drawing.Size(133, 28);
            this.cmbEndPage.TabIndex = 8;
            this.cmbEndPage.SelectedIndexChanged += new System.EventHandler(this.cmbEndPage_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "End Page:";
            // 
            // cmbStartPage
            // 
            this.cmbStartPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartPage.FormattingEnabled = true;
            this.cmbStartPage.Location = new System.Drawing.Point(141, 117);
            this.cmbStartPage.Name = "cmbStartPage";
            this.cmbStartPage.Size = new System.Drawing.Size(133, 28);
            this.cmbStartPage.TabIndex = 6;
            this.cmbStartPage.SelectedIndexChanged += new System.EventHandler(this.cmbStartPage_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Start Page:";
            // 
            // chbSameJournal
            // 
            this.chbSameJournal.AutoSize = true;
            this.chbSameJournal.Location = new System.Drawing.Point(141, 53);
            this.chbSameJournal.Name = "chbSameJournal";
            this.chbSameJournal.Size = new System.Drawing.Size(133, 24);
            this.chbSameJournal.TabIndex = 4;
            this.chbSameJournal.Text = "Same Journal";
            this.chbSameJournal.UseVisualStyleBackColor = true;
            this.chbSameJournal.CheckedChanged += new System.EventHandler(this.chbSameJournal_CheckedChanged);
            // 
            // cmbEndingJournal
            // 
            this.cmbEndingJournal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEndingJournal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbEndingJournal.FormattingEnabled = true;
            this.cmbEndingJournal.Location = new System.Drawing.Point(141, 83);
            this.cmbEndingJournal.Name = "cmbEndingJournal";
            this.cmbEndingJournal.Size = new System.Drawing.Size(161, 28);
            this.cmbEndingJournal.TabIndex = 3;
            this.cmbEndingJournal.SelectedIndexChanged += new System.EventHandler(this.cmbEndingJournal_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ending Journal:";
            // 
            // cmbStartJournal
            // 
            this.cmbStartJournal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStartJournal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbStartJournal.FormattingEnabled = true;
            this.cmbStartJournal.Location = new System.Drawing.Point(141, 19);
            this.cmbStartJournal.Name = "cmbStartJournal";
            this.cmbStartJournal.Size = new System.Drawing.Size(161, 28);
            this.cmbStartJournal.TabIndex = 1;
            this.cmbStartJournal.SelectedIndexChanged += new System.EventHandler(this.cmbStartJournal_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Starting Journal:";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(61, 492);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(39, 32);
            this.btnAddPart.TabIndex = 13;
            this.btnAddPart.Text = "+";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(106, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1081, 534);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(985, 534);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 33);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTraitInfo
            // 
            this.lblTraitInfo.AutoSize = true;
            this.lblTraitInfo.Location = new System.Drawing.Point(553, 76);
            this.lblTraitInfo.Name = "lblTraitInfo";
            this.lblTraitInfo.Size = new System.Drawing.Size(131, 20);
            this.lblTraitInfo.TabIndex = 17;
            this.lblTraitInfo.Text = "No Trait Selected";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPreview);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(628, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 225);
            this.panel1.TabIndex = 18;
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(7, 25);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreview.Size = new System.Drawing.Size(498, 183);
            this.txtPreview.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Preview";
            // 
            // chbHiddenUntilDiscovered
            // 
            this.chbHiddenUntilDiscovered.AutoSize = true;
            this.chbHiddenUntilDiscovered.Location = new System.Drawing.Point(557, 153);
            this.chbHiddenUntilDiscovered.Name = "chbHiddenUntilDiscovered";
            this.chbHiddenUntilDiscovered.Size = new System.Drawing.Size(205, 24);
            this.chbHiddenUntilDiscovered.TabIndex = 19;
            this.chbHiddenUntilDiscovered.Text = "Hidden Until Discovered";
            this.chbHiddenUntilDiscovered.UseVisualStyleBackColor = true;
            this.chbHiddenUntilDiscovered.CheckedChanged += new System.EventHandler(this.chbHiddenUntilDiscovered_CheckedChanged);
            // 
            // btnBrowseTraits
            // 
            this.btnBrowseTraits.Location = new System.Drawing.Point(922, 35);
            this.btnBrowseTraits.Name = "btnBrowseTraits";
            this.btnBrowseTraits.Size = new System.Drawing.Size(33, 28);
            this.btnBrowseTraits.TabIndex = 20;
            this.btnBrowseTraits.Text = "...";
            this.btnBrowseTraits.UseVisualStyleBackColor = true;
            this.btnBrowseTraits.Click += new System.EventHandler(this.btnBrowseTraits_Click);
            // 
            // EditActivityForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1183, 579);
            this.Controls.Add(this.btnBrowseTraits);
            this.Controls.Add(this.chbHiddenUntilDiscovered);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTraitInfo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.pnlPartContent);
            this.Controls.Add(this.lbParts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudProgressOnPart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudProgressOnComplete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTraits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditActivityForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Activity";
            this.Load += new System.EventHandler(this.EditActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProgressOnComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgressOnPart)).EndInit();
            this.pnlPartContent.ResumeLayout(false);
            this.pnlPartContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTraits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudProgressOnComplete;
        private System.Windows.Forms.NumericUpDown nudProgressOnPart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbParts;
        private System.Windows.Forms.Panel pnlPartContent;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chbSameJournal;
        private System.Windows.Forms.ComboBox cmbEndingJournal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStartJournal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEndPage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStartPage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTraitInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbHiddenUntilDiscovered;
        private System.Windows.Forms.Button btnBrowseEndJournals;
        private System.Windows.Forms.Button btnBrowseStartJournals;
        private System.Windows.Forms.Button btnBrowseTraits;
    }
}