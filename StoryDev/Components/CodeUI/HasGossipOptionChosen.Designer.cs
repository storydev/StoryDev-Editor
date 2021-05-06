
namespace StoryDev.Components.CodeUI
{
    partial class HasGossipOptionChosen
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
            this.btnBrowseGossips = new System.Windows.Forms.Button();
            this.cmbGossips = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGossipOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBrowseGossips
            // 
            this.btnBrowseGossips.Location = new System.Drawing.Point(258, 51);
            this.btnBrowseGossips.Name = "btnBrowseGossips";
            this.btnBrowseGossips.Size = new System.Drawing.Size(38, 28);
            this.btnBrowseGossips.TabIndex = 25;
            this.btnBrowseGossips.Text = "...";
            this.btnBrowseGossips.UseVisualStyleBackColor = true;
            this.btnBrowseGossips.Click += new System.EventHandler(this.btnBrowseGossips_Click);
            // 
            // cmbGossips
            // 
            this.cmbGossips.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGossips.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbGossips.FormattingEnabled = true;
            this.cmbGossips.Location = new System.Drawing.Point(86, 51);
            this.cmbGossips.Name = "cmbGossips";
            this.cmbGossips.Size = new System.Drawing.Size(166, 28);
            this.cmbGossips.TabIndex = 24;
            this.cmbGossips.SelectedIndexChanged += new System.EventHandler(this.cmbGossips_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Gossip:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 22;
            this.label4.Text = "Has the player chosen the given gossip option with the given gossip.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "HasGossipOptionChosen(gossip, index)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Option:";
            // 
            // cmbGossipOptions
            // 
            this.cmbGossipOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGossipOptions.FormattingEnabled = true;
            this.cmbGossipOptions.Location = new System.Drawing.Point(368, 51);
            this.cmbGossipOptions.Name = "cmbGossipOptions";
            this.cmbGossipOptions.Size = new System.Drawing.Size(196, 28);
            this.cmbGossipOptions.TabIndex = 27;
            // 
            // HasGossipOptionChosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbGossipOptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseGossips);
            this.Controls.Add(this.cmbGossips);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "HasGossipOptionChosen";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseGossips;
        private System.Windows.Forms.ComboBox cmbGossips;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGossipOptions;
    }
}
