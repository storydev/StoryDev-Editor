namespace StoryDev.Components.Forms
{
    partial class FormCheckBox
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
            this.chbValue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbValue
            // 
            this.chbValue.AutoSize = true;
            this.chbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbValue.Location = new System.Drawing.Point(0, 0);
            this.chbValue.Name = "chbValue";
            this.chbValue.Size = new System.Drawing.Size(700, 37);
            this.chbValue.TabIndex = 0;
            this.chbValue.Text = "Field Name";
            this.chbValue.UseVisualStyleBackColor = true;
            // 
            // FormCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbValue);
            this.Name = "FormCheckBox";
            this.Size = new System.Drawing.Size(700, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbValue;
    }
}
