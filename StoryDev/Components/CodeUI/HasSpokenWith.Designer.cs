
namespace StoryDev.Components.CodeUI
{
    partial class HasSpokenWith
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseGossips = new System.Windows.Forms.Button();
            this.cmbGossips = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Has the player spoken with a particular character, based on their gossip ID.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "HasSpokenWith(gossip)";
            // 
            // btnBrowseGossips
            // 
            this.btnBrowseGossips.Location = new System.Drawing.Point(257, 51);
            this.btnBrowseGossips.Name = "btnBrowseGossips";
            this.btnBrowseGossips.Size = new System.Drawing.Size(38, 28);
            this.btnBrowseGossips.TabIndex = 20;
            this.btnBrowseGossips.Text = "...";
            this.btnBrowseGossips.UseVisualStyleBackColor = true;
            this.btnBrowseGossips.Click += new System.EventHandler(this.btnBrowseSections_Click);
            // 
            // cmbGossips
            // 
            this.cmbGossips.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGossips.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbGossips.FormattingEnabled = true;
            this.cmbGossips.Location = new System.Drawing.Point(85, 51);
            this.cmbGossips.Name = "cmbGossips";
            this.cmbGossips.Size = new System.Drawing.Size(166, 28);
            this.cmbGossips.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gossip:";
            // 
            // HasSpokenWith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseGossips);
            this.Controls.Add(this.cmbGossips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "HasSpokenWith";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseGossips;
        private System.Windows.Forms.ComboBox cmbGossips;
        private System.Windows.Forms.Label label2;
    }
}
