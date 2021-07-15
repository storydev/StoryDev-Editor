
namespace StoryDev.Forms
{
    partial class SimulationForm
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
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.chbRecord = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.chbAutoTrack = new System.Windows.Forms.CheckBox();
            this.chbAutoCompare = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbBestOutcome = new System.Windows.Forms.CheckBox();
            this.chbWorstOutcome = new System.Windows.Forms.CheckBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvErrors = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvWarnings = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvMessages = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.BackgroundImage = global::StoryDev.Properties.Resources.Play;
            this.btnPlayStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayStop.Location = new System.Drawing.Point(12, 12);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(54, 54);
            this.btnPlayStop.TabIndex = 0;
            this.btnPlayStop.UseVisualStyleBackColor = true;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // chbRecord
            // 
            this.chbRecord.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbRecord.BackgroundImage = global::StoryDev.Properties.Resources.Record;
            this.chbRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chbRecord.Location = new System.Drawing.Point(72, 12);
            this.chbRecord.Name = "chbRecord";
            this.chbRecord.Size = new System.Drawing.Size(54, 55);
            this.chbRecord.TabIndex = 1;
            this.chbRecord.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Template:";
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(88, 0);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(150, 28);
            this.cmbTemplates.TabIndex = 3;
            this.cmbTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbTemplates_SelectedIndexChanged);
            // 
            // chbAutoTrack
            // 
            this.chbAutoTrack.AutoSize = true;
            this.chbAutoTrack.Location = new System.Drawing.Point(8, 69);
            this.chbAutoTrack.Name = "chbAutoTrack";
            this.chbAutoTrack.Size = new System.Drawing.Size(164, 24);
            this.chbAutoTrack.TabIndex = 4;
            this.chbAutoTrack.Text = "Auto-Track States";
            this.toolTip1.SetToolTip(this.chbAutoTrack, "When playing, automatically start tracking state changes across all conversations" +
        ".");
            this.chbAutoTrack.UseVisualStyleBackColor = true;
            this.chbAutoTrack.CheckedChanged += new System.EventHandler(this.chbAutoTrack_CheckedChanged);
            // 
            // chbAutoCompare
            // 
            this.chbAutoCompare.AutoSize = true;
            this.chbAutoCompare.Location = new System.Drawing.Point(188, 69);
            this.chbAutoCompare.Name = "chbAutoCompare";
            this.chbAutoCompare.Size = new System.Drawing.Size(139, 24);
            this.chbAutoCompare.TabIndex = 5;
            this.chbAutoCompare.Text = "Auto-Compare";
            this.toolTip1.SetToolTip(this.chbAutoCompare, "Based on the latest saved state, automatically compare state changes while playin" +
        "g.");
            this.chbAutoCompare.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tracking:";
            // 
            // chbBestOutcome
            // 
            this.chbBestOutcome.AutoSize = true;
            this.chbBestOutcome.Location = new System.Drawing.Point(322, 2);
            this.chbBestOutcome.Name = "chbBestOutcome";
            this.chbBestOutcome.Size = new System.Drawing.Size(137, 24);
            this.chbBestOutcome.TabIndex = 7;
            this.chbBestOutcome.Text = "Best Outcome";
            this.chbBestOutcome.UseVisualStyleBackColor = true;
            // 
            // chbWorstOutcome
            // 
            this.chbWorstOutcome.AutoSize = true;
            this.chbWorstOutcome.Location = new System.Drawing.Point(322, 32);
            this.chbWorstOutcome.Name = "chbWorstOutcome";
            this.chbWorstOutcome.Size = new System.Drawing.Size(146, 24);
            this.chbWorstOutcome.TabIndex = 8;
            this.chbWorstOutcome.Text = "Worst Outcome";
            this.chbWorstOutcome.UseVisualStyleBackColor = true;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.label1);
            this.pnlOptions.Controls.Add(this.chbWorstOutcome);
            this.pnlOptions.Controls.Add(this.cmbTemplates);
            this.pnlOptions.Controls.Add(this.chbBestOutcome);
            this.pnlOptions.Controls.Add(this.chbAutoTrack);
            this.pnlOptions.Controls.Add(this.label2);
            this.pnlOptions.Controls.Add(this.chbAutoCompare);
            this.pnlOptions.Location = new System.Drawing.Point(132, 9);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(531, 100);
            this.pnlOptions.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 239);
            this.panel1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 239);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvErrors);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Errors (0)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvErrors
            // 
            this.lvErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvErrors.Enabled = false;
            this.lvErrors.FullRowSelect = true;
            this.lvErrors.HideSelection = false;
            this.lvErrors.Location = new System.Drawing.Point(3, 3);
            this.lvErrors.MultiSelect = false;
            this.lvErrors.Name = "lvErrors";
            this.lvErrors.Size = new System.Drawing.Size(660, 200);
            this.lvErrors.TabIndex = 0;
            this.lvErrors.UseCompatibleStateImageBehavior = false;
            this.lvErrors.View = System.Windows.Forms.View.Details;
            this.lvErrors.DoubleClick += new System.EventHandler(this.lvErrors_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Line";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 350;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvWarnings);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Warnings (0)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvWarnings
            // 
            this.lvWarnings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvWarnings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWarnings.Enabled = false;
            this.lvWarnings.FullRowSelect = true;
            this.lvWarnings.HideSelection = false;
            this.lvWarnings.Location = new System.Drawing.Point(3, 3);
            this.lvWarnings.MultiSelect = false;
            this.lvWarnings.Name = "lvWarnings";
            this.lvWarnings.Size = new System.Drawing.Size(660, 200);
            this.lvWarnings.TabIndex = 1;
            this.lvWarnings.UseCompatibleStateImageBehavior = false;
            this.lvWarnings.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "File";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Line";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Title";
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Description";
            this.columnHeader8.Width = 350;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvMessages);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(666, 206);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Messages (0)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvMessages
            // 
            this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMessages.Enabled = false;
            this.lvMessages.FullRowSelect = true;
            this.lvMessages.HideSelection = false;
            this.lvMessages.Location = new System.Drawing.Point(3, 3);
            this.lvMessages.MultiSelect = false;
            this.lvMessages.Name = "lvMessages";
            this.lvMessages.Size = new System.Drawing.Size(660, 200);
            this.lvMessages.TabIndex = 1;
            this.lvMessages.UseCompatibleStateImageBehavior = false;
            this.lvMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "File";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Line";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Title";
            this.columnHeader11.Width = 125;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Description";
            this.columnHeader12.Width = 350;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.chbRecord);
            this.Controls.Add(this.btnPlayStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SimulationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulations";
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.CheckBox chbRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.CheckBox chbAutoTrack;
        private System.Windows.Forms.CheckBox chbAutoCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbBestOutcome;
        private System.Windows.Forms.CheckBox chbWorstOutcome;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvErrors;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvWarnings;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lvMessages;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}