
namespace StoryDev.Components.CodeUI
{
    partial class IsSectionAvailable
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
            this.btnBrowseSections = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowseSections
            // 
            this.btnBrowseSections.Location = new System.Drawing.Point(262, 50);
            this.btnBrowseSections.Name = "btnBrowseSections";
            this.btnBrowseSections.Size = new System.Drawing.Size(38, 28);
            this.btnBrowseSections.TabIndex = 22;
            this.btnBrowseSections.Text = "...";
            this.btnBrowseSections.UseVisualStyleBackColor = true;
            this.btnBrowseSections.Click += new System.EventHandler(this.btnBrowseSections_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 21;
            this.label4.Text = "Is the given section available to enter from the current section.";
            // 
            // cmbSections
            // 
            this.cmbSections.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSections.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(90, 50);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(166, 28);
            this.cmbSections.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Section:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "IsSectionAvailable(id)";
            // 
            // IsSectionAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseSections);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IsSectionAvailable";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseSections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
