
namespace StoryDev.Components.DataModule
{
    partial class FieldIconSelector
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
            this.btnSelectIcon = new StoryDev.Components.IconSelect();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(99, 23);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name:";
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectIcon.IconIndex = -1;
            this.btnSelectIcon.IconSet = null;
            this.btnSelectIcon.Location = new System.Drawing.Point(0, 23);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(99, 101);
            this.btnSelectIcon.TabIndex = 1;
            this.btnSelectIcon.UseVisualStyleBackColor = true;
            // 
            // FieldIconSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSelectIcon);
            this.Controls.Add(this.lblFieldName);
            this.Name = "FieldIconSelector";
            this.Size = new System.Drawing.Size(99, 124);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private IconSelect btnSelectIcon;
    }
}
