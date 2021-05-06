
namespace StoryDev.Components.CodeUI
{
    partial class AdjustCharacterTrait
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
            this.cmbTraits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseTraits = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adjusts the progress of a character\'s trait by id.";
            // 
            // cmbTraits
            // 
            this.cmbTraits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTraits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTraits.FormattingEnabled = true;
            this.cmbTraits.Location = new System.Drawing.Point(67, 50);
            this.cmbTraits.Name = "cmbTraits";
            this.cmbTraits.Size = new System.Drawing.Size(201, 28);
            this.cmbTraits.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trait:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "AdjustCharacterTrait(id, value)";
            // 
            // btnBrowseTraits
            // 
            this.btnBrowseTraits.Location = new System.Drawing.Point(274, 50);
            this.btnBrowseTraits.Name = "btnBrowseTraits";
            this.btnBrowseTraits.Size = new System.Drawing.Size(35, 28);
            this.btnBrowseTraits.TabIndex = 12;
            this.btnBrowseTraits.Text = "...";
            this.btnBrowseTraits.UseVisualStyleBackColor = true;
            this.btnBrowseTraits.Click += new System.EventHandler(this.btnBrowseTraits_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Value:";
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(375, 51);
            this.nudValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 26);
            this.nudValue.TabIndex = 14;
            // 
            // AdjustCharacterTrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseTraits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTraits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdjustCharacterTrait";
            this.Size = new System.Drawing.Size(830, 150);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTraits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseTraits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudValue;
    }
}
