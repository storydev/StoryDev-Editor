
namespace StoryDev.Forms
{
    partial class ArtManagerForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Art");
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tvArtFiles = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.spcImageView = new System.Windows.Forms.SplitContainer();
            this.pnlImageProperties = new System.Windows.Forms.Panel();
            this.btnProperties = new System.Windows.Forms.Button();
            this.cmbImageType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.artPreview = new StoryDev.Components.ArtPreviewUI();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcImageView)).BeginInit();
            this.spcImageView.Panel1.SuspendLayout();
            this.spcImageView.Panel2.SuspendLayout();
            this.spcImageView.SuspendLayout();
            this.pnlImageProperties.SuspendLayout();
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
            this.spcMain.Panel1.Controls.Add(this.tvArtFiles);
            this.spcMain.Panel1.Controls.Add(this.panel1);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcImageView);
            this.spcMain.Size = new System.Drawing.Size(1054, 719);
            this.spcMain.SplitterDistance = 266;
            this.spcMain.TabIndex = 0;
            // 
            // tvArtFiles
            // 
            this.tvArtFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvArtFiles.HideSelection = false;
            this.tvArtFiles.Location = new System.Drawing.Point(0, 37);
            this.tvArtFiles.Name = "tvArtFiles";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Art";
            this.tvArtFiles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvArtFiles.Size = new System.Drawing.Size(266, 682);
            this.tvArtFiles.TabIndex = 1;
            this.tvArtFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArtFiles_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(3, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 31);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // spcImageView
            // 
            this.spcImageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcImageView.IsSplitterFixed = true;
            this.spcImageView.Location = new System.Drawing.Point(0, 0);
            this.spcImageView.Name = "spcImageView";
            this.spcImageView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcImageView.Panel1
            // 
            this.spcImageView.Panel1.Controls.Add(this.artPreview);
            // 
            // spcImageView.Panel2
            // 
            this.spcImageView.Panel2.Controls.Add(this.pnlImageProperties);
            this.spcImageView.Size = new System.Drawing.Size(784, 719);
            this.spcImageView.SplitterDistance = 660;
            this.spcImageView.TabIndex = 0;
            // 
            // pnlImageProperties
            // 
            this.pnlImageProperties.Controls.Add(this.btnProperties);
            this.pnlImageProperties.Controls.Add(this.cmbImageType);
            this.pnlImageProperties.Controls.Add(this.label1);
            this.pnlImageProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageProperties.Enabled = false;
            this.pnlImageProperties.Location = new System.Drawing.Point(0, 0);
            this.pnlImageProperties.Name = "pnlImageProperties";
            this.pnlImageProperties.Size = new System.Drawing.Size(784, 55);
            this.pnlImageProperties.TabIndex = 0;
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(269, 14);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(150, 29);
            this.btnProperties.TabIndex = 2;
            this.btnProperties.Text = "Properties...";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Visible = false;
            // 
            // cmbImageType
            // 
            this.cmbImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageType.FormattingEnabled = true;
            this.cmbImageType.Items.AddRange(new object[] {
            "Static",
            "Standard Sheet",
            "Tile Sheet",
            "Animated Sprite Sheet"});
            this.cmbImageType.Location = new System.Drawing.Point(67, 14);
            this.cmbImageType.Name = "cmbImageType";
            this.cmbImageType.Size = new System.Drawing.Size(196, 28);
            this.cmbImageType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // artPreview
            // 
            this.artPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artPreview.Image = null;
            this.artPreview.Location = new System.Drawing.Point(0, 0);
            this.artPreview.Name = "artPreview";
            this.artPreview.Size = new System.Drawing.Size(784, 660);
            this.artPreview.TabIndex = 0;
            // 
            // ArtManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 719);
            this.Controls.Add(this.spcMain);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "ArtManagerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Art Manager";
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.spcImageView.Panel1.ResumeLayout(false);
            this.spcImageView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcImageView)).EndInit();
            this.spcImageView.ResumeLayout(false);
            this.pnlImageProperties.ResumeLayout(false);
            this.pnlImageProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvArtFiles;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.SplitContainer spcImageView;
        private System.Windows.Forms.Panel pnlImageProperties;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.ComboBox cmbImageType;
        private System.Windows.Forms.Label label1;
        private Components.ArtPreviewUI artPreview;
    }
}