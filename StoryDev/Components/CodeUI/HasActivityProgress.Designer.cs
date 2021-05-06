
namespace StoryDev.Components.CodeUI
{
    partial class HasActivityProgress
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
            this.cmbActivities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseActivities = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProgress = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Has the given activity been progressed by a certain value or greater.";
            // 
            // cmbActivities
            // 
            this.cmbActivities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbActivities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbActivities.FormattingEnabled = true;
            this.cmbActivities.Location = new System.Drawing.Point(85, 50);
            this.cmbActivities.Name = "cmbActivities";
            this.cmbActivities.Size = new System.Drawing.Size(201, 28);
            this.cmbActivities.TabIndex = 8;
            this.cmbActivities.SelectedIndexChanged += new System.EventHandler(this.cmbActivities_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Activity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "HasActivityProgress(id, progress)";
            // 
            // btnBrowseActivities
            // 
            this.btnBrowseActivities.Location = new System.Drawing.Point(292, 50);
            this.btnBrowseActivities.Name = "btnBrowseActivities";
            this.btnBrowseActivities.Size = new System.Drawing.Size(41, 28);
            this.btnBrowseActivities.TabIndex = 12;
            this.btnBrowseActivities.Text = "...";
            this.btnBrowseActivities.UseVisualStyleBackColor = true;
            this.btnBrowseActivities.Click += new System.EventHandler(this.btnBrowseActivities_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Progress (>=):";
            // 
            // cmbProgress
            // 
            this.cmbProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgress.FormattingEnabled = true;
            this.cmbProgress.Location = new System.Drawing.Point(453, 51);
            this.cmbProgress.Name = "cmbProgress";
            this.cmbProgress.Size = new System.Drawing.Size(106, 28);
            this.cmbProgress.TabIndex = 14;
            // 
            // HasActivityProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseActivities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbActivities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HasActivityProgress";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbActivities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseActivities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProgress;
    }
}
