
namespace StoryDev.Components
{
    partial class SpecialFeatureUI
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbAllowFrequencyChanges = new System.Windows.Forms.CheckBox();
            this.chbNewScore = new System.Windows.Forms.CheckBox();
            this.chbRepeatable = new System.Windows.Forms.CheckBox();
            this.nudMaxDifficulty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinDifficulty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chbHasDifficulty = new System.Windows.Forms.CheckBox();
            this.txtFeatureName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbScenarios = new System.Windows.Forms.ListBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStart = new System.Windows.Forms.TabPage();
            this.tpEnd = new System.Windows.Forms.TabPage();
            this.nudDifficulty = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmSaveProperties = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDifficulty)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.chbAllowFrequencyChanges);
            this.panel1.Controls.Add(this.chbNewScore);
            this.panel1.Controls.Add(this.chbRepeatable);
            this.panel1.Controls.Add(this.nudMaxDifficulty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudMinDifficulty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chbHasDifficulty);
            this.panel1.Controls.Add(this.txtFeatureName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 156);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1074, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbAllowFrequencyChanges
            // 
            this.chbAllowFrequencyChanges.AutoSize = true;
            this.chbAllowFrequencyChanges.Location = new System.Drawing.Point(547, 110);
            this.chbAllowFrequencyChanges.Name = "chbAllowFrequencyChanges";
            this.chbAllowFrequencyChanges.Size = new System.Drawing.Size(219, 24);
            this.chbAllowFrequencyChanges.TabIndex = 10;
            this.chbAllowFrequencyChanges.Text = "Allow Frequency Changes";
            this.chbAllowFrequencyChanges.UseVisualStyleBackColor = true;
            this.chbAllowFrequencyChanges.CheckedChanged += new System.EventHandler(this.chbAllowFrequencyChanges_CheckedChanged);
            // 
            // chbNewScore
            // 
            this.chbNewScore.AutoSize = true;
            this.chbNewScore.Location = new System.Drawing.Point(547, 80);
            this.chbNewScore.Name = "chbNewScore";
            this.chbNewScore.Size = new System.Drawing.Size(202, 24);
            this.chbNewScore.TabIndex = 9;
            this.chbNewScore.Text = "Overwrite Lower Scores";
            this.chbNewScore.UseVisualStyleBackColor = true;
            this.chbNewScore.CheckedChanged += new System.EventHandler(this.chbNewScore_CheckedChanged);
            // 
            // chbRepeatable
            // 
            this.chbRepeatable.AutoSize = true;
            this.chbRepeatable.Location = new System.Drawing.Point(547, 50);
            this.chbRepeatable.Name = "chbRepeatable";
            this.chbRepeatable.Size = new System.Drawing.Size(118, 24);
            this.chbRepeatable.TabIndex = 8;
            this.chbRepeatable.Text = "Repeatable";
            this.chbRepeatable.UseVisualStyleBackColor = true;
            this.chbRepeatable.CheckedChanged += new System.EventHandler(this.chbRepeatable_CheckedChanged);
            // 
            // nudMaxDifficulty
            // 
            this.nudMaxDifficulty.Enabled = false;
            this.nudMaxDifficulty.Location = new System.Drawing.Point(428, 117);
            this.nudMaxDifficulty.Name = "nudMaxDifficulty";
            this.nudMaxDifficulty.Size = new System.Drawing.Size(94, 26);
            this.nudMaxDifficulty.TabIndex = 7;
            this.nudMaxDifficulty.ValueChanged += new System.EventHandler(this.nudMaxDifficulty_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max. Difficulty:";
            // 
            // nudMinDifficulty
            // 
            this.nudMinDifficulty.Enabled = false;
            this.nudMinDifficulty.Location = new System.Drawing.Point(428, 85);
            this.nudMinDifficulty.Name = "nudMinDifficulty";
            this.nudMinDifficulty.Size = new System.Drawing.Size(94, 26);
            this.nudMinDifficulty.TabIndex = 5;
            this.nudMinDifficulty.ValueChanged += new System.EventHandler(this.nudMinDifficulty_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min. Difficulty:";
            // 
            // chbHasDifficulty
            // 
            this.chbHasDifficulty.AutoSize = true;
            this.chbHasDifficulty.Location = new System.Drawing.Point(316, 50);
            this.chbHasDifficulty.Name = "chbHasDifficulty";
            this.chbHasDifficulty.Size = new System.Drawing.Size(128, 24);
            this.chbHasDifficulty.TabIndex = 3;
            this.chbHasDifficulty.Text = "Has Difficulty";
            this.chbHasDifficulty.UseVisualStyleBackColor = true;
            this.chbHasDifficulty.CheckedChanged += new System.EventHandler(this.chbHasDifficulty_CheckedChanged);
            // 
            // txtFeatureName
            // 
            this.txtFeatureName.Location = new System.Drawing.Point(74, 48);
            this.txtFeatureName.Name = "txtFeatureName";
            this.txtFeatureName.Size = new System.Drawing.Size(236, 26);
            this.txtFeatureName.TabIndex = 2;
            this.txtFeatureName.TextChanged += new System.EventHandler(this.txtFeatureName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Special Feature Properties";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.lbScenarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 630);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(17, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 31);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbScenarios
            // 
            this.lbScenarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScenarios.FormattingEnabled = true;
            this.lbScenarios.ItemHeight = 20;
            this.lbScenarios.Location = new System.Drawing.Point(17, 43);
            this.lbScenarios.Name = "lbScenarios";
            this.lbScenarios.Size = new System.Drawing.Size(250, 564);
            this.lbScenarios.TabIndex = 0;
            this.lbScenarios.SelectedIndexChanged += new System.EventHandler(this.lbScenarios_SelectedIndexChanged);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Controls.Add(this.nudDifficulty);
            this.pnlContent.Controls.Add(this.label7);
            this.pnlContent.Controls.Add(this.txtDescription);
            this.pnlContent.Controls.Add(this.label6);
            this.pnlContent.Controls.Add(this.txtName);
            this.pnlContent.Controls.Add(this.label5);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Enabled = false;
            this.pnlContent.Location = new System.Drawing.Point(288, 156);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(884, 630);
            this.pnlContent.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tpStart);
            this.tabControl1.Controls.Add(this.tpEnd);
            this.tabControl1.Location = new System.Drawing.Point(95, 288);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 319);
            this.tabControl1.TabIndex = 6;
            // 
            // tpStart
            // 
            this.tpStart.Location = new System.Drawing.Point(4, 29);
            this.tpStart.Name = "tpStart";
            this.tpStart.Padding = new System.Windows.Forms.Padding(3);
            this.tpStart.Size = new System.Drawing.Size(693, 286);
            this.tpStart.TabIndex = 0;
            this.tpStart.Text = "Start Script";
            this.tpStart.UseVisualStyleBackColor = true;
            // 
            // tpEnd
            // 
            this.tpEnd.Location = new System.Drawing.Point(4, 29);
            this.tpEnd.Name = "tpEnd";
            this.tpEnd.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnd.Size = new System.Drawing.Size(693, 286);
            this.tpEnd.TabIndex = 1;
            this.tpEnd.Text = "End Script";
            this.tpEnd.UseVisualStyleBackColor = true;
            // 
            // nudDifficulty
            // 
            this.nudDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudDifficulty.Location = new System.Drawing.Point(514, 256);
            this.nudDifficulty.Name = "nudDifficulty";
            this.nudDifficulty.Size = new System.Drawing.Size(151, 26);
            this.nudDifficulty.TabIndex = 5;
            this.nudDifficulty.ValueChanged += new System.EventHandler(this.nudDifficulty_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Difficulty:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(280, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(385, 159);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(280, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // tmSaveProperties
            // 
            this.tmSaveProperties.Enabled = true;
            this.tmSaveProperties.Interval = 2000;
            this.tmSaveProperties.Tick += new System.EventHandler(this.tmSaveProperties_Tick);
            // 
            // SpecialFeatureUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SpecialFeatureUI";
            this.Size = new System.Drawing.Size(1172, 786);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDifficulty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFeatureName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbHasDifficulty;
        private System.Windows.Forms.NumericUpDown nudMaxDifficulty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinDifficulty;
        private System.Windows.Forms.CheckBox chbRepeatable;
        private System.Windows.Forms.CheckBox chbAllowFrequencyChanges;
        private System.Windows.Forms.CheckBox chbNewScore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox lbScenarios;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpStart;
        private System.Windows.Forms.TabPage tpEnd;
        private System.Windows.Forms.NumericUpDown nudDifficulty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmSaveProperties;
        private System.Windows.Forms.Button btnSave;
    }
}
