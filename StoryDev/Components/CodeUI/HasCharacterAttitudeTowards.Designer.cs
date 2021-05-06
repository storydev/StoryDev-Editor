
namespace StoryDev.Components.CodeUI
{
    partial class HasCharacterAttitudeTowards
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCharacters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTowards = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAttitude = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "HasCharacterAttitudeTowards(a_id, b_id, attitude)";
            // 
            // cmbCharacters
            // 
            this.cmbCharacters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacters.FormattingEnabled = true;
            this.cmbCharacters.Location = new System.Drawing.Point(104, 44);
            this.cmbCharacters.Name = "cmbCharacters";
            this.cmbCharacters.Size = new System.Drawing.Size(201, 28);
            this.cmbCharacters.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Character:";
            // 
            // cmbTowards
            // 
            this.cmbTowards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTowards.FormattingEnabled = true;
            this.cmbTowards.Location = new System.Drawing.Point(104, 78);
            this.cmbTowards.Name = "cmbTowards";
            this.cmbTowards.Size = new System.Drawing.Size(201, 28);
            this.cmbTowards.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Towards:";
            // 
            // cmbAttitude
            // 
            this.cmbAttitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttitude.FormattingEnabled = true;
            this.cmbAttitude.Location = new System.Drawing.Point(386, 44);
            this.cmbAttitude.Name = "cmbAttitude";
            this.cmbAttitude.Size = new System.Drawing.Size(194, 28);
            this.cmbAttitude.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Attitude:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(315, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(506, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "Has a Character an attitude set to a value in or around the given attitude toward" +
    "s a given character.";
            // 
            // HasCharacterAttitudeTowards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAttitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTowards);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HasCharacterAttitudeTowards";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTowards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAttitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
