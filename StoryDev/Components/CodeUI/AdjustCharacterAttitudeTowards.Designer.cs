
namespace StoryDev.Components.CodeUI
{
    partial class AdjustCharacterAttitudeTowards
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTowards = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCharacters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAttitude = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttitude)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(312, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(506, 56);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adjusts the value of a character attitude towards another character.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Attitude (-/+):";
            // 
            // cmbTowards
            // 
            this.cmbTowards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTowards.FormattingEnabled = true;
            this.cmbTowards.Location = new System.Drawing.Point(101, 76);
            this.cmbTowards.Name = "cmbTowards";
            this.cmbTowards.Size = new System.Drawing.Size(201, 28);
            this.cmbTowards.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Towards:";
            // 
            // cmbCharacters
            // 
            this.cmbCharacters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacters.FormattingEnabled = true;
            this.cmbCharacters.Location = new System.Drawing.Point(101, 42);
            this.cmbCharacters.Name = "cmbCharacters";
            this.cmbCharacters.Size = new System.Drawing.Size(201, 28);
            this.cmbCharacters.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Character:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "AdjustCharacterAttitudeTowards(a_id, b_id, attitude)";
            // 
            // nudAttitude
            // 
            this.nudAttitude.Location = new System.Drawing.Point(415, 44);
            this.nudAttitude.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAttitude.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nudAttitude.Name = "nudAttitude";
            this.nudAttitude.Size = new System.Drawing.Size(145, 26);
            this.nudAttitude.TabIndex = 18;
            // 
            // AdjustCharacterAttitudeTowards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudAttitude);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTowards);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdjustCharacterAttitudeTowards";
            this.Size = new System.Drawing.Size(830, 150);
            ((System.ComponentModel.ISupportInitialize)(this.nudAttitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTowards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAttitude;
    }
}
