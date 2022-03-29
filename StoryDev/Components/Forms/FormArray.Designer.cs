namespace StoryDev.Components.Forms
{
    partial class FormArray
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlEnterValue = new System.Windows.Forms.Panel();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(690, 33);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Field Name";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlEnterValue
            // 
            this.pnlEnterValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlEnterValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEnterValue.Location = new System.Drawing.Point(5, 38);
            this.pnlEnterValue.Name = "pnlEnterValue";
            this.pnlEnterValue.Padding = new System.Windows.Forms.Padding(4);
            this.pnlEnterValue.Size = new System.Drawing.Size(690, 41);
            this.pnlEnterValue.TabIndex = 1;
            // 
            // pnlResults
            // 
            this.pnlResults.AutoScroll = true;
            this.pnlResults.BackColor = System.Drawing.Color.White;
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.Location = new System.Drawing.Point(5, 79);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Padding = new System.Windows.Forms.Padding(4);
            this.pnlResults.Size = new System.Drawing.Size(690, 256);
            this.pnlResults.TabIndex = 2;
            // 
            // FormArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlEnterValue);
            this.Controls.Add(this.panel1);
            this.Name = "FormArray";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(700, 340);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlEnterValue;
        private System.Windows.Forms.Panel pnlResults;
    }
}
