
namespace StoryDev.Forms
{
    partial class CodeConstructForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sbtnExecute = new StoryDev.Components.SplitButton();
            this.cmsExecute = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acquireFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acquireArtefactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockArtefactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustCharacterAttitudeTowardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCharacterAttitudeTowardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustGroupAttitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustCharacterAttitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCharacterAttitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustCharacterTraitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustInventoryItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustInventoryCashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockCharacterGossipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideCharacterGossipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sbtnConditions = new StoryDev.Components.SplitButton();
            this.cmsConditional = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hasCharacterAttitudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasCharacterAttitudeTowardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasFrequencyWithGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isCurrentPOVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasArtefactFragmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasArtefactCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasUnlockedPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasActivityProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasActivityPartCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasActivityCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasCharacterTraitProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasJournalProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasJournalCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasItemNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isItemAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasScenarioCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasUnlockedSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isSectionAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isWithinSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasSpokenWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasGossipOptionChosenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isCharacterNourishedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterRequiresHealingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeView = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.cmsExecute.SuspendLayout();
            this.cmsConditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.sbtnExecute);
            this.panel1.Controls.Add(this.sbtnConditions);
            this.panel1.Controls.Add(this.btnChangeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 892);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(714, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 31);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(856, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // sbtnExecute
            // 
            this.sbtnExecute.Location = new System.Drawing.Point(161, 6);
            this.sbtnExecute.Menu = this.cmsExecute;
            this.sbtnExecute.Name = "sbtnExecute";
            this.sbtnExecute.Size = new System.Drawing.Size(143, 31);
            this.sbtnExecute.TabIndex = 2;
            this.sbtnExecute.Text = "Execute";
            this.sbtnExecute.UseVisualStyleBackColor = true;
            // 
            // cmsExecute
            // 
            this.cmsExecute.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsExecute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acquireFrequencyToolStripMenuItem,
            this.acquireArtefactToolStripMenuItem,
            this.unlockArtefactToolStripMenuItem,
            this.adjustCharacterAttitudeTowardsToolStripMenuItem,
            this.setCharacterAttitudeTowardsToolStripMenuItem,
            this.adjustGroupAttitudeToolStripMenuItem,
            this.adjustCharacterAttitudeToolStripMenuItem,
            this.setCharacterAttitudeToolStripMenuItem,
            this.adjustCharacterTraitToolStripMenuItem,
            this.adjustInventoryItemToolStripMenuItem,
            this.consumeItemToolStripMenuItem,
            this.adjustInventoryCashToolStripMenuItem,
            this.unlockPlaceToolStripMenuItem,
            this.unlockSectionToolStripMenuItem,
            this.accessSectionToolStripMenuItem,
            this.unlockCharacterGossipToolStripMenuItem,
            this.hideCharacterGossipToolStripMenuItem,
            this.unlockJournalToolStripMenuItem,
            this.advanceJournalToolStripMenuItem,
            this.unlockScenarioToolStripMenuItem,
            this.startConversationToolStripMenuItem,
            this.openVendorToolStripMenuItem});
            this.cmsExecute.Name = "cmsExecute";
            this.cmsExecute.Size = new System.Drawing.Size(339, 708);
            // 
            // acquireFrequencyToolStripMenuItem
            // 
            this.acquireFrequencyToolStripMenuItem.Name = "acquireFrequencyToolStripMenuItem";
            this.acquireFrequencyToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.acquireFrequencyToolStripMenuItem.Text = "AdjustFrequency";
            this.acquireFrequencyToolStripMenuItem.ToolTipText = "Adjusts the frequency value of the player.";
            this.acquireFrequencyToolStripMenuItem.Click += new System.EventHandler(this.acquireFrequencyToolStripMenuItem_Click);
            // 
            // acquireArtefactToolStripMenuItem
            // 
            this.acquireArtefactToolStripMenuItem.Name = "acquireArtefactToolStripMenuItem";
            this.acquireArtefactToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.acquireArtefactToolStripMenuItem.Text = "AcquireArtefactFragment";
            this.acquireArtefactToolStripMenuItem.ToolTipText = "Acquire an artefact by ID value, if unlocked.";
            this.acquireArtefactToolStripMenuItem.Click += new System.EventHandler(this.acquireArtefactToolStripMenuItem_Click);
            // 
            // unlockArtefactToolStripMenuItem
            // 
            this.unlockArtefactToolStripMenuItem.Name = "unlockArtefactToolStripMenuItem";
            this.unlockArtefactToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.unlockArtefactToolStripMenuItem.Text = "UnlockArtefact";
            this.unlockArtefactToolStripMenuItem.ToolTipText = "Unlock access to an artefact by ID.";
            this.unlockArtefactToolStripMenuItem.Click += new System.EventHandler(this.unlockArtefactToolStripMenuItem_Click);
            // 
            // adjustCharacterAttitudeTowardsToolStripMenuItem
            // 
            this.adjustCharacterAttitudeTowardsToolStripMenuItem.Name = "adjustCharacterAttitudeTowardsToolStripMenuItem";
            this.adjustCharacterAttitudeTowardsToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.adjustCharacterAttitudeTowardsToolStripMenuItem.Text = "AdjustCharacterAttitudeTowards";
            this.adjustCharacterAttitudeTowardsToolStripMenuItem.ToolTipText = "Adjusts the value of a character attitude towards another character.";
            this.adjustCharacterAttitudeTowardsToolStripMenuItem.Click += new System.EventHandler(this.adjustCharacterAttitudeTowardsToolStripMenuItem_Click);
            // 
            // setCharacterAttitudeTowardsToolStripMenuItem
            // 
            this.setCharacterAttitudeTowardsToolStripMenuItem.Name = "setCharacterAttitudeTowardsToolStripMenuItem";
            this.setCharacterAttitudeTowardsToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.setCharacterAttitudeTowardsToolStripMenuItem.Text = "SetCharacterAttitudeTowards";
            this.setCharacterAttitudeTowardsToolStripMenuItem.ToolTipText = "Directly set the value of a character attitude towards another character.";
            this.setCharacterAttitudeTowardsToolStripMenuItem.Click += new System.EventHandler(this.setCharacterAttitudeTowardsToolStripMenuItem_Click);
            // 
            // adjustGroupAttitudeToolStripMenuItem
            // 
            this.adjustGroupAttitudeToolStripMenuItem.Name = "adjustGroupAttitudeToolStripMenuItem";
            this.adjustGroupAttitudeToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.adjustGroupAttitudeToolStripMenuItem.Text = "AdjustGroupFrequency";
            this.adjustGroupAttitudeToolStripMenuItem.ToolTipText = "Adjusts the value of a group\'s frequency towards the player.";
            this.adjustGroupAttitudeToolStripMenuItem.Click += new System.EventHandler(this.adjustGroupAttitudeToolStripMenuItem_Click);
            // 
            // adjustCharacterAttitudeToolStripMenuItem
            // 
            this.adjustCharacterAttitudeToolStripMenuItem.Name = "adjustCharacterAttitudeToolStripMenuItem";
            this.adjustCharacterAttitudeToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.adjustCharacterAttitudeToolStripMenuItem.Text = "AdjustCharacterAttitude";
            this.adjustCharacterAttitudeToolStripMenuItem.ToolTipText = "Adjusts the value of a character attitude.";
            this.adjustCharacterAttitudeToolStripMenuItem.Click += new System.EventHandler(this.adjustCharacterAttitudeToolStripMenuItem_Click);
            // 
            // setCharacterAttitudeToolStripMenuItem
            // 
            this.setCharacterAttitudeToolStripMenuItem.Name = "setCharacterAttitudeToolStripMenuItem";
            this.setCharacterAttitudeToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.setCharacterAttitudeToolStripMenuItem.Text = "SetCharacterAttitude";
            this.setCharacterAttitudeToolStripMenuItem.ToolTipText = "Directly set the value of a character attitude.";
            this.setCharacterAttitudeToolStripMenuItem.Click += new System.EventHandler(this.setCharacterAttitudeToolStripMenuItem_Click);
            // 
            // adjustCharacterTraitToolStripMenuItem
            // 
            this.adjustCharacterTraitToolStripMenuItem.Name = "adjustCharacterTraitToolStripMenuItem";
            this.adjustCharacterTraitToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.adjustCharacterTraitToolStripMenuItem.Text = "AdjustCharacterTrait";
            this.adjustCharacterTraitToolStripMenuItem.ToolTipText = "Adjusts the progress of a character\'s trait by id.";
            this.adjustCharacterTraitToolStripMenuItem.Click += new System.EventHandler(this.adjustCharacterTraitToolStripMenuItem_Click);
            // 
            // adjustInventoryItemToolStripMenuItem
            // 
            this.adjustInventoryItemToolStripMenuItem.Name = "adjustInventoryItemToolStripMenuItem";
            this.adjustInventoryItemToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.adjustInventoryItemToolStripMenuItem.Text = "AdjustInventoryItem";
            this.adjustInventoryItemToolStripMenuItem.ToolTipText = "Adjusts the quantity of a specific item by id inside the player\'s inventory.";
            this.adjustInventoryItemToolStripMenuItem.Click += new System.EventHandler(this.adjustInventoryItemToolStripMenuItem_Click);
            // 
            // consumeItemToolStripMenuItem
            // 
            this.consumeItemToolStripMenuItem.Name = "consumeItemToolStripMenuItem";
            this.consumeItemToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.consumeItemToolStripMenuItem.Text = "ConsumeItem";
            this.consumeItemToolStripMenuItem.Click += new System.EventHandler(this.consumeItemToolStripMenuItem_Click);
            // 
            // adjustInventoryCashToolStripMenuItem
            // 
            this.adjustInventoryCashToolStripMenuItem.Name = "adjustInventoryCashToolStripMenuItem";
            this.adjustInventoryCashToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.adjustInventoryCashToolStripMenuItem.Text = "AdjustInventoryCash";
            this.adjustInventoryCashToolStripMenuItem.ToolTipText = "Adjusts the total cash the player has.";
            this.adjustInventoryCashToolStripMenuItem.Click += new System.EventHandler(this.adjustInventoryCashToolStripMenuItem_Click);
            // 
            // unlockPlaceToolStripMenuItem
            // 
            this.unlockPlaceToolStripMenuItem.Name = "unlockPlaceToolStripMenuItem";
            this.unlockPlaceToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.unlockPlaceToolStripMenuItem.Text = "UnlockPlace";
            this.unlockPlaceToolStripMenuItem.ToolTipText = "Unlocks a place by id.";
            this.unlockPlaceToolStripMenuItem.Click += new System.EventHandler(this.unlockPlaceToolStripMenuItem_Click);
            // 
            // unlockSectionToolStripMenuItem
            // 
            this.unlockSectionToolStripMenuItem.Name = "unlockSectionToolStripMenuItem";
            this.unlockSectionToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.unlockSectionToolStripMenuItem.Text = "UnlockSection";
            this.unlockSectionToolStripMenuItem.ToolTipText = "Unlocks a section of a place by ID.";
            this.unlockSectionToolStripMenuItem.Click += new System.EventHandler(this.unlockSectionToolStripMenuItem_Click);
            // 
            // accessSectionToolStripMenuItem
            // 
            this.accessSectionToolStripMenuItem.Name = "accessSectionToolStripMenuItem";
            this.accessSectionToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.accessSectionToolStripMenuItem.Text = "AccessSection";
            this.accessSectionToolStripMenuItem.ToolTipText = "Accesses a section by ID immediately.";
            this.accessSectionToolStripMenuItem.Click += new System.EventHandler(this.accessSectionToolStripMenuItem_Click);
            // 
            // unlockCharacterGossipToolStripMenuItem
            // 
            this.unlockCharacterGossipToolStripMenuItem.Name = "unlockCharacterGossipToolStripMenuItem";
            this.unlockCharacterGossipToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.unlockCharacterGossipToolStripMenuItem.Text = "UnlockCharacterGossip";
            this.unlockCharacterGossipToolStripMenuItem.ToolTipText = "Unlocks a character in a section of a map.";
            this.unlockCharacterGossipToolStripMenuItem.Click += new System.EventHandler(this.unlockCharacterGossipToolStripMenuItem_Click);
            // 
            // hideCharacterGossipToolStripMenuItem
            // 
            this.hideCharacterGossipToolStripMenuItem.Name = "hideCharacterGossipToolStripMenuItem";
            this.hideCharacterGossipToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.hideCharacterGossipToolStripMenuItem.Text = "HideCharacterGossip";
            this.hideCharacterGossipToolStripMenuItem.ToolTipText = "Hides a character from a section of a map.";
            this.hideCharacterGossipToolStripMenuItem.Click += new System.EventHandler(this.hideCharacterGossipToolStripMenuItem_Click);
            // 
            // unlockJournalToolStripMenuItem
            // 
            this.unlockJournalToolStripMenuItem.Name = "unlockJournalToolStripMenuItem";
            this.unlockJournalToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.unlockJournalToolStripMenuItem.Text = "UnlockJournal";
            this.unlockJournalToolStripMenuItem.ToolTipText = "Unlocks a journal and adds it to the player\'s journal list.";
            this.unlockJournalToolStripMenuItem.Click += new System.EventHandler(this.unlockJournalToolStripMenuItem_Click);
            // 
            // advanceJournalToolStripMenuItem
            // 
            this.advanceJournalToolStripMenuItem.Name = "advanceJournalToolStripMenuItem";
            this.advanceJournalToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.advanceJournalToolStripMenuItem.Text = "AdvanceJournal";
            this.advanceJournalToolStripMenuItem.ToolTipText = "Advances a journal by a given id by one page. Completes the journal if the next p" +
    "age is the last page.";
            this.advanceJournalToolStripMenuItem.Click += new System.EventHandler(this.advanceJournalToolStripMenuItem_Click);
            // 
            // unlockScenarioToolStripMenuItem
            // 
            this.unlockScenarioToolStripMenuItem.Name = "unlockScenarioToolStripMenuItem";
            this.unlockScenarioToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.unlockScenarioToolStripMenuItem.Text = "UnlockScenario";
            this.unlockScenarioToolStripMenuItem.ToolTipText = "Unlocks access to a special feature scenario by ID.";
            this.unlockScenarioToolStripMenuItem.Click += new System.EventHandler(this.unlockScenarioToolStripMenuItem_Click);
            // 
            // startConversationToolStripMenuItem
            // 
            this.startConversationToolStripMenuItem.Name = "startConversationToolStripMenuItem";
            this.startConversationToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.startConversationToolStripMenuItem.Text = "StartConversation";
            this.startConversationToolStripMenuItem.ToolTipText = "Starts a conversation";
            this.startConversationToolStripMenuItem.Click += new System.EventHandler(this.startConversationToolStripMenuItem_Click);
            // 
            // openVendorToolStripMenuItem
            // 
            this.openVendorToolStripMenuItem.Name = "openVendorToolStripMenuItem";
            this.openVendorToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.openVendorToolStripMenuItem.Text = "OpenVendor";
            this.openVendorToolStripMenuItem.ToolTipText = "Requests that the given character\'s vendor items is displayed.";
            this.openVendorToolStripMenuItem.Click += new System.EventHandler(this.openVendorToolStripMenuItem_Click);
            // 
            // sbtnConditions
            // 
            this.sbtnConditions.Location = new System.Drawing.Point(12, 6);
            this.sbtnConditions.Menu = this.cmsConditional;
            this.sbtnConditions.Name = "sbtnConditions";
            this.sbtnConditions.Size = new System.Drawing.Size(143, 31);
            this.sbtnConditions.TabIndex = 1;
            this.sbtnConditions.Text = "Conditional";
            this.sbtnConditions.UseVisualStyleBackColor = true;
            // 
            // cmsConditional
            // 
            this.cmsConditional.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsConditional.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hasCharacterAttitudeToolStripMenuItem,
            this.hasCharacterAttitudeTowardsToolStripMenuItem,
            this.hasFrequencyToolStripMenuItem,
            this.hasFrequencyWithGroupToolStripMenuItem,
            this.isCurrentPOVToolStripMenuItem,
            this.hasArtefactFragmentToolStripMenuItem,
            this.hasArtefactCompletedToolStripMenuItem,
            this.hasUnlockedPlaceToolStripMenuItem,
            this.hasActivityProgressToolStripMenuItem,
            this.hasActivityPartCompleteToolStripMenuItem,
            this.hasActivityCompleteToolStripMenuItem,
            this.hasCharacterTraitProgressToolStripMenuItem,
            this.hasJournalProgressToolStripMenuItem,
            this.hasJournalCompletedToolStripMenuItem,
            this.hasItemToolStripMenuItem,
            this.hasItemNumberToolStripMenuItem,
            this.isItemAvailableToolStripMenuItem,
            this.hasScenarioCompletedToolStripMenuItem,
            this.hasUnlockedSectionToolStripMenuItem,
            this.isSectionAvailableToolStripMenuItem,
            this.isWithinSectionToolStripMenuItem,
            this.hasSpokenWithToolStripMenuItem,
            this.hasGossipOptionChosenToolStripMenuItem,
            this.isCharacterNourishedToolStripMenuItem,
            this.characterRequiresHealingToolStripMenuItem});
            this.cmsConditional.Name = "cmsConditional";
            this.cmsConditional.Size = new System.Drawing.Size(318, 837);
            // 
            // hasCharacterAttitudeToolStripMenuItem
            // 
            this.hasCharacterAttitudeToolStripMenuItem.Name = "hasCharacterAttitudeToolStripMenuItem";
            this.hasCharacterAttitudeToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasCharacterAttitudeToolStripMenuItem.Text = "HasCharacterAttitude";
            this.hasCharacterAttitudeToolStripMenuItem.ToolTipText = "Has a Character an attitude set to a value in or around the given attitude.";
            this.hasCharacterAttitudeToolStripMenuItem.Click += new System.EventHandler(this.hasCharacterAttitudeToolStripMenuItem_Click);
            // 
            // hasCharacterAttitudeTowardsToolStripMenuItem
            // 
            this.hasCharacterAttitudeTowardsToolStripMenuItem.Name = "hasCharacterAttitudeTowardsToolStripMenuItem";
            this.hasCharacterAttitudeTowardsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasCharacterAttitudeTowardsToolStripMenuItem.Text = "HasCharacterAttitudeTowards";
            this.hasCharacterAttitudeTowardsToolStripMenuItem.ToolTipText = "Has a Character an attitude set to a value in or around the given attitude toward" +
    "s a given character.";
            this.hasCharacterAttitudeTowardsToolStripMenuItem.Click += new System.EventHandler(this.hasCharacterAttitudeTowardsToolStripMenuItem_Click);
            // 
            // hasFrequencyToolStripMenuItem
            // 
            this.hasFrequencyToolStripMenuItem.Name = "hasFrequencyToolStripMenuItem";
            this.hasFrequencyToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasFrequencyToolStripMenuItem.Text = "HasFrequency";
            this.hasFrequencyToolStripMenuItem.ToolTipText = "Has the player a frequency of the specified value or greater.";
            this.hasFrequencyToolStripMenuItem.Click += new System.EventHandler(this.hasFrequencyToolStripMenuItem_Click);
            // 
            // hasFrequencyWithGroupToolStripMenuItem
            // 
            this.hasFrequencyWithGroupToolStripMenuItem.Name = "hasFrequencyWithGroupToolStripMenuItem";
            this.hasFrequencyWithGroupToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasFrequencyWithGroupToolStripMenuItem.Text = "HasFrequencyWithGroup";
            this.hasFrequencyWithGroupToolStripMenuItem.ToolTipText = "Has the player a frequency of the specified value or greater towards a given char" +
    "acter\'s related group.";
            this.hasFrequencyWithGroupToolStripMenuItem.Click += new System.EventHandler(this.hasFrequencyWithGroupToolStripMenuItem_Click);
            // 
            // isCurrentPOVToolStripMenuItem
            // 
            this.isCurrentPOVToolStripMenuItem.Name = "isCurrentPOVToolStripMenuItem";
            this.isCurrentPOVToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.isCurrentPOVToolStripMenuItem.Text = "IsCurrentPOV";
            this.isCurrentPOVToolStripMenuItem.ToolTipText = "Get whether or not the given character is the current point of view in conversati" +
    "on.";
            this.isCurrentPOVToolStripMenuItem.Click += new System.EventHandler(this.isCurrentPOVToolStripMenuItem_Click);
            // 
            // hasArtefactFragmentToolStripMenuItem
            // 
            this.hasArtefactFragmentToolStripMenuItem.Name = "hasArtefactFragmentToolStripMenuItem";
            this.hasArtefactFragmentToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasArtefactFragmentToolStripMenuItem.Text = "HasArtefactFragment";
            this.hasArtefactFragmentToolStripMenuItem.ToolTipText = "Has the player acquired a specific artefact fragment.";
            this.hasArtefactFragmentToolStripMenuItem.Click += new System.EventHandler(this.hasArtefactFragmentToolStripMenuItem_Click);
            // 
            // hasArtefactCompletedToolStripMenuItem
            // 
            this.hasArtefactCompletedToolStripMenuItem.Name = "hasArtefactCompletedToolStripMenuItem";
            this.hasArtefactCompletedToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasArtefactCompletedToolStripMenuItem.Text = "HasArtefactCompleted";
            this.hasArtefactCompletedToolStripMenuItem.ToolTipText = "Has the player fully completed finding all fragments for the given artefact.";
            this.hasArtefactCompletedToolStripMenuItem.Click += new System.EventHandler(this.hasArtefactCompletedToolStripMenuItem_Click);
            // 
            // hasUnlockedPlaceToolStripMenuItem
            // 
            this.hasUnlockedPlaceToolStripMenuItem.Name = "hasUnlockedPlaceToolStripMenuItem";
            this.hasUnlockedPlaceToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasUnlockedPlaceToolStripMenuItem.Text = "HasUnlockedPlace";
            this.hasUnlockedPlaceToolStripMenuItem.ToolTipText = "Has the player unlocked the given place.";
            this.hasUnlockedPlaceToolStripMenuItem.Click += new System.EventHandler(this.hasUnlockedPlaceToolStripMenuItem_Click);
            // 
            // hasActivityProgressToolStripMenuItem
            // 
            this.hasActivityProgressToolStripMenuItem.Name = "hasActivityProgressToolStripMenuItem";
            this.hasActivityProgressToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasActivityProgressToolStripMenuItem.Text = "HasActivityProgress";
            this.hasActivityProgressToolStripMenuItem.ToolTipText = "Has the given activity been progressed by a certain value.";
            this.hasActivityProgressToolStripMenuItem.Click += new System.EventHandler(this.hasActivityProgressToolStripMenuItem_Click);
            // 
            // hasActivityPartCompleteToolStripMenuItem
            // 
            this.hasActivityPartCompleteToolStripMenuItem.Name = "hasActivityPartCompleteToolStripMenuItem";
            this.hasActivityPartCompleteToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasActivityPartCompleteToolStripMenuItem.Text = "HasActivityPartComplete";
            this.hasActivityPartCompleteToolStripMenuItem.ToolTipText = "Has the given specific activity part been complete.";
            this.hasActivityPartCompleteToolStripMenuItem.Click += new System.EventHandler(this.hasActivityPartCompleteToolStripMenuItem_Click);
            // 
            // hasActivityCompleteToolStripMenuItem
            // 
            this.hasActivityCompleteToolStripMenuItem.Name = "hasActivityCompleteToolStripMenuItem";
            this.hasActivityCompleteToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasActivityCompleteToolStripMenuItem.Text = "HasActivityComplete";
            this.hasActivityCompleteToolStripMenuItem.ToolTipText = "Has the given activity been completed.";
            this.hasActivityCompleteToolStripMenuItem.Click += new System.EventHandler(this.hasActivityCompleteToolStripMenuItem_Click);
            // 
            // hasCharacterTraitProgressToolStripMenuItem
            // 
            this.hasCharacterTraitProgressToolStripMenuItem.Name = "hasCharacterTraitProgressToolStripMenuItem";
            this.hasCharacterTraitProgressToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasCharacterTraitProgressToolStripMenuItem.Text = "HasCharacterTraitProgress";
            this.hasCharacterTraitProgressToolStripMenuItem.ToolTipText = "Has the given character\'s trait been progressed to the given value or higher.";
            this.hasCharacterTraitProgressToolStripMenuItem.Click += new System.EventHandler(this.hasCharacterTraitProgressToolStripMenuItem_Click);
            // 
            // hasJournalProgressToolStripMenuItem
            // 
            this.hasJournalProgressToolStripMenuItem.Name = "hasJournalProgressToolStripMenuItem";
            this.hasJournalProgressToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasJournalProgressToolStripMenuItem.Text = "HasJournalProgress";
            this.hasJournalProgressToolStripMenuItem.ToolTipText = "Has the given journal progressed up to the number of pages given.";
            this.hasJournalProgressToolStripMenuItem.Click += new System.EventHandler(this.hasJournalProgressToolStripMenuItem_Click);
            // 
            // hasJournalCompletedToolStripMenuItem
            // 
            this.hasJournalCompletedToolStripMenuItem.Name = "hasJournalCompletedToolStripMenuItem";
            this.hasJournalCompletedToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasJournalCompletedToolStripMenuItem.Text = "HasJournalCompleted";
            this.hasJournalCompletedToolStripMenuItem.ToolTipText = "Has the given journal been completed.";
            this.hasJournalCompletedToolStripMenuItem.Click += new System.EventHandler(this.hasJournalCompletedToolStripMenuItem_Click);
            // 
            // hasItemToolStripMenuItem
            // 
            this.hasItemToolStripMenuItem.Name = "hasItemToolStripMenuItem";
            this.hasItemToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasItemToolStripMenuItem.Text = "HasItem";
            this.hasItemToolStripMenuItem.ToolTipText = "Has the player the given item in their inventory.";
            this.hasItemToolStripMenuItem.Click += new System.EventHandler(this.hasItemToolStripMenuItem_Click);
            // 
            // hasItemNumberToolStripMenuItem
            // 
            this.hasItemNumberToolStripMenuItem.Name = "hasItemNumberToolStripMenuItem";
            this.hasItemNumberToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasItemNumberToolStripMenuItem.Text = "HasItemNumber";
            this.hasItemNumberToolStripMenuItem.ToolTipText = "Has the player the given item at the number given in their inventory.";
            this.hasItemNumberToolStripMenuItem.Click += new System.EventHandler(this.hasItemNumberToolStripMenuItem_Click);
            // 
            // isItemAvailableToolStripMenuItem
            // 
            this.isItemAvailableToolStripMenuItem.Name = "isItemAvailableToolStripMenuItem";
            this.isItemAvailableToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.isItemAvailableToolStripMenuItem.Text = "IsItemAvailable";
            this.isItemAvailableToolStripMenuItem.ToolTipText = "Is the given item available to purchase from the given character.";
            this.isItemAvailableToolStripMenuItem.Click += new System.EventHandler(this.isItemAvailableToolStripMenuItem_Click);
            // 
            // hasScenarioCompletedToolStripMenuItem
            // 
            this.hasScenarioCompletedToolStripMenuItem.Name = "hasScenarioCompletedToolStripMenuItem";
            this.hasScenarioCompletedToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasScenarioCompletedToolStripMenuItem.Text = "HasScenarioCompleted";
            this.hasScenarioCompletedToolStripMenuItem.ToolTipText = "Has the player completed the given scenario from a special feature.";
            this.hasScenarioCompletedToolStripMenuItem.Click += new System.EventHandler(this.hasScenarioCompletedToolStripMenuItem_Click);
            // 
            // hasUnlockedSectionToolStripMenuItem
            // 
            this.hasUnlockedSectionToolStripMenuItem.Name = "hasUnlockedSectionToolStripMenuItem";
            this.hasUnlockedSectionToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasUnlockedSectionToolStripMenuItem.Text = "HasUnlockedSection";
            this.hasUnlockedSectionToolStripMenuItem.ToolTipText = "Has the player unlocked the given section.";
            this.hasUnlockedSectionToolStripMenuItem.Click += new System.EventHandler(this.hasUnlockedSectionToolStripMenuItem_Click);
            // 
            // isSectionAvailableToolStripMenuItem
            // 
            this.isSectionAvailableToolStripMenuItem.Name = "isSectionAvailableToolStripMenuItem";
            this.isSectionAvailableToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.isSectionAvailableToolStripMenuItem.Text = "IsSectionAvailable";
            this.isSectionAvailableToolStripMenuItem.ToolTipText = "Is the given section available to enter from the current section.";
            this.isSectionAvailableToolStripMenuItem.Click += new System.EventHandler(this.isSectionAvailableToolStripMenuItem_Click);
            // 
            // isWithinSectionToolStripMenuItem
            // 
            this.isWithinSectionToolStripMenuItem.Name = "isWithinSectionToolStripMenuItem";
            this.isWithinSectionToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.isWithinSectionToolStripMenuItem.Text = "IsWithinSection";
            this.isWithinSectionToolStripMenuItem.ToolTipText = "Is the player currently within the given section.";
            this.isWithinSectionToolStripMenuItem.Click += new System.EventHandler(this.isWithinSectionToolStripMenuItem_Click);
            // 
            // hasSpokenWithToolStripMenuItem
            // 
            this.hasSpokenWithToolStripMenuItem.Name = "hasSpokenWithToolStripMenuItem";
            this.hasSpokenWithToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasSpokenWithToolStripMenuItem.Text = "HasSpokenWith";
            this.hasSpokenWithToolStripMenuItem.ToolTipText = "Has the player spoken with the given character in the specified section.";
            this.hasSpokenWithToolStripMenuItem.Click += new System.EventHandler(this.hasSpokenWithToolStripMenuItem_Click);
            // 
            // hasGossipOptionChosenToolStripMenuItem
            // 
            this.hasGossipOptionChosenToolStripMenuItem.Name = "hasGossipOptionChosenToolStripMenuItem";
            this.hasGossipOptionChosenToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.hasGossipOptionChosenToolStripMenuItem.Text = "HasGossipOptionChosen";
            this.hasGossipOptionChosenToolStripMenuItem.ToolTipText = "Has the player chosen the given gossip option with the given character and sectio" +
    "n.";
            this.hasGossipOptionChosenToolStripMenuItem.Click += new System.EventHandler(this.hasGossipOptionChosenToolStripMenuItem_Click);
            // 
            // isCharacterNourishedToolStripMenuItem
            // 
            this.isCharacterNourishedToolStripMenuItem.Name = "isCharacterNourishedToolStripMenuItem";
            this.isCharacterNourishedToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.isCharacterNourishedToolStripMenuItem.Text = "IsCharacterNourished";
            this.isCharacterNourishedToolStripMenuItem.ToolTipText = "Is the given character nourished.";
            this.isCharacterNourishedToolStripMenuItem.Click += new System.EventHandler(this.isCharacterNourishedToolStripMenuItem_Click);
            // 
            // characterRequiresHealingToolStripMenuItem
            // 
            this.characterRequiresHealingToolStripMenuItem.Name = "characterRequiresHealingToolStripMenuItem";
            this.characterRequiresHealingToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.characterRequiresHealingToolStripMenuItem.Text = "CharacterRequiresHealing";
            this.characterRequiresHealingToolStripMenuItem.ToolTipText = "Does the given character require healing of any kind.";
            this.characterRequiresHealingToolStripMenuItem.Click += new System.EventHandler(this.characterRequiresHealingToolStripMenuItem_Click);
            // 
            // btnChangeView
            // 
            this.btnChangeView.Location = new System.Drawing.Point(310, 6);
            this.btnChangeView.Name = "btnChangeView";
            this.btnChangeView.Size = new System.Drawing.Size(136, 31);
            this.btnChangeView.TabIndex = 0;
            this.btnChangeView.Text = "Advanced >>";
            this.btnChangeView.UseVisualStyleBackColor = true;
            this.btnChangeView.Click += new System.EventHandler(this.btnChangeView_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1004, 892);
            this.pnlContent.TabIndex = 1;
            // 
            // CodeConstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 937);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodeConstructForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Construct Code";
            this.panel1.ResumeLayout(false);
            this.cmsExecute.ResumeLayout(false);
            this.cmsConditional.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangeView;
        private System.Windows.Forms.Panel pnlContent;
        private Components.SplitButton sbtnConditions;
        private System.Windows.Forms.ContextMenuStrip cmsConditional;
        private System.Windows.Forms.ToolStripMenuItem hasCharacterAttitudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasCharacterAttitudeTowardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasFrequencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasFrequencyWithGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isCurrentPOVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasArtefactFragmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasArtefactCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasUnlockedPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasActivityProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasActivityPartCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasActivityCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasCharacterTraitProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasJournalProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasJournalCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasItemNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isItemAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasScenarioCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasUnlockedSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isSectionAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasSpokenWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasGossipOptionChosenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isCharacterNourishedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterRequiresHealingToolStripMenuItem;
        private Components.SplitButton sbtnExecute;
        private System.Windows.Forms.ContextMenuStrip cmsExecute;
        private System.Windows.Forms.ToolStripMenuItem acquireArtefactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockArtefactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustCharacterAttitudeTowardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCharacterAttitudeTowardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustGroupAttitudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustCharacterAttitudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCharacterAttitudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustCharacterTraitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustInventoryItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustInventoryCashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessSectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockCharacterGossipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideCharacterGossipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advanceJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startConversationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVendorToolStripMenuItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem consumeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acquireFrequencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isWithinSectionToolStripMenuItem;
    }
}