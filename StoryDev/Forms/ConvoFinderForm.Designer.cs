namespace StoryDev.Forms
{
    partial class ConvoFinderForm
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
            this.txtSearchConvo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSearchConvo
            // 
            this.txtSearchConvo.Location = new System.Drawing.Point(12, 12);
            this.txtSearchConvo.Name = "txtSearchConvo";
            this.txtSearchConvo.Size = new System.Drawing.Size(925, 26);
            this.txtSearchConvo.TabIndex = 0;
            this.txtSearchConvo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchConvo_KeyUp);
            // 
            // ConvoFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 841);
            this.Controls.Add(this.txtSearchConvo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvoFinderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convo Finder";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ConvoFinderForm_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchConvo_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchConvo;
    }
}