﻿
namespace StoryDev.Components.CodeUI
{
    partial class AcquireArtefactFragment
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
            this.cmbFragments = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFragments = new System.Windows.Forms.Button();
            this.lblArtefact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Acquire an artefact fragment by ID value, if unlocked.";
            // 
            // cmbFragments
            // 
            this.cmbFragments.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFragments.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbFragments.FormattingEnabled = true;
            this.cmbFragments.Location = new System.Drawing.Point(105, 50);
            this.cmbFragments.Name = "cmbFragments";
            this.cmbFragments.Size = new System.Drawing.Size(186, 28);
            this.cmbFragments.TabIndex = 8;
            this.cmbFragments.SelectedIndexChanged += new System.EventHandler(this.cmbFragments_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fragment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "AcquireArtefactFragment(id)";
            // 
            // btnFragments
            // 
            this.btnFragments.Location = new System.Drawing.Point(297, 50);
            this.btnFragments.Name = "btnFragments";
            this.btnFragments.Size = new System.Drawing.Size(39, 28);
            this.btnFragments.TabIndex = 12;
            this.btnFragments.Text = "...";
            this.btnFragments.UseVisualStyleBackColor = true;
            this.btnFragments.Click += new System.EventHandler(this.btnFragments_Click);
            // 
            // lblArtefact
            // 
            this.lblArtefact.AutoSize = true;
            this.lblArtefact.Location = new System.Drawing.Point(342, 53);
            this.lblArtefact.Name = "lblArtefact";
            this.lblArtefact.Size = new System.Drawing.Size(74, 20);
            this.lblArtefact.TabIndex = 13;
            this.lblArtefact.Text = "Artefact: ";
            // 
            // AcquireArtefactFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblArtefact);
            this.Controls.Add(this.btnFragments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFragments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AcquireArtefactFragment";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFragments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFragments;
        private System.Windows.Forms.Label lblArtefact;
    }
}
