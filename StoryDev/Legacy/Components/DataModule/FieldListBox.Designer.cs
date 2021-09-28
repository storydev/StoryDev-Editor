
namespace StoryDev.Components.DataModule
{
    partial class FieldListBox
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
            this.lbValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(354, 20);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name:";
            // 
            // lbValues
            // 
            this.lbValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbValues.FormattingEnabled = true;
            this.lbValues.ItemHeight = 20;
            this.lbValues.Location = new System.Drawing.Point(0, 20);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(354, 130);
            this.lbValues.TabIndex = 1;
            // 
            // FieldListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.lblFieldName);
            this.Name = "FieldListBox";
            this.Size = new System.Drawing.Size(354, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.ListBox lbValues;
    }
}
