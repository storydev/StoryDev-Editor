
namespace StoryDev.Components.CodeUI
{
    partial class HasJournalProgress
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
            this.cmbJournals = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseJournals = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Has the given journal progressed up to the number of pages given.";
            // 
            // cmbJournals
            // 
            this.cmbJournals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbJournals.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbJournals.FormattingEnabled = true;
            this.cmbJournals.Location = new System.Drawing.Point(88, 50);
            this.cmbJournals.Name = "cmbJournals";
            this.cmbJournals.Size = new System.Drawing.Size(180, 28);
            this.cmbJournals.TabIndex = 8;
            this.cmbJournals.SelectedIndexChanged += new System.EventHandler(this.cmbJournals_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Journal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "HasJournalProgress(id, page)";
            // 
            // btnBrowseJournals
            // 
            this.btnBrowseJournals.Location = new System.Drawing.Point(274, 50);
            this.btnBrowseJournals.Name = "btnBrowseJournals";
            this.btnBrowseJournals.Size = new System.Drawing.Size(38, 28);
            this.btnBrowseJournals.TabIndex = 12;
            this.btnBrowseJournals.Text = "...";
            this.btnBrowseJournals.UseVisualStyleBackColor = true;
            this.btnBrowseJournals.Click += new System.EventHandler(this.btnBrowseJournals_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Page:";
            // 
            // cmbPage
            // 
            this.cmbPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPage.FormattingEnabled = true;
            this.cmbPage.Location = new System.Drawing.Point(374, 50);
            this.cmbPage.Name = "cmbPage";
            this.cmbPage.Size = new System.Drawing.Size(121, 28);
            this.cmbPage.TabIndex = 14;
            // 
            // HasJournalProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseJournals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbJournals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HasJournalProgress";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbJournals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseJournals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPage;
    }
}
