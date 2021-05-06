
namespace StoryDev.Components.Data
{
    partial class FilterString
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFieldName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbOperator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(201, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 38);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtValue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 38);
            this.panel3.TabIndex = 2;
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblFieldName.Size = new System.Drawing.Size(201, 38);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name";
            this.lblFieldName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOperator
            // 
            this.cmbOperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "Contains",
            "Begins",
            "Ends"});
            this.cmbOperator.Location = new System.Drawing.Point(6, 6);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(90, 28);
            this.cmbOperator.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(6, 6);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(288, 26);
            this.txtValue.TabIndex = 0;
            // 
            // FilterString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FilterString";
            this.Size = new System.Drawing.Size(600, 38);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtValue;
    }
}
