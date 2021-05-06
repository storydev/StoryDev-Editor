
namespace StoryDev.Components.CodeUI
{
    partial class HasScenarioCompleted
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
            this.cmbScenarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseScenarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(796, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Has the player completed the given scenario from a special feature.";
            // 
            // cmbScenarios
            // 
            this.cmbScenarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbScenarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbScenarios.FormattingEnabled = true;
            this.cmbScenarios.Location = new System.Drawing.Point(99, 50);
            this.cmbScenarios.Name = "cmbScenarios";
            this.cmbScenarios.Size = new System.Drawing.Size(166, 28);
            this.cmbScenarios.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scenario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "HasScenarioCompleted(id)";
            // 
            // btnBrowseScenarios
            // 
            this.btnBrowseScenarios.Location = new System.Drawing.Point(271, 50);
            this.btnBrowseScenarios.Name = "btnBrowseScenarios";
            this.btnBrowseScenarios.Size = new System.Drawing.Size(38, 28);
            this.btnBrowseScenarios.TabIndex = 12;
            this.btnBrowseScenarios.Text = "...";
            this.btnBrowseScenarios.UseVisualStyleBackColor = true;
            this.btnBrowseScenarios.Click += new System.EventHandler(this.btnBrowseScenarios_Click);
            // 
            // HasScenarioCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowseScenarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbScenarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HasScenarioCompleted";
            this.Size = new System.Drawing.Size(830, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbScenarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseScenarios;
    }
}
