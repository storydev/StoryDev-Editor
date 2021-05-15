
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
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.Image = global::StoryDev.Properties.Resources.Play;
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
            this.chbRecord.Image = global::StoryDev.Properties.Resources.Record;
            this.chbRecord.Location = new System.Drawing.Point(72, 12);
            this.chbRecord.Name = "chbRecord";
            this.chbRecord.Size = new System.Drawing.Size(54, 54);
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
            this.chbAutoTrack.Location = new System.Drawing.Point(7, 69);
            this.chbAutoTrack.Name = "chbAutoTrack";
            this.chbAutoTrack.Size = new System.Drawing.Size(164, 24);
            this.chbAutoTrack.TabIndex = 4;
            this.chbAutoTrack.Text = "Auto-Track States";
            this.chbAutoTrack.UseVisualStyleBackColor = true;
            // 
            // chbAutoCompare
            // 
            this.chbAutoCompare.AutoSize = true;
            this.chbAutoCompare.Location = new System.Drawing.Point(188, 69);
            this.chbAutoCompare.Name = "chbAutoCompare";
            this.chbAutoCompare.Size = new System.Drawing.Size(139, 24);
            this.chbAutoCompare.TabIndex = 5;
            this.chbAutoCompare.Text = "Auto-Compare";
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
            this.chbBestOutcome.Location = new System.Drawing.Point(323, 2);
            this.chbBestOutcome.Name = "chbBestOutcome";
            this.chbBestOutcome.Size = new System.Drawing.Size(137, 24);
            this.chbBestOutcome.TabIndex = 7;
            this.chbBestOutcome.Text = "Best Outcome";
            this.chbBestOutcome.UseVisualStyleBackColor = true;
            // 
            // chbWorstOutcome
            // 
            this.chbWorstOutcome.AutoSize = true;
            this.chbWorstOutcome.Location = new System.Drawing.Point(323, 32);
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
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 114);
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
            this.TopMost = true;
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
    }
}