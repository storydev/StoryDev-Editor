
namespace StoryDev.Components.DataModule
{
    partial class FieldNumeric
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
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(391, 20);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name:";
            // 
            // nudValue
            // 
            this.nudValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudValue.Location = new System.Drawing.Point(0, 20);
            this.nudValue.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(391, 26);
            this.nudValue.TabIndex = 1;
            // 
            // FieldNumeric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.lblFieldName);
            this.Name = "FieldNumeric";
            this.Size = new System.Drawing.Size(391, 45);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.NumericUpDown nudValue;
    }
}
