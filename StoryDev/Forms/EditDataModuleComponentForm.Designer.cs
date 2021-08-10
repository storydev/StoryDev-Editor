
namespace StoryDev.Forms
{
    partial class EditDataModuleComponentForm
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
            this.nudDefaultWidth = new System.Windows.Forms.NumericUpDown();
            this.nudDefaultHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLabelPosition = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Width:";
            // 
            // nudDefaultWidth
            // 
            this.nudDefaultWidth.Location = new System.Drawing.Point(215, 38);
            this.nudDefaultWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudDefaultWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudDefaultWidth.Name = "nudDefaultWidth";
            this.nudDefaultWidth.Size = new System.Drawing.Size(112, 26);
            this.nudDefaultWidth.TabIndex = 1;
            this.nudDefaultWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudDefaultWidth.ValueChanged += new System.EventHandler(this.nudDefaultWidth_ValueChanged);
            // 
            // nudDefaultHeight
            // 
            this.nudDefaultHeight.Location = new System.Drawing.Point(455, 38);
            this.nudDefaultHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudDefaultHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudDefaultHeight.Name = "nudDefaultHeight";
            this.nudDefaultHeight.Size = new System.Drawing.Size(112, 26);
            this.nudDefaultHeight.TabIndex = 3;
            this.nudDefaultHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudDefaultHeight.ValueChanged += new System.EventHandler(this.nudDefaultHeight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Default Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Label Position:";
            // 
            // cmbLabelPosition
            // 
            this.cmbLabelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelPosition.FormattingEnabled = true;
            this.cmbLabelPosition.Items.AddRange(new object[] {
            "Top",
            "Left",
            "Right",
            "Bottom"});
            this.cmbLabelPosition.Location = new System.Drawing.Point(217, 70);
            this.cmbLabelPosition.Name = "cmbLabelPosition";
            this.cmbLabelPosition.Size = new System.Drawing.Size(191, 28);
            this.cmbLabelPosition.TabIndex = 5;
            this.cmbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cmbLabelPosition_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(547, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(434, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 32);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EditDataModuleComponentForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(666, 182);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbLabelPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudDefaultHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDefaultWidth);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDataModuleComponentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Data Module Component";
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDefaultWidth;
        private System.Windows.Forms.NumericUpDown nudDefaultHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLabelPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}