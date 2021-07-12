
namespace StoryDev.Forms
{
    partial class MapPointPropertiesForm
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
            this.pnlBasicProperties = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSectionProperties = new System.Windows.Forms.Button();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPlaces = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemoveJournal = new System.Windows.Forms.Button();
            this.btnAddJournal = new System.Windows.Forms.Button();
            this.lbJournals = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbConversations = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbConnections = new System.Windows.Forms.ListBox();
            this.chbStartConnecting = new System.Windows.Forms.CheckBox();
            this.pnlBasicProperties.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasicProperties
            // 
            this.pnlBasicProperties.Controls.Add(this.panel2);
            this.pnlBasicProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBasicProperties.Enabled = false;
            this.pnlBasicProperties.Location = new System.Drawing.Point(0, 0);
            this.pnlBasicProperties.Name = "pnlBasicProperties";
            this.pnlBasicProperties.Size = new System.Drawing.Size(366, 171);
            this.pnlBasicProperties.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSectionProperties);
            this.panel2.Controls.Add(this.cmbSections);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbPlaces);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 153);
            this.panel2.TabIndex = 0;
            // 
            // btnSectionProperties
            // 
            this.btnSectionProperties.Location = new System.Drawing.Point(186, 104);
            this.btnSectionProperties.Name = "btnSectionProperties";
            this.btnSectionProperties.Size = new System.Drawing.Size(134, 33);
            this.btnSectionProperties.TabIndex = 5;
            this.btnSectionProperties.Text = "Properties...";
            this.btnSectionProperties.UseVisualStyleBackColor = true;
            this.btnSectionProperties.Click += new System.EventHandler(this.btnSectionProperties_Click);
            // 
            // cmbSections
            // 
            this.cmbSections.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSections.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbSections.Enabled = false;
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(109, 70);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(211, 28);
            this.cmbSections.TabIndex = 4;
            this.cmbSections.SelectedIndexChanged += new System.EventHandler(this.cmbSections_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Section:";
            // 
            // cmbPlaces
            // 
            this.cmbPlaces.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPlaces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPlaces.FormattingEnabled = true;
            this.cmbPlaces.Location = new System.Drawing.Point(109, 36);
            this.cmbPlaces.Name = "cmbPlaces";
            this.cmbPlaces.Size = new System.Drawing.Size(211, 28);
            this.cmbPlaces.TabIndex = 2;
            this.cmbPlaces.SelectedIndexChanged += new System.EventHandler(this.cmbPlaces_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Associated With:";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Enabled = false;
            this.tcMain.Location = new System.Drawing.Point(0, 171);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(366, 822);
            this.tcMain.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemoveJournal);
            this.tabPage2.Controls.Add(this.btnAddJournal);
            this.tabPage2.Controls.Add(this.lbJournals);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 789);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Journals";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemoveJournal
            // 
            this.btnRemoveJournal.Enabled = false;
            this.btnRemoveJournal.Location = new System.Drawing.Point(218, 7);
            this.btnRemoveJournal.Name = "btnRemoveJournal";
            this.btnRemoveJournal.Size = new System.Drawing.Size(134, 33);
            this.btnRemoveJournal.TabIndex = 7;
            this.btnRemoveJournal.Text = "Remove";
            this.btnRemoveJournal.UseVisualStyleBackColor = true;
            this.btnRemoveJournal.Click += new System.EventHandler(this.btnRemoveJournal_Click);
            // 
            // btnAddJournal
            // 
            this.btnAddJournal.Location = new System.Drawing.Point(10, 6);
            this.btnAddJournal.Name = "btnAddJournal";
            this.btnAddJournal.Size = new System.Drawing.Size(134, 33);
            this.btnAddJournal.TabIndex = 6;
            this.btnAddJournal.Text = "Add Journal...";
            this.btnAddJournal.UseVisualStyleBackColor = true;
            // 
            // lbJournals
            // 
            this.lbJournals.FormattingEnabled = true;
            this.lbJournals.ItemHeight = 20;
            this.lbJournals.Location = new System.Drawing.Point(10, 46);
            this.lbJournals.Name = "lbJournals";
            this.lbJournals.Size = new System.Drawing.Size(342, 724);
            this.lbJournals.TabIndex = 1;
            this.lbJournals.SelectedIndexChanged += new System.EventHandler(this.lbJournals_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbConversations);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(358, 789);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conversations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbConversations
            // 
            this.lbConversations.FormattingEnabled = true;
            this.lbConversations.ItemHeight = 20;
            this.lbConversations.Location = new System.Drawing.Point(8, 18);
            this.lbConversations.Name = "lbConversations";
            this.lbConversations.Size = new System.Drawing.Size(342, 744);
            this.lbConversations.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbConnections);
            this.tabPage1.Controls.Add(this.chbStartConnecting);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 789);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Connections";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbConnections
            // 
            this.lbConnections.FormattingEnabled = true;
            this.lbConnections.ItemHeight = 20;
            this.lbConnections.Location = new System.Drawing.Point(11, 49);
            this.lbConnections.Name = "lbConnections";
            this.lbConnections.Size = new System.Drawing.Size(339, 164);
            this.lbConnections.TabIndex = 1;
            // 
            // chbStartConnecting
            // 
            this.chbStartConnecting.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbStartConnecting.AutoSize = true;
            this.chbStartConnecting.Location = new System.Drawing.Point(11, 13);
            this.chbStartConnecting.Name = "chbStartConnecting";
            this.chbStartConnecting.Size = new System.Drawing.Size(139, 30);
            this.chbStartConnecting.TabIndex = 0;
            this.chbStartConnecting.Text = "Start Connecting";
            this.chbStartConnecting.UseVisualStyleBackColor = true;
            this.chbStartConnecting.CheckedChanged += new System.EventHandler(this.chbStartConnecting_CheckedChanged);
            // 
            // MapPointPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 993);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pnlBasicProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapPointPropertiesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Properties";
            this.pnlBasicProperties.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBasicProperties;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSectionProperties;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPlaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbConnections;
        private System.Windows.Forms.CheckBox chbStartConnecting;
        private System.Windows.Forms.ListBox lbConversations;
        private System.Windows.Forms.Button btnRemoveJournal;
        private System.Windows.Forms.Button btnAddJournal;
        private System.Windows.Forms.ListBox lbJournals;
    }
}