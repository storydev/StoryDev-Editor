namespace StoryDev.Components.TestEnv
{
    partial class SectionResults
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
            this.pnlResultContent = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbStructures = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlResultContent);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 626);
            this.panel1.TabIndex = 0;
            // 
            // pnlResultContent
            // 
            this.pnlResultContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultContent.Location = new System.Drawing.Point(0, 89);
            this.pnlResultContent.Name = "pnlResultContent";
            this.pnlResultContent.Size = new System.Drawing.Size(1341, 537);
            this.pnlResultContent.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbStructures);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(1341, 50);
            this.panel3.TabIndex = 1;
            // 
            // rdbStructures
            // 
            this.rdbStructures.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbStructures.AutoSize = true;
            this.rdbStructures.Checked = true;
            this.rdbStructures.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbStructures.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbStructures.FlatAppearance.BorderSize = 0;
            this.rdbStructures.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbStructures.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.rdbStructures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.rdbStructures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbStructures.Location = new System.Drawing.Point(8, 8);
            this.rdbStructures.Name = "rdbStructures";
            this.rdbStructures.Size = new System.Drawing.Size(132, 34);
            this.rdbStructures.TabIndex = 0;
            this.rdbStructures.TabStop = true;
            this.rdbStructures.Text = "Data Structures";
            this.rdbStructures.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(1341, 39);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Results";
            // 
            // SectionResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SectionResults";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(1381, 666);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbStructures;
        private System.Windows.Forms.Panel pnlResultContent;
    }
}
