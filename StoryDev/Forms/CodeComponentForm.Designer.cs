
namespace StoryDev.Forms
{
    partial class CodeComponentForm
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
            this.pnlCondition = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConditionalOperator = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCondition);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlCondition
            // 
            this.pnlCondition.Controls.Add(this.label1);
            this.pnlCondition.Controls.Add(this.cmbConditionalOperator);
            this.pnlCondition.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlCondition.Name = "pnlCondition";
            this.pnlCondition.Size = new System.Drawing.Size(314, 46);
            this.pnlCondition.TabIndex = 2;
            this.pnlCondition.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Next:";
            // 
            // cmbConditionalOperator
            // 
            this.cmbConditionalOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConditionalOperator.FormattingEnabled = true;
            this.cmbConditionalOperator.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.cmbConditionalOperator.Location = new System.Drawing.Point(63, 9);
            this.cmbConditionalOperator.Name = "cmbConditionalOperator";
            this.cmbConditionalOperator.Size = new System.Drawing.Size(121, 28);
            this.cmbConditionalOperator.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(650, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(81, 30);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(737, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(830, 150);
            this.pnlContent.TabIndex = 1;
            // 
            // CodeComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 196);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeComponentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Component";
            this.panel1.ResumeLayout(false);
            this.pnlCondition.ResumeLayout(false);
            this.pnlCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConditionalOperator;
    }
}