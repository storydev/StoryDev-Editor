
namespace StoryDev.Forms
{
    partial class EditAttitudeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTowardsCharacter = new System.Windows.Forms.ComboBox();
            this.cmbInitialAttitude = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRealAttitude = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Towards Character:";
            // 
            // cmbTowardsCharacter
            // 
            this.cmbTowardsCharacter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTowardsCharacter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTowardsCharacter.FormattingEnabled = true;
            this.cmbTowardsCharacter.Location = new System.Drawing.Point(275, 30);
            this.cmbTowardsCharacter.Name = "cmbTowardsCharacter";
            this.cmbTowardsCharacter.Size = new System.Drawing.Size(257, 28);
            this.cmbTowardsCharacter.TabIndex = 1;
            this.cmbTowardsCharacter.SelectedIndexChanged += new System.EventHandler(this.cmbTowardsCharacter_SelectedIndexChanged);
            // 
            // cmbInitialAttitude
            // 
            this.cmbInitialAttitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInitialAttitude.FormattingEnabled = true;
            this.cmbInitialAttitude.Items.AddRange(new object[] {
            "Hate (-50)",
            "Angry (-30)",
            "Upset (-10)",
            "Content (0)",
            "Happy (+10)",
            "Joyous (+30)",
            "Love (+50)"});
            this.cmbInitialAttitude.Location = new System.Drawing.Point(275, 64);
            this.cmbInitialAttitude.Name = "cmbInitialAttitude";
            this.cmbInitialAttitude.Size = new System.Drawing.Size(237, 28);
            this.cmbInitialAttitude.TabIndex = 3;
            this.cmbInitialAttitude.SelectedIndexChanged += new System.EventHandler(this.cmbInitialAttitude_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Initial Attitude:";
            // 
            // cmbRealAttitude
            // 
            this.cmbRealAttitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRealAttitude.FormattingEnabled = true;
            this.cmbRealAttitude.Items.AddRange(new object[] {
            "Hate (-50)",
            "Angry (-30)",
            "Upset (-10)",
            "Content (0)",
            "Happy (+10)",
            "Joyous (+30)",
            "Love (+50)"});
            this.cmbRealAttitude.Location = new System.Drawing.Point(275, 98);
            this.cmbRealAttitude.Name = "cmbRealAttitude";
            this.cmbRealAttitude.Size = new System.Drawing.Size(237, 28);
            this.cmbRealAttitude.TabIndex = 5;
            this.cmbRealAttitude.SelectedIndexChanged += new System.EventHandler(this.cmbRealAttitude_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Real Attitude:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(530, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(412, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 36);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // EditAttitudeForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(654, 224);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbRealAttitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbInitialAttitude);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTowardsCharacter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditAttitudeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Attitude";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTowardsCharacter;
        private System.Windows.Forms.ComboBox cmbInitialAttitude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRealAttitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}