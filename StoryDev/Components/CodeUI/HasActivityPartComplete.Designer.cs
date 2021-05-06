
namespace StoryDev.Components.CodeUI
{
    partial class HasActivityPartComplete
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
            this.cmbParts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseActivities = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbActivities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbParts
            // 
            this.cmbParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParts.FormattingEnabled = true;
            this.cmbParts.Location = new System.Drawing.Point(387, 51);
            this.cmbParts.Name = "cmbParts";
            this.cmbParts.Size = new System.Drawing.Size(106, 28);
            this.cmbParts.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Part:";
            // 
            // btnBrowseActivities
            // 
            this.btnBrowseActivities.Location = new System.Drawing.Point(292, 50);
            this.btnBrowseActivities.Name = "btnBrowseActivities";
            this.btnBrowseActivities.Size = new System.Drawing.Size(41, 28);
            this.btnBrowseActivities.TabIndex = 18;
            this.btnBrowseActivities.Text = "...";
            this.btnBrowseActivities.UseVisualStyleBackColor = true;
            this.btnBrowseActivities.Click += new System.EventHandler(this.btnBrowseActivities_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 17;
            this.label4.Text = "Has the given specific activity part been complete.";
            // 
            // cmbActivities
            // 
            this.cmbActivities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbActivities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbActivities.FormattingEnabled = true;
            this.cmbActivities.Location = new System.Drawing.Point(85, 50);
            this.cmbActivities.Name = "cmbActivities";
            this.cmbActivities.Size = new System.Drawing.Size(201, 28);
            this.cmbActivities.TabIndex = 16;
            this.cmbActivities.SelectedIndexChanged += new System.EventHandler(this.cmbActivities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "HasActivityPartComplete(id, part_index)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Activity:";
            // 
            // HasActivityPartComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseActivities);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbActivities);
            this.Controls.Add(this.label1);
            this.Name = "HasActivityPartComplete";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseActivities;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
