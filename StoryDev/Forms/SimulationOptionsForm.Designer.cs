
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Frequency");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ConversationCharacters");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("CharacterPointOfView");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CurrentConversationID");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("CurrentConversationPosition");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("CurrentPlace");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("CurrentSection");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("CurrentSpecialConvoID");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("CurrentSpecialConversationPosition");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("CurrentSpecialPlace");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("CurrentSpecialSection");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Characters");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("ItemID");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Quantity");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Inventories", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("FragmentsDiscovered");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("ArtefactsUnlocked");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("ArtefactsActivated");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Artefacts", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Characters");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Attitudes");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("HungerLevel");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("ThirstLevel");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("PhysicalLevel");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("MentalLevel");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("AttitudesTowards");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Traits");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("TraitProgress");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Characters", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("PlacesUnlocked");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("SectionsAccessible");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("GossipsAvailable");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("GossipOptionsAvailable");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("GossipOptionsHidden");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Places", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("AchievementsUnlocked");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("JournalsUnlocked");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("JournalsAvailable");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("JournalsInactive");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("JournalsCompleted");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("JournalPagesCompleted");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Journals", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("SpecialScenariosUnlocked");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("SpecialScenariosCompleted");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("SpecialScenarioScores");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("SpecialScenarios", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("PlayerState", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode15,
            treeNode19,
            treeNode29,
            treeNode35,
            treeNode36,
            treeNode42,
            treeNode46});
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtStateRecordingsFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudWorstOutcomePriority = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBestOutcomePriority = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chbResimulate = new System.Windows.Forms.CheckBox();
            this.chbEnableSimulationsStartup = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRecordDetails = new System.Windows.Forms.Panel();
            this.chbSaveStateChange = new System.Windows.Forms.CheckBox();
            this.tvRecordingDetails = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.chbStateRecording = new System.Windows.Forms.CheckBox();
            this.cmbStateTemplates = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.btnBrowse.Location = new System.Drawing.Point(488, 194);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(97, 32);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtStateRecordingsFolder
            // 
            this.txtStateRecordingsFolder.Location = new System.Drawing.Point(221, 197);
            this.txtStateRecordingsFolder.Name = "txtStateRecordingsFolder";
            this.txtStateRecordingsFolder.Size = new System.Drawing.Size(261, 26);
            this.txtStateRecordingsFolder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "State Recordings Folder:";
            // 
            // nudWorstOutcomePriority
            // 
            this.nudWorstOutcomePriority.Location = new System.Drawing.Point(259, 149);
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
            this.label2.Location = new System.Drawing.Point(29, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Worst Outcome Priority Level:";
            // 
            // nudBestOutcomePriority
            // 
            this.nudBestOutcomePriority.Location = new System.Drawing.Point(259, 109);
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
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Best Outcome Priority Level:";
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
            this.toolTip1.SetToolTip(this.chbResimulate, "Every time a new file is opened, re-simulate up to that point based on story orde" +
        "r.");
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
            this.toolTip1.SetToolTip(this.chbEnableSimulationsStartup, "When the conversations window is opened, open the Simulation system with it.");
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
            this.pnlRecordDetails.Controls.Add(this.chbSaveStateChange);
            this.pnlRecordDetails.Location = new System.Drawing.Point(403, 28);
            this.pnlRecordDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRecordDetails.Name = "pnlRecordDetails";
            this.pnlRecordDetails.Size = new System.Drawing.Size(383, 411);
            this.pnlRecordDetails.TabIndex = 5;
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
            treeNode1.Name = "Node1";
            treeNode1.Text = "Frequency";
            treeNode2.Name = "Node0";
            treeNode2.Text = "ConversationCharacters";
            treeNode3.Name = "Node1";
            treeNode3.Text = "CharacterPointOfView";
            treeNode4.Name = "Node2";
            treeNode4.Text = "CurrentConversationID";
            treeNode5.Name = "Node3";
            treeNode5.Text = "CurrentConversationPosition";
            treeNode6.Name = "Node4";
            treeNode6.Text = "CurrentPlace";
            treeNode7.Name = "Node5";
            treeNode7.Text = "CurrentSection";
            treeNode8.Name = "Node6";
            treeNode8.Text = "CurrentSpecialConvoID";
            treeNode9.Name = "Node7";
            treeNode9.Text = "CurrentSpecialConversationPosition";
            treeNode10.Name = "Node8";
            treeNode10.Text = "CurrentSpecialPlace";
            treeNode11.Name = "Node9";
            treeNode11.Text = "CurrentSpecialSection";
            treeNode12.Name = "Node17";
            treeNode12.Text = "Characters";
            treeNode13.Name = "Node18";
            treeNode13.Text = "ItemID";
            treeNode14.Name = "Node19";
            treeNode14.Text = "Quantity";
            treeNode15.Name = "Node10";
            treeNode15.Text = "Inventories";
            treeNode16.Name = "Node20";
            treeNode16.Text = "FragmentsDiscovered";
            treeNode17.Name = "Node21";
            treeNode17.Text = "ArtefactsUnlocked";
            treeNode18.Name = "Node22";
            treeNode18.Text = "ArtefactsActivated";
            treeNode19.Name = "Node11";
            treeNode19.Text = "Artefacts";
            treeNode20.Name = "Node23";
            treeNode20.Text = "Characters";
            treeNode21.Name = "Node24";
            treeNode21.Text = "Attitudes";
            treeNode22.Name = "Node25";
            treeNode22.Text = "HungerLevel";
            treeNode23.Name = "Node26";
            treeNode23.Text = "ThirstLevel";
            treeNode24.Name = "Node27";
            treeNode24.Text = "PhysicalLevel";
            treeNode25.Name = "Node28";
            treeNode25.Text = "MentalLevel";
            treeNode26.Name = "Node29";
            treeNode26.Text = "AttitudesTowards";
            treeNode27.Name = "Node30";
            treeNode27.Text = "Traits";
            treeNode28.Name = "Node31";
            treeNode28.Text = "TraitProgress";
            treeNode29.Name = "Node12";
            treeNode29.Text = "Characters";
            treeNode30.Name = "Node0";
            treeNode30.Text = "PlacesUnlocked";
            treeNode31.Name = "Node1";
            treeNode31.Text = "SectionsAccessible";
            treeNode32.Name = "Node2";
            treeNode32.Text = "GossipsAvailable";
            treeNode33.Name = "Node3";
            treeNode33.Text = "GossipOptionsAvailable";
            treeNode34.Name = "Node4";
            treeNode34.Text = "GossipOptionsHidden";
            treeNode35.Name = "Node13";
            treeNode35.Text = "Places";
            treeNode36.Name = "Node14";
            treeNode36.Text = "AchievementsUnlocked";
            treeNode37.Name = "Node5";
            treeNode37.Text = "JournalsUnlocked";
            treeNode38.Name = "Node6";
            treeNode38.Text = "JournalsAvailable";
            treeNode39.Name = "Node7";
            treeNode39.Text = "JournalsInactive";
            treeNode40.Name = "Node8";
            treeNode40.Text = "JournalsCompleted";
            treeNode41.Name = "Node9";
            treeNode41.Text = "JournalPagesCompleted";
            treeNode42.Name = "Node15";
            treeNode42.Text = "Journals";
            treeNode43.Name = "Node10";
            treeNode43.Text = "SpecialScenariosUnlocked";
            treeNode44.Name = "Node11";
            treeNode44.Text = "SpecialScenariosCompleted";
            treeNode45.Name = "Node12";
            treeNode45.Text = "SpecialScenarioScores";
            treeNode46.Name = "Node16";
            treeNode46.Text = "SpecialScenarios";
            treeNode47.Name = "Node0";
            treeNode47.Text = "PlayerState";
            this.tvRecordingDetails.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode47});
            this.tvRecordingDetails.PathSeparator = ".";
            this.tvRecordingDetails.Size = new System.Drawing.Size(379, 409);
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
        private System.Windows.Forms.CheckBox chbResimulate;
        private System.Windows.Forms.CheckBox chbEnableSimulationsStartup;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvRecordingDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbStateRecording;
        private System.Windows.Forms.Panel pnlRecordDetails;
        private System.Windows.Forms.CheckBox chbSaveStateChange;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtStateRecordingsFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStateTemplates;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}