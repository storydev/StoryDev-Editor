
namespace StoryDev.Forms
{
    partial class SimulationOptionsForm
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Frequency");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("CurrentParty");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Inventory");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Achievements");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("CurrentPlace");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Player State", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudWorstOutcomePriority = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBestOutcomePriority = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStateInterval = new System.Windows.Forms.ComboBox();
            this.chbRecordStateInterval = new System.Windows.Forms.CheckBox();
            this.chbResimulate = new System.Windows.Forms.CheckBox();
            this.chbEnableSimulationsStartup = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvRecordingDetails = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.chbStateRecording = new System.Windows.Forms.CheckBox();
            this.pnlRecordDetails = new System.Windows.Forms.Panel();
            this.chbSaveStateChange = new System.Windows.Forms.CheckBox();
            this.chbShowDetailed = new System.Windows.Forms.CheckBox();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorstOutcomePriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBestOutcomePriority)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlRecordDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(560, 375);
            this.tcMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nudWorstOutcomePriority);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudBestOutcomePriority);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbStateInterval);
            this.tabPage1.Controls.Add(this.chbRecordStateInterval);
            this.tabPage1.Controls.Add(this.chbResimulate);
            this.tabPage1.Controls.Add(this.chbEnableSimulationsStartup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudWorstOutcomePriority
            // 
            this.nudWorstOutcomePriority.Location = new System.Drawing.Point(172, 145);
            this.nudWorstOutcomePriority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWorstOutcomePriority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWorstOutcomePriority.Name = "nudWorstOutcomePriority";
            this.nudWorstOutcomePriority.Size = new System.Drawing.Size(65, 20);
            this.nudWorstOutcomePriority.TabIndex = 7;
            this.nudWorstOutcomePriority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Worst Outcome Priority Level:";
            // 
            // nudBestOutcomePriority
            // 
            this.nudBestOutcomePriority.Location = new System.Drawing.Point(172, 119);
            this.nudBestOutcomePriority.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBestOutcomePriority.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBestOutcomePriority.Name = "nudBestOutcomePriority";
            this.nudBestOutcomePriority.Size = new System.Drawing.Size(65, 20);
            this.nudBestOutcomePriority.TabIndex = 5;
            this.nudBestOutcomePriority.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Best Outcome Priority Level:";
            // 
            // cmbStateInterval
            // 
            this.cmbStateInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateInterval.Enabled = false;
            this.cmbStateInterval.FormattingEnabled = true;
            this.cmbStateInterval.Items.AddRange(new object[] {
            "Per Conversation",
            "Per Choice",
            "On Branch Click"});
            this.cmbStateInterval.Location = new System.Drawing.Point(78, 88);
            this.cmbStateInterval.Name = "cmbStateInterval";
            this.cmbStateInterval.Size = new System.Drawing.Size(121, 21);
            this.cmbStateInterval.TabIndex = 3;
            // 
            // chbRecordStateInterval
            // 
            this.chbRecordStateInterval.AutoSize = true;
            this.chbRecordStateInterval.Location = new System.Drawing.Point(22, 65);
            this.chbRecordStateInterval.Name = "chbRecordStateInterval";
            this.chbRecordStateInterval.Size = new System.Drawing.Size(146, 17);
            this.chbRecordStateInterval.TabIndex = 2;
            this.chbRecordStateInterval.Text = "Set Record State Interval";
            this.chbRecordStateInterval.UseVisualStyleBackColor = true;
            // 
            // chbResimulate
            // 
            this.chbResimulate.AutoSize = true;
            this.chbResimulate.Location = new System.Drawing.Point(22, 42);
            this.chbResimulate.Name = "chbResimulate";
            this.chbResimulate.Size = new System.Drawing.Size(168, 17);
            this.chbResimulate.TabIndex = 1;
            this.chbResimulate.Text = "Re-simulate on every file open";
            this.chbResimulate.UseVisualStyleBackColor = true;
            // 
            // chbEnableSimulationsStartup
            // 
            this.chbEnableSimulationsStartup.AutoSize = true;
            this.chbEnableSimulationsStartup.Location = new System.Drawing.Point(22, 19);
            this.chbEnableSimulationsStartup.Name = "chbEnableSimulationsStartup";
            this.chbEnableSimulationsStartup.Size = new System.Drawing.Size(232, 17);
            this.chbEnableSimulationsStartup.TabIndex = 0;
            this.chbEnableSimulationsStartup.Text = "Enable Simulations on Conversation Startup";
            this.chbEnableSimulationsStartup.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tracking";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.chbStateRecording);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "State";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRecordDetails);
            this.panel1.Controls.Add(this.tvRecordingDetails);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 301);
            this.panel1.TabIndex = 1;
            // 
            // tvRecordingDetails
            // 
            this.tvRecordingDetails.CheckBoxes = true;
            this.tvRecordingDetails.Location = new System.Drawing.Point(11, 18);
            this.tvRecordingDetails.Name = "tvRecordingDetails";
            treeNode13.Checked = true;
            treeNode13.Name = "Node1";
            treeNode13.Text = "Frequency";
            treeNode14.Name = "Node3";
            treeNode14.Text = "CurrentParty";
            treeNode15.Name = "Node4";
            treeNode15.Text = "Inventory";
            treeNode16.Name = "Node5";
            treeNode16.Text = "Achievements";
            treeNode17.Name = "Node6";
            treeNode17.Text = "CurrentPlace";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Player State";
            this.tvRecordingDetails.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.tvRecordingDetails.PathSeparator = "/";
            this.tvRecordingDetails.Size = new System.Drawing.Size(156, 267);
            this.tvRecordingDetails.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recording Details";
            // 
            // chbStateRecording
            // 
            this.chbStateRecording.AutoSize = true;
            this.chbStateRecording.Location = new System.Drawing.Point(19, 17);
            this.chbStateRecording.Name = "chbStateRecording";
            this.chbStateRecording.Size = new System.Drawing.Size(139, 17);
            this.chbStateRecording.TabIndex = 0;
            this.chbStateRecording.Text = "Enable State Recording";
            this.chbStateRecording.UseVisualStyleBackColor = true;
            // 
            // pnlRecordDetails
            // 
            this.pnlRecordDetails.Controls.Add(this.chbShowDetailed);
            this.pnlRecordDetails.Controls.Add(this.chbSaveStateChange);
            this.pnlRecordDetails.Enabled = false;
            this.pnlRecordDetails.Location = new System.Drawing.Point(173, 18);
            this.pnlRecordDetails.Name = "pnlRecordDetails";
            this.pnlRecordDetails.Size = new System.Drawing.Size(351, 267);
            this.pnlRecordDetails.TabIndex = 5;
            // 
            // chbSaveStateChange
            // 
            this.chbSaveStateChange.AutoSize = true;
            this.chbSaveStateChange.Location = new System.Drawing.Point(20, 12);
            this.chbSaveStateChange.Name = "chbSaveStateChange";
            this.chbSaveStateChange.Size = new System.Drawing.Size(138, 17);
            this.chbSaveStateChange.TabIndex = 0;
            this.chbSaveStateChange.Text = "Save State Per Change";
            this.chbSaveStateChange.UseVisualStyleBackColor = true;
            // 
            // chbShowDetailed
            // 
            this.chbShowDetailed.AutoSize = true;
            this.chbShowDetailed.Location = new System.Drawing.Point(20, 35);
            this.chbShowDetailed.Name = "chbShowDetailed";
            this.chbShowDetailed.Size = new System.Drawing.Size(95, 17);
            this.chbShowDetailed.TabIndex = 1;
            this.chbShowDetailed.Text = "Show Detailed";
            this.chbShowDetailed.UseVisualStyleBackColor = true;
            // 
            // SimulationOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 375);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Options";
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWorstOutcomePriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBestOutcomePriority)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRecordDetails.ResumeLayout(false);
            this.pnlRecordDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nudWorstOutcomePriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBestOutcomePriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStateInterval;
        private System.Windows.Forms.CheckBox chbRecordStateInterval;
        private System.Windows.Forms.CheckBox chbResimulate;
        private System.Windows.Forms.CheckBox chbEnableSimulationsStartup;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvRecordingDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbStateRecording;
        private System.Windows.Forms.Panel pnlRecordDetails;
        private System.Windows.Forms.CheckBox chbSaveStateChange;
        private System.Windows.Forms.CheckBox chbShowDetailed;
    }
}