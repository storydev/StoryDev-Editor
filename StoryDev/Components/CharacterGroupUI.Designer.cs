
namespace StoryDev.Components
{
    partial class CharacterGroupUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.nudInitialFrequency = new System.Windows.Forms.NumericUpDown();
            this.nudFrequencyRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequencyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1041, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 33);
            this.btnSave.TabIndex = 9;
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
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.nudInitialFrequency);
            this.pnlContent.Controls.Add(this.nudFrequencyRate);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Enabled = false;
            this.pnlContent.Location = new System.Drawing.Point(295, 61);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(859, 704);
            this.pnlContent.TabIndex = 8;
            this.pnlContent.Layout += new System.Windows.Forms.LayoutEventHandler(this.pnlContent_Layout);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Initial Frequency:";
            // 
            // nudInitialFrequency
            // 
            this.nudInitialFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudInitialFrequency.DecimalPlaces = 2;
            this.nudInitialFrequency.Location = new System.Drawing.Point(594, 69);
            this.nudInitialFrequency.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudInitialFrequency.Name = "nudInitialFrequency";
            this.nudInitialFrequency.Size = new System.Drawing.Size(91, 26);
            this.nudInitialFrequency.TabIndex = 17;
            this.nudInitialFrequency.Value = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.nudInitialFrequency.ValueChanged += new System.EventHandler(this.nudInitialFrequency_ValueChanged);
            // 
            // nudFrequencyRate
            // 
            this.nudFrequencyRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudFrequencyRate.DecimalPlaces = 2;
            this.nudFrequencyRate.Location = new System.Drawing.Point(362, 69);
            this.nudFrequencyRate.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudFrequencyRate.Name = "nudFrequencyRate";
            this.nudFrequencyRate.Size = new System.Drawing.Size(91, 26);
            this.nudFrequencyRate.TabIndex = 16;
            this.nudFrequencyRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrequencyRate.ValueChanged += new System.EventHandler(this.nudFrequencyRate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Default Frequency Rate:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(362, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 26);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(41, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 300);
            this.panel1.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(176, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbResults
            // 
            this.lbResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 20;
            this.lbResults.Location = new System.Drawing.Point(17, 61);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(272, 704);
            this.lbResults.TabIndex = 6;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 22);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(113, 33);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CharacterGroupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnCreate);
            this.Name = "CharacterGroupUI";
            this.Size = new System.Drawing.Size(1171, 786);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequencyRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudFrequencyRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudInitialFrequency;
        private System.Windows.Forms.Label label3;
    }
}
