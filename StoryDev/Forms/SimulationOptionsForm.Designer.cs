
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
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Frequency");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("ConversationCharacters");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("CharacterPointOfView");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("CurrentConversationID");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("CurrentConversationPosition");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("CurrentPlace");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("CurrentSection");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("CurrentSpecialConvoID");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("CurrentSpecialConversationPosition");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("CurrentSpecialPlace");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("CurrentSpecialSection");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Characters");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("ItemID");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Quantity");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Inventories", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("FragmentsDiscovered");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("ArtefactsUnlocked");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("ArtefactsActivated");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Artefacts", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Characters");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Attitudes");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("HungerLevel");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("ThirstLevel");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("PhysicalLevel");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("MentalLevel");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("AttitudesTowards");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Traits");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("TraitProgress");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Characters", new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62});
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Places");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("AchievementsUnlocked");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Journals");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("SpecialScenarios");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Player State", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode49,
            treeNode53,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67});
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtStateRecordingsFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWorstOutcomePriority = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBestOutcomePriority = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStateInterval = new System.Windows.Forms.ComboBox();
            this.chbRecordStateInterval = new System.Windows.Forms.CheckBox();
            this.chbResimulate = new System.Windows.Forms.CheckBox();
            this.chbEnableSimulationsStartup = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRecordDetails = new System.Windows.Forms.Panel();
            this.chbShowDetailed = new System.Windows.Forms.CheckBox();
            this.chbSaveStateChange = new System.Windows.Forms.CheckBox();
            this.tvRecordingDetails = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.chbStateRecording = new System.Windows.Forms.CheckBox();
            this.cmbStateTemplates = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
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
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(840, 577);
            this.tcMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.txtStateRecordingsFolder);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.nudWorstOutcomePriority);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudBestOutcomePriority);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbStateInterval);
            this.tabPage1.Controls.Add(this.chbRecordStateInterval);
            this.tabPage1.Controls.Add(this.chbResimulate);
            this.tabPage1.Controls.Add(this.chbEnableSimulationsStartup);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(832, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(488, 268);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 32);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtStateRecordingsFolder
            // 
            this.txtStateRecordingsFolder.Location = new System.Drawing.Point(221, 271);
            this.txtStateRecordingsFolder.Name = "txtStateRecordingsFolder";
            this.txtStateRecordingsFolder.Size = new System.Drawing.Size(261, 26);
            this.txtStateRecordingsFolder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "State Recordings Folder:";
            // 
            // nudWorstOutcomePriority
            // 
            this.nudWorstOutcomePriority.Location = new System.Drawing.Point(259, 223);
            this.nudWorstOutcomePriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nudWorstOutcomePriority.Size = new System.Drawing.Size(98, 26);
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
            this.label2.Location = new System.Drawing.Point(29, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Worst Outcome Priority Level:";
            // 
            // nudBestOutcomePriority
            // 
            this.nudBestOutcomePriority.Location = new System.Drawing.Point(259, 183);
            this.nudBestOutcomePriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nudBestOutcomePriority.Size = new System.Drawing.Size(98, 26);
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
            this.label1.Location = new System.Drawing.Point(29, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
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
            this.cmbStateInterval.Location = new System.Drawing.Point(117, 135);
            this.cmbStateInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStateInterval.Name = "cmbStateInterval";
            this.cmbStateInterval.Size = new System.Drawing.Size(180, 28);
            this.cmbStateInterval.TabIndex = 3;
            // 
            // chbRecordStateInterval
            // 
            this.chbRecordStateInterval.AutoSize = true;
            this.chbRecordStateInterval.Location = new System.Drawing.Point(33, 100);
            this.chbRecordStateInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbRecordStateInterval.Name = "chbRecordStateInterval";
            this.chbRecordStateInterval.Size = new System.Drawing.Size(215, 24);
            this.chbRecordStateInterval.TabIndex = 2;
            this.chbRecordStateInterval.Text = "Set Record State Interval";
            this.chbRecordStateInterval.UseVisualStyleBackColor = true;
            // 
            // chbResimulate
            // 
            this.chbResimulate.AutoSize = true;
            this.chbResimulate.Location = new System.Drawing.Point(33, 65);
            this.chbResimulate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbResimulate.Name = "chbResimulate";
            this.chbResimulate.Size = new System.Drawing.Size(247, 24);
            this.chbResimulate.TabIndex = 1;
            this.chbResimulate.Text = "Re-simulate on every file open";
            this.chbResimulate.UseVisualStyleBackColor = true;
            // 
            // chbEnableSimulationsStartup
            // 
            this.chbEnableSimulationsStartup.AutoSize = true;
            this.chbEnableSimulationsStartup.Location = new System.Drawing.Point(33, 29);
            this.chbEnableSimulationsStartup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbEnableSimulationsStartup.Name = "chbEnableSimulationsStartup";
            this.chbEnableSimulationsStartup.Size = new System.Drawing.Size(347, 24);
            this.chbEnableSimulationsStartup.TabIndex = 0;
            this.chbEnableSimulationsStartup.Text = "Enable Simulations on Conversation Startup";
            this.chbEnableSimulationsStartup.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteTemplate);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbStateTemplates);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.chbStateRecording);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(832, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "State";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRecordDetails);
            this.panel1.Controls.Add(this.tvRecordingDetails);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 463);
            this.panel1.TabIndex = 1;
            // 
            // pnlRecordDetails
            // 
            this.pnlRecordDetails.Controls.Add(this.chbShowDetailed);
            this.pnlRecordDetails.Controls.Add(this.chbSaveStateChange);
            this.pnlRecordDetails.Enabled = false;
            this.pnlRecordDetails.Location = new System.Drawing.Point(260, 28);
            this.pnlRecordDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRecordDetails.Name = "pnlRecordDetails";
            this.pnlRecordDetails.Size = new System.Drawing.Size(526, 411);
            this.pnlRecordDetails.TabIndex = 5;
            // 
            // chbShowDetailed
            // 
            this.chbShowDetailed.AutoSize = true;
            this.chbShowDetailed.Location = new System.Drawing.Point(30, 52);
            this.chbShowDetailed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbShowDetailed.Name = "chbShowDetailed";
            this.chbShowDetailed.Size = new System.Drawing.Size(138, 24);
            this.chbShowDetailed.TabIndex = 1;
            this.chbShowDetailed.Text = "Show Detailed";
            this.chbShowDetailed.UseVisualStyleBackColor = true;
            // 
            // chbSaveStateChange
            // 
            this.chbSaveStateChange.AutoSize = true;
            this.chbSaveStateChange.Location = new System.Drawing.Point(30, 18);
            this.chbSaveStateChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbSaveStateChange.Name = "chbSaveStateChange";
            this.chbSaveStateChange.Size = new System.Drawing.Size(202, 24);
            this.chbSaveStateChange.TabIndex = 0;
            this.chbSaveStateChange.Text = "Save State Per Change";
            this.chbSaveStateChange.UseVisualStyleBackColor = true;
            // 
            // tvRecordingDetails
            // 
            this.tvRecordingDetails.CheckBoxes = true;
            this.tvRecordingDetails.Location = new System.Drawing.Point(16, 28);
            this.tvRecordingDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tvRecordingDetails.Name = "tvRecordingDetails";
            treeNode35.Checked = true;
            treeNode35.Name = "Node1";
            treeNode35.Text = "Frequency";
            treeNode36.Name = "Node0";
            treeNode36.Text = "ConversationCharacters";
            treeNode37.Name = "Node1";
            treeNode37.Text = "CharacterPointOfView";
            treeNode38.Name = "Node2";
            treeNode38.Text = "CurrentConversationID";
            treeNode39.Name = "Node3";
            treeNode39.Text = "CurrentConversationPosition";
            treeNode40.Name = "Node4";
            treeNode40.Text = "CurrentPlace";
            treeNode41.Name = "Node5";
            treeNode41.Text = "CurrentSection";
            treeNode42.Name = "Node6";
            treeNode42.Text = "CurrentSpecialConvoID";
            treeNode43.Name = "Node7";
            treeNode43.Text = "CurrentSpecialConversationPosition";
            treeNode44.Name = "Node8";
            treeNode44.Text = "CurrentSpecialPlace";
            treeNode45.Name = "Node9";
            treeNode45.Text = "CurrentSpecialSection";
            treeNode46.Name = "Node17";
            treeNode46.Text = "Characters";
            treeNode47.Name = "Node18";
            treeNode47.Text = "ItemID";
            treeNode48.Name = "Node19";
            treeNode48.Text = "Quantity";
            treeNode49.Name = "Node10";
            treeNode49.Text = "Inventories";
            treeNode50.Name = "Node20";
            treeNode50.Text = "FragmentsDiscovered";
            treeNode51.Name = "Node21";
            treeNode51.Text = "ArtefactsUnlocked";
            treeNode52.Name = "Node22";
            treeNode52.Text = "ArtefactsActivated";
            treeNode53.Name = "Node11";
            treeNode53.Text = "Artefacts";
            treeNode54.Name = "Node23";
            treeNode54.Text = "Characters";
            treeNode55.Name = "Node24";
            treeNode55.Text = "Attitudes";
            treeNode56.Name = "Node25";
            treeNode56.Text = "HungerLevel";
            treeNode57.Name = "Node26";
            treeNode57.Text = "ThirstLevel";
            treeNode58.Name = "Node27";
            treeNode58.Text = "PhysicalLevel";
            treeNode59.Name = "Node28";
            treeNode59.Text = "MentalLevel";
            treeNode60.Name = "Node29";
            treeNode60.Text = "AttitudesTowards";
            treeNode61.Name = "Node30";
            treeNode61.Text = "Traits";
            treeNode62.Name = "Node31";
            treeNode62.Text = "TraitProgress";
            treeNode63.Name = "Node12";
            treeNode63.Text = "Characters";
            treeNode64.Name = "Node13";
            treeNode64.Text = "Places";
            treeNode65.Name = "Node14";
            treeNode65.Text = "AchievementsUnlocked";
            treeNode66.Name = "Node15";
            treeNode66.Text = "Journals";
            treeNode67.Name = "Node16";
            treeNode67.Text = "SpecialScenarios";
            treeNode68.Name = "Node0";
            treeNode68.Text = "Player State";
            this.tvRecordingDetails.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode68});
            this.tvRecordingDetails.PathSeparator = ".";
            this.tvRecordingDetails.ShowRootLines = false;
            this.tvRecordingDetails.Size = new System.Drawing.Size(232, 409);
            this.tvRecordingDetails.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recording Details";
            // 
            // chbStateRecording
            // 
            this.chbStateRecording.AutoSize = true;
            this.chbStateRecording.Location = new System.Drawing.Point(28, 26);
            this.chbStateRecording.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbStateRecording.Name = "chbStateRecording";
            this.chbStateRecording.Size = new System.Drawing.Size(205, 24);
            this.chbStateRecording.TabIndex = 0;
            this.chbStateRecording.Text = "Enable State Recording";
            this.chbStateRecording.UseVisualStyleBackColor = true;
            // 
            // cmbStateTemplates
            // 
            this.cmbStateTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStateTemplates.FormattingEnabled = true;
            this.cmbStateTemplates.Location = new System.Drawing.Point(551, 26);
            this.cmbStateTemplates.Name = "cmbStateTemplates";
            this.cmbStateTemplates.Size = new System.Drawing.Size(169, 28);
            this.cmbStateTemplates.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Templates:";
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.Location = new System.Drawing.Point(726, 26);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(90, 28);
            this.btnDeleteTemplate.TabIndex = 4;
            this.btnDeleteTemplate.Text = "Delete";
            this.btnDeleteTemplate.UseVisualStyleBackColor = true;
            // 
            // SimulationOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 577);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvRecordingDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbStateRecording;
        private System.Windows.Forms.Panel pnlRecordDetails;
        private System.Windows.Forms.CheckBox chbSaveStateChange;
        private System.Windows.Forms.CheckBox chbShowDetailed;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtStateRecordingsFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStateTemplates;
    }
}