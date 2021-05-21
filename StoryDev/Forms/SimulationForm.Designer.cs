
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
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.BackgroundImage = global::StoryDev.Properties.Resources.Play;
            this.btnPlayStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayStop.Location = new System.Drawing.Point(8, 8);
            this.btnPlayStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(36, 35);
            this.btnPlayStop.TabIndex = 0;
            this.btnPlayStop.UseVisualStyleBackColor = true;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // chbRecord
            // 
            this.chbRecord.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbRecord.BackgroundImage = global::StoryDev.Properties.Resources.Record;
            this.chbRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chbRecord.Location = new System.Drawing.Point(48, 8);
            this.chbRecord.Margin = new System.Windows.Forms.Padding(2);
            this.chbRecord.Name = "chbRecord";
            this.chbRecord.Size = new System.Drawing.Size(36, 36);
            this.chbRecord.TabIndex = 1;
            this.chbRecord.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Template:";
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(59, 0);
            this.cmbTemplates.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(101, 21);
            this.cmbTemplates.TabIndex = 3;
            this.cmbTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbTemplates_SelectedIndexChanged);
            // 
            // chbAutoTrack
            // 
            this.chbAutoTrack.AutoSize = true;
            this.chbAutoTrack.Location = new System.Drawing.Point(5, 45);
            this.chbAutoTrack.Margin = new System.Windows.Forms.Padding(2);
            this.chbAutoTrack.Name = "chbAutoTrack";
            this.chbAutoTrack.Size = new System.Drawing.Size(112, 17);
            this.chbAutoTrack.TabIndex = 4;
            this.chbAutoTrack.Text = "Auto-Track States";
            this.toolTip1.SetToolTip(this.chbAutoTrack, "When playing, automatically start tracking state changes across all conversations" +
        ".");
            this.chbAutoTrack.UseVisualStyleBackColor = true;
            // 
            // chbAutoCompare
            // 
            this.chbAutoCompare.AutoSize = true;
            this.chbAutoCompare.Location = new System.Drawing.Point(125, 45);
            this.chbAutoCompare.Margin = new System.Windows.Forms.Padding(2);
            this.chbAutoCompare.Name = "chbAutoCompare";
            this.chbAutoCompare.Size = new System.Drawing.Size(93, 17);
            this.chbAutoCompare.TabIndex = 5;
            this.chbAutoCompare.Text = "Auto-Compare";
            this.toolTip1.SetToolTip(this.chbAutoCompare, "Based on the latest saved state, automatically compare state changes while playin" +
        "g.");
            this.chbAutoCompare.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tracking:";
            // 
            // chbBestOutcome
            // 
            this.chbBestOutcome.AutoSize = true;
            this.chbBestOutcome.Location = new System.Drawing.Point(215, 1);
            this.chbBestOutcome.Margin = new System.Windows.Forms.Padding(2);
            this.chbBestOutcome.Name = "chbBestOutcome";
            this.chbBestOutcome.Size = new System.Drawing.Size(93, 17);
            this.chbBestOutcome.TabIndex = 7;
            this.chbBestOutcome.Text = "Best Outcome";
            this.chbBestOutcome.UseVisualStyleBackColor = true;
            // 
            // chbWorstOutcome
            // 
            this.chbWorstOutcome.AutoSize = true;
            this.chbWorstOutcome.Location = new System.Drawing.Point(215, 21);
            this.chbWorstOutcome.Margin = new System.Windows.Forms.Padding(2);
            this.chbWorstOutcome.Name = "chbWorstOutcome";
            this.chbWorstOutcome.Size = new System.Drawing.Size(100, 17);
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
            this.pnlOptions.Location = new System.Drawing.Point(88, 6);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(354, 65);
            this.pnlOptions.TabIndex = 9;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 74);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.chbRecord);
            this.Controls.Add(this.btnPlayStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SimulationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulations";
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
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
    }
}