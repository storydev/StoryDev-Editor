
namespace StoryDev.Components.Preferences
{
    partial class CodeEditorUI
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
            this.chbWordWrap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chbWordWrap
            // 
            this.chbWordWrap.AutoSize = true;
            this.chbWordWrap.Location = new System.Drawing.Point(30, 28);
            this.chbWordWrap.Name = "chbWordWrap";
            this.chbWordWrap.Size = new System.Drawing.Size(116, 24);
            this.chbWordWrap.TabIndex = 0;
            this.chbWordWrap.Text = "Word-Wrap";
            this.chbWordWrap.UseVisualStyleBackColor = true;
            this.chbWordWrap.CheckedChanged += new System.EventHandler(this.chbWordWrap_CheckedChanged);
            // 
            // CodeEditorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbWordWrap);
            this.Name = "CodeEditorUI";
            this.Size = new System.Drawing.Size(736, 802);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbWordWrap;
    }
}
