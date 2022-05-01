
namespace StoryDev.Forms
{
    partial class IconSetsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbIconSet = new System.Windows.Forms.ComboBox();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudIconSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbIconSet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 34);
            this.panel1.TabIndex = 1;
            // 
            // cmbIconSet
            // 
            this.cmbIconSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIconSet.FormattingEnabled = true;
            this.cmbIconSet.Items.AddRange(new object[] {
            "Items"});
            this.cmbIconSet.Location = new System.Drawing.Point(12, 3);
            this.cmbIconSet.Name = "cmbIconSet";
            this.cmbIconSet.Size = new System.Drawing.Size(212, 28);
            this.cmbIconSet.TabIndex = 0;
            this.cmbIconSet.SelectedIndexChanged += new System.EventHandler(this.cmbIconSet_SelectedIndexChanged);
            // 
            // pnlProperties
            // 
            this.pnlProperties.Controls.Add(this.label3);
            this.pnlProperties.Controls.Add(this.nudIconSize);
            this.pnlProperties.Controls.Add(this.label2);
            this.pnlProperties.Controls.Add(this.btnBrowse);
            this.pnlProperties.Controls.Add(this.txtFilePath);
            this.pnlProperties.Controls.Add(this.label1);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProperties.Enabled = false;
            this.pnlProperties.Location = new System.Drawing.Point(0, 34);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(318, 964);
            this.pnlProperties.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "px";
            // 
            // nudIconSize
            // 
            this.nudIconSize.Location = new System.Drawing.Point(16, 132);
            this.nudIconSize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudIconSize.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudIconSize.Name = "nudIconSize";
            this.nudIconSize.Size = new System.Drawing.Size(120, 26);
            this.nudIconSize.TabIndex = 3;
            this.nudIconSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudIconSize.ValueChanged += new System.EventHandler(this.nudIconSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Icon Size:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(16, 63);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 32);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(16, 31);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(286, 26);
            this.txtFilePath.TabIndex = 3;
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path:";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(318, 34);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(825, 964);
            this.pnlMainContent.TabIndex = 3;
            // 
            // IconSetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 998);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IconSetsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Icon Sets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IconSetsForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.pnlProperties.ResumeLayout(false);
            this.pnlProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIconSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbIconSet;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudIconSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMainContent;
    }
}