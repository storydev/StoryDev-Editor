
namespace StoryDev.Components.DataModule
{
    partial class FieldComboBox
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
            this.lblFieldName = new System.Windows.Forms.Label();
            this.cmbValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Padding = new System.Windows.Forms.Padding(2);
            this.lblFieldName.Size = new System.Drawing.Size(445, 26);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "Field:";
            // 
            // cmbValue
            // 
            this.cmbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbValue.FormattingEnabled = true;
            this.cmbValue.Location = new System.Drawing.Point(0, 26);
            this.cmbValue.Name = "cmbValue";
            this.cmbValue.Size = new System.Drawing.Size(445, 28);
            this.cmbValue.TabIndex = 2;
            // 
            // FieldComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbValue);
            this.Controls.Add(this.lblFieldName);
            this.Name = "FieldComboBox";
            this.Size = new System.Drawing.Size(445, 55);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.ComboBox cmbValue;
    }
}
