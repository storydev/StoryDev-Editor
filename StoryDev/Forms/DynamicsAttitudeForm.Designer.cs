
namespace StoryDev.Forms
{
    partial class DynamicsAttitudeForm
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
            this.cmbBranches = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCharacters = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAttitudes = new System.Windows.Forms.ComboBox();
            this.btnAddAttitude = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Dynamic for Branch:";
            // 
            // cmbBranches
            // 
            this.cmbBranches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranches.FormattingEnabled = true;
            this.cmbBranches.Location = new System.Drawing.Point(299, 21);
            this.cmbBranches.Name = "cmbBranches";
            this.cmbBranches.Size = new System.Drawing.Size(280, 28);
            this.cmbBranches.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnAddAttitude);
            this.panel1.Controls.Add(this.cmbAttitudes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbCharacters);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(93, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 130);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Character:";
            // 
            // cmbCharacters
            // 
            this.cmbCharacters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCharacters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCharacters.FormattingEnabled = true;
            this.cmbCharacters.Location = new System.Drawing.Point(111, 13);
            this.cmbCharacters.Name = "cmbCharacters";
            this.cmbCharacters.Size = new System.Drawing.Size(261, 28);
            this.cmbCharacters.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attitude:";
            // 
            // cmbAttitudes
            // 
            this.cmbAttitudes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttitudes.FormattingEnabled = true;
            this.cmbAttitudes.Location = new System.Drawing.Point(111, 47);
            this.cmbAttitudes.Name = "cmbAttitudes";
            this.cmbAttitudes.Size = new System.Drawing.Size(178, 28);
            this.cmbAttitudes.TabIndex = 3;
            // 
            // btnAddAttitude
            // 
            this.btnAddAttitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAttitude.Location = new System.Drawing.Point(381, 93);
            this.btnAddAttitude.Name = "btnAddAttitude";
            this.btnAddAttitude.Size = new System.Drawing.Size(102, 32);
            this.btnAddAttitude.TabIndex = 4;
            this.btnAddAttitude.Text = "Add";
            this.btnAddAttitude.UseVisualStyleBackColor = true;
            // 
            // DynamicsAttitudeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbBranches);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DynamicsAttitudeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attitude Dynamics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBranches;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddAttitude;
        private System.Windows.Forms.ComboBox cmbAttitudes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCharacters;
        private System.Windows.Forms.Label label2;
    }
}