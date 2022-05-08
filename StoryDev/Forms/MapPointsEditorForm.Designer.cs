namespace StoryDev.Forms
{
    partial class MapPointsEditorForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbRemovePoints = new System.Windows.Forms.RadioButton();
            this.rdbAddPoints = new System.Windows.Forms.RadioButton();
            this.rdbSelect = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbPoints = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProperties = new System.Windows.Forms.Label();
            this.tcProperties = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlBasic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPointType = new System.Windows.Forms.ComboBox();
            this.pnlMapOptions = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tcProperties.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlBasic.SuspendLayout();
            this.pnlMapOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1453, 964);
            this.splitContainer1.SplitterDistance = 1099;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 964);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbRemovePoints);
            this.panel2.Controls.Add(this.rdbAddPoints);
            this.panel2.Controls.Add(this.rdbSelect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(350, 40);
            this.panel2.TabIndex = 0;
            // 
            // rdbRemovePoints
            // 
            this.rdbRemovePoints.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbRemovePoints.AutoSize = true;
            this.rdbRemovePoints.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbRemovePoints.Location = new System.Drawing.Point(164, 4);
            this.rdbRemovePoints.Name = "rdbRemovePoints";
            this.rdbRemovePoints.Size = new System.Drawing.Size(126, 32);
            this.rdbRemovePoints.TabIndex = 2;
            this.rdbRemovePoints.Text = "Remove Points";
            this.rdbRemovePoints.UseVisualStyleBackColor = true;
            // 
            // rdbAddPoints
            // 
            this.rdbAddPoints.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAddPoints.AutoSize = true;
            this.rdbAddPoints.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbAddPoints.Location = new System.Drawing.Point(68, 4);
            this.rdbAddPoints.Name = "rdbAddPoints";
            this.rdbAddPoints.Size = new System.Drawing.Size(96, 32);
            this.rdbAddPoints.TabIndex = 1;
            this.rdbAddPoints.Text = "Add Points";
            this.rdbAddPoints.UseVisualStyleBackColor = true;
            // 
            // rdbSelect
            // 
            this.rdbSelect.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbSelect.AutoSize = true;
            this.rdbSelect.Checked = true;
            this.rdbSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdbSelect.Location = new System.Drawing.Point(4, 4);
            this.rdbSelect.Name = "rdbSelect";
            this.rdbSelect.Size = new System.Drawing.Size(64, 32);
            this.rdbSelect.TabIndex = 0;
            this.rdbSelect.TabStop = true;
            this.rdbSelect.Text = "Select";
            this.rdbSelect.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbPoints);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 411);
            this.panel3.TabIndex = 1;
            // 
            // lbPoints
            // 
            this.lbPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPoints.FormattingEnabled = true;
            this.lbPoints.ItemHeight = 20;
            this.lbPoints.Location = new System.Drawing.Point(0, 0);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(350, 411);
            this.lbPoints.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tcProperties);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 451);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 513);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblProperties);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 38);
            this.panel5.TabIndex = 0;
            // 
            // lblProperties
            // 
            this.lblProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.Location = new System.Drawing.Point(0, 0);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(350, 38);
            this.lblProperties.TabIndex = 0;
            this.lblProperties.Text = "Properties";
            this.lblProperties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcProperties
            // 
            this.tcProperties.Controls.Add(this.tabPage1);
            this.tcProperties.Controls.Add(this.tabPage2);
            this.tcProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProperties.Location = new System.Drawing.Point(0, 38);
            this.tcProperties.Name = "tcProperties";
            this.tcProperties.SelectedIndex = 0;
            this.tcProperties.Size = new System.Drawing.Size(350, 475);
            this.tcProperties.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlBasic);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlBasic
            // 
            this.pnlBasic.Controls.Add(this.pnlMapOptions);
            this.pnlBasic.Controls.Add(this.cmbPointType);
            this.pnlBasic.Controls.Add(this.label1);
            this.pnlBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBasic.Enabled = false;
            this.pnlBasic.Location = new System.Drawing.Point(3, 3);
            this.pnlBasic.Name = "pnlBasic";
            this.pnlBasic.Size = new System.Drawing.Size(336, 436);
            this.pnlBasic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point Type:";
            // 
            // cmbPointType
            // 
            this.cmbPointType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPointType.FormattingEnabled = true;
            this.cmbPointType.Items.AddRange(new object[] {
            "Standard",
            "Move Map",
            "To Interior",
            "Object"});
            this.cmbPointType.Location = new System.Drawing.Point(113, 18);
            this.cmbPointType.Name = "cmbPointType";
            this.cmbPointType.Size = new System.Drawing.Size(197, 28);
            this.cmbPointType.TabIndex = 1;
            // 
            // pnlMapOptions
            // 
            this.pnlMapOptions.Controls.Add(this.cmb);
            this.pnlMapOptions.Controls.Add(this.label2);
            this.pnlMapOptions.Location = new System.Drawing.Point(3, 52);
            this.pnlMapOptions.Name = "pnlMapOptions";
            this.pnlMapOptions.Size = new System.Drawing.Size(328, 41);
            this.pnlMapOptions.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "To Map:";
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(75, 8);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(205, 28);
            this.cmb.TabIndex = 1;
            // 
            // MapPointsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 964);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MapPointsEditorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Points Editor";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tcProperties.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlBasic.ResumeLayout(false);
            this.pnlBasic.PerformLayout();
            this.pnlMapOptions.ResumeLayout(false);
            this.pnlMapOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbRemovePoints;
        private System.Windows.Forms.RadioButton rdbAddPoints;
        private System.Windows.Forms.RadioButton rdbSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tcProperties;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlBasic;
        private System.Windows.Forms.ComboBox cmbPointType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbPoints;
        private System.Windows.Forms.Panel pnlMapOptions;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label2;
    }
}