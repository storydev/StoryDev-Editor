﻿
namespace StoryDev.Components.DataModule
{
    partial class FieldCheckList
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
            this.clbValues = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Padding = new System.Windows.Forms.Padding(2);
            this.lblFieldName.Size = new System.Drawing.Size(374, 26);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field:";
            // 
            // clbValues
            // 
            this.clbValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbValues.FormattingEnabled = true;
            this.clbValues.Location = new System.Drawing.Point(0, 26);
            this.clbValues.Name = "clbValues";
            this.clbValues.Size = new System.Drawing.Size(374, 250);
            this.clbValues.TabIndex = 1;
            // 
            // FieldCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clbValues);
            this.Controls.Add(this.lblFieldName);
            this.Name = "FieldCheckList";
            this.Size = new System.Drawing.Size(374, 276);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.CheckedListBox clbValues;
    }
}
