
namespace StoryDev.Forms.Previews
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcProperties = new System.Windows.Forms.SplitContainer();
            this.spcPreview = new System.Windows.Forms.SplitContainer();
            this.pnlDebugger = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.pnlConversations = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRecordingsFolder = new System.Windows.Forms.ComboBox();
            this.btnBrowseRecordFolder = new System.Windows.Forms.Button();
            this.btnFileNameOptions = new System.Windows.Forms.Button();
            this.btnPlayRecording = new System.Windows.Forms.Button();
            this.btnEditConversation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcProperties)).BeginInit();
            this.spcProperties.Panel1.SuspendLayout();
            this.spcProperties.Panel2.SuspendLayout();
            this.spcProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPreview)).BeginInit();
            this.spcPreview.Panel2.SuspendLayout();
            this.spcPreview.SuspendLayout();
            this.pnlDebugger.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.spcProperties);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcPreview);
            this.spcMain.Size = new System.Drawing.Size(1535, 1040);
            this.spcMain.SplitterDistance = 351;
            this.spcMain.TabIndex = 0;
            // 
            // spcProperties
            // 
            this.spcProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcProperties.Location = new System.Drawing.Point(0, 0);
            this.spcProperties.Name = "spcProperties";
            this.spcProperties.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcProperties.Panel1
            // 
            this.spcProperties.Panel1.Controls.Add(this.pnlDebugger);
            // 
            // spcProperties.Panel2
            // 
            this.spcProperties.Panel2.Controls.Add(this.pnlConversations);
            this.spcProperties.Size = new System.Drawing.Size(351, 1040);
            this.spcProperties.SplitterDistance = 509;
            this.spcProperties.TabIndex = 0;
            // 
            // spcPreview
            // 
            this.spcPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPreview.Location = new System.Drawing.Point(0, 0);
            this.spcPreview.Name = "spcPreview";
            this.spcPreview.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcPreview.Panel2
            // 
            this.spcPreview.Panel2.Controls.Add(this.pnlOptions);
            this.spcPreview.Size = new System.Drawing.Size(1180, 1040);
            this.spcPreview.SplitterDistance = 873;
            this.spcPreview.TabIndex = 0;
            // 
            // pnlDebugger
            // 
            this.pnlDebugger.Controls.Add(this.panel1);
            this.pnlDebugger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDebugger.Enabled = false;
            this.pnlDebugger.Location = new System.Drawing.Point(0, 0);
            this.pnlDebugger.Name = "pnlDebugger";
            this.pnlDebugger.Size = new System.Drawing.Size(351, 509);
            this.pnlDebugger.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddVar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnAddVar
            // 
            this.btnAddVar.Location = new System.Drawing.Point(0, 0);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(91, 35);
            this.btnAddVar.TabIndex = 0;
            this.btnAddVar.Text = "Add Var";
            this.btnAddVar.UseVisualStyleBackColor = true;
            // 
            // pnlConversations
            // 
            this.pnlConversations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConversations.Enabled = false;
            this.pnlConversations.Location = new System.Drawing.Point(0, 0);
            this.pnlConversations.Name = "pnlConversations";
            this.pnlConversations.Size = new System.Drawing.Size(351, 527);
            this.pnlConversations.TabIndex = 0;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnEditConversation);
            this.pnlOptions.Controls.Add(this.btnPlayRecording);
            this.pnlOptions.Controls.Add(this.btnFileNameOptions);
            this.pnlOptions.Controls.Add(this.btnBrowseRecordFolder);
            this.pnlOptions.Controls.Add(this.cmbRecordingsFolder);
            this.pnlOptions.Controls.Add(this.label1);
            this.pnlOptions.Controls.Add(this.btnStartRecording);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Enabled = false;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(1180, 163);
            this.pnlOptions.TabIndex = 0;
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Image = global::StoryDev.Properties.Resources.Record;
            this.btnStartRecording.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartRecording.Location = new System.Drawing.Point(15, 12);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(237, 58);
            this.btnStartRecording.TabIndex = 0;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recordings Folder:";
            // 
            // cmbRecordingsFolder
            // 
            this.cmbRecordingsFolder.FormattingEnabled = true;
            this.cmbRecordingsFolder.Location = new System.Drawing.Point(416, 18);
            this.cmbRecordingsFolder.Name = "cmbRecordingsFolder";
            this.cmbRecordingsFolder.Size = new System.Drawing.Size(228, 28);
            this.cmbRecordingsFolder.TabIndex = 2;
            // 
            // btnBrowseRecordFolder
            // 
            this.btnBrowseRecordFolder.Location = new System.Drawing.Point(650, 14);
            this.btnBrowseRecordFolder.Name = "btnBrowseRecordFolder";
            this.btnBrowseRecordFolder.Size = new System.Drawing.Size(103, 34);
            this.btnBrowseRecordFolder.TabIndex = 3;
            this.btnBrowseRecordFolder.Text = "Browse...";
            this.btnBrowseRecordFolder.UseVisualStyleBackColor = true;
            // 
            // btnFileNameOptions
            // 
            this.btnFileNameOptions.Location = new System.Drawing.Point(271, 55);
            this.btnFileNameOptions.Name = "btnFileNameOptions";
            this.btnFileNameOptions.Size = new System.Drawing.Size(159, 34);
            this.btnFileNameOptions.TabIndex = 4;
            this.btnFileNameOptions.Text = "File Options...";
            this.btnFileNameOptions.UseVisualStyleBackColor = true;
            // 
            // btnPlayRecording
            // 
            this.btnPlayRecording.Image = global::StoryDev.Properties.Resources.Play;
            this.btnPlayRecording.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayRecording.Location = new System.Drawing.Point(15, 76);
            this.btnPlayRecording.Name = "btnPlayRecording";
            this.btnPlayRecording.Size = new System.Drawing.Size(237, 58);
            this.btnPlayRecording.TabIndex = 5;
            this.btnPlayRecording.Text = "Play Recording";
            this.btnPlayRecording.UseVisualStyleBackColor = true;
            // 
            // btnEditConversation
            // 
            this.btnEditConversation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditConversation.Location = new System.Drawing.Point(952, 14);
            this.btnEditConversation.Name = "btnEditConversation";
            this.btnEditConversation.Size = new System.Drawing.Size(216, 34);
            this.btnEditConversation.TabIndex = 6;
            this.btnEditConversation.Text = "Edit Conversation";
            this.btnEditConversation.UseVisualStyleBackColor = true;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 1040);
            this.Controls.Add(this.spcMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcProperties.Panel1.ResumeLayout(false);
            this.spcProperties.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcProperties)).EndInit();
            this.spcProperties.ResumeLayout(false);
            this.spcPreview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPreview)).EndInit();
            this.spcPreview.ResumeLayout(false);
            this.pnlDebugger.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.SplitContainer spcProperties;
        private System.Windows.Forms.Panel pnlDebugger;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddVar;
        private System.Windows.Forms.Panel pnlConversations;
        private System.Windows.Forms.SplitContainer spcPreview;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnEditConversation;
        private System.Windows.Forms.Button btnPlayRecording;
        private System.Windows.Forms.Button btnFileNameOptions;
        private System.Windows.Forms.Button btnBrowseRecordFolder;
        private System.Windows.Forms.ComboBox cmbRecordingsFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartRecording;
    }
}