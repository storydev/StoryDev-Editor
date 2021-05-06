
namespace StoryDev.Components.CodeUI
{
    partial class UnlockArtefact
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
            this.cmbArtefacts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseArtefacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Unlock access to an artefact by ID.";
            // 
            // cmbArtefacts
            // 
            this.cmbArtefacts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbArtefacts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbArtefacts.FormattingEnabled = true;
            this.cmbArtefacts.Location = new System.Drawing.Point(93, 50);
            this.cmbArtefacts.Name = "cmbArtefacts";
            this.cmbArtefacts.Size = new System.Drawing.Size(175, 28);
            this.cmbArtefacts.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artefact:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "UnlockArtefact(id)";
            // 
            // btnBrowseArtefacts
            // 
            this.btnBrowseArtefacts.Location = new System.Drawing.Point(274, 50);
            this.btnBrowseArtefacts.Name = "btnBrowseArtefacts";
            this.btnBrowseArtefacts.Size = new System.Drawing.Size(36, 28);
            this.btnBrowseArtefacts.TabIndex = 12;
            this.btnBrowseArtefacts.Text = "...";
            this.btnBrowseArtefacts.UseVisualStyleBackColor = true;
            this.btnBrowseArtefacts.Click += new System.EventHandler(this.btnBrowseArtefacts_Click);
            // 
            // UnlockArtefact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseArtefacts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbArtefacts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnlockArtefact";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbArtefacts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseArtefacts;
    }
}
