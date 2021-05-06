
namespace StoryDev.Components.CodeUI
{
    partial class HasFrequencyWithGroup
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCharacters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFrequency = new System.Windows.Forms.NumericUpDown();
            this.btnBrowseCharacters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Has the player a frequency of the specified value or greater towards a given char" +
    "acter\'s related group.";
            // 
            // cmbCharacters
            // 
            this.cmbCharacters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCharacters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCharacters.FormattingEnabled = true;
            this.cmbCharacters.Location = new System.Drawing.Point(106, 50);
            this.cmbCharacters.Name = "cmbCharacters";
            this.cmbCharacters.Size = new System.Drawing.Size(197, 28);
            this.cmbCharacters.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Character:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "HasFrequencyWithGroup(id, value)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Frequency:";
            // 
            // nudFrequency
            // 
            this.nudFrequency.DecimalPlaces = 2;
            this.nudFrequency.Location = new System.Drawing.Point(453, 51);
            this.nudFrequency.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudFrequency.Name = "nudFrequency";
            this.nudFrequency.Size = new System.Drawing.Size(120, 26);
            this.nudFrequency.TabIndex = 13;
            this.nudFrequency.Value = new decimal(new int[] {
            300,
            0,
            0,
            131072});
            // 
            // btnBrowseCharacters
            // 
            this.btnBrowseCharacters.Location = new System.Drawing.Point(309, 50);
            this.btnBrowseCharacters.Name = "btnBrowseCharacters";
            this.btnBrowseCharacters.Size = new System.Drawing.Size(44, 28);
            this.btnBrowseCharacters.TabIndex = 14;
            this.btnBrowseCharacters.Text = "...";
            this.btnBrowseCharacters.UseVisualStyleBackColor = true;
            this.btnBrowseCharacters.Click += new System.EventHandler(this.btnBrowseCharacters_Click);
            // 
            // HasFrequencyWithGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseCharacters);
            this.Controls.Add(this.nudFrequency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HasFrequencyWithGroup";
            this.Size = new System.Drawing.Size(830, 150);
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFrequency;
        private System.Windows.Forms.Button btnBrowseCharacters;
    }
}
