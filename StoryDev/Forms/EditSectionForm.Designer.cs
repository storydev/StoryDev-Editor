
namespace StoryDev.Forms
{
    partial class EditSectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chbVisibleToPlayer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvGossips = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbConnectionAvailable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEnteredFromPlace = new System.Windows.Forms.ComboBox();
            this.btnBrowsePlaces = new System.Windows.Forms.Button();
            this.cmbEnteredFromSection = new System.Windows.Forms.ComboBox();
            this.cmsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(196, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescription.Location = new System.Drawing.Point(196, 59);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(428, 137);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // chbVisibleToPlayer
            // 
            this.chbVisibleToPlayer.AutoSize = true;
            this.chbVisibleToPlayer.Checked = true;
            this.chbVisibleToPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbVisibleToPlayer.Location = new System.Drawing.Point(196, 202);
            this.chbVisibleToPlayer.Name = "chbVisibleToPlayer";
            this.chbVisibleToPlayer.Size = new System.Drawing.Size(146, 24);
            this.chbVisibleToPlayer.TabIndex = 4;
            this.chbVisibleToPlayer.Text = "Visible to Player";
            this.toolTip1.SetToolTip(this.chbVisibleToPlayer, "This section becomes immediately visible to the player once any and all condition" +
        "s\r\nset below are met. Otherwise, it is assumed a script will activate this secti" +
        "on.");
            this.chbVisibleToPlayer.UseVisualStyleBackColor = true;
            this.chbVisibleToPlayer.CheckedChanged += new System.EventHandler(this.chbVisibleToPlayer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gossips";
            // 
            // lvGossips
            // 
            this.lvGossips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvGossips.ContextMenuStrip = this.cmsEdit;
            this.lvGossips.FullRowSelect = true;
            this.lvGossips.HideSelection = false;
            this.lvGossips.Location = new System.Drawing.Point(74, 430);
            this.lvGossips.MultiSelect = false;
            this.lvGossips.Name = "lvGossips";
            this.lvGossips.Size = new System.Drawing.Size(576, 146);
            this.lvGossips.TabIndex = 7;
            this.lvGossips.UseCompatibleStateImageBehavior = false;
            this.lvGossips.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Character";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gossip Options";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Visible";
            this.columnHeader3.Width = 80;
            // 
            // cmsEdit
            // 
            this.cmsEdit.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(135, 100);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(619, 597);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(524, 597);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 37);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbConnectionAvailable
            // 
            this.cmbConnectionAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConnectionAvailable.FormattingEnabled = true;
            this.cmbConnectionAvailable.Items.AddRange(new object[] {
            "Always",
            "On Place First Entered",
            "Entrance Fulfilled",
            "Scripted"});
            this.cmbConnectionAvailable.Location = new System.Drawing.Point(319, 286);
            this.cmbConnectionAvailable.Name = "cmbConnectionAvailable";
            this.cmbConnectionAvailable.Size = new System.Drawing.Size(258, 28);
            this.cmbConnectionAvailable.TabIndex = 10;
            this.cmbConnectionAvailable.SelectedIndexChanged += new System.EventHandler(this.cmbConnectionAvailable_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Connection Availability:";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(315, 317);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(335, 67);
            this.lblInfo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Entered From:";
            // 
            // cmbEnteredFromPlace
            // 
            this.cmbEnteredFromPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbEnteredFromPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbEnteredFromPlace.FormattingEnabled = true;
            this.cmbEnteredFromPlace.Location = new System.Drawing.Point(196, 232);
            this.cmbEnteredFromPlace.Name = "cmbEnteredFromPlace";
            this.cmbEnteredFromPlace.Size = new System.Drawing.Size(156, 28);
            this.cmbEnteredFromPlace.TabIndex = 14;
            this.cmbEnteredFromPlace.SelectedIndexChanged += new System.EventHandler(this.cmbEnteredFromPlace_SelectedIndexChanged);
            // 
            // btnBrowsePlaces
            // 
            this.btnBrowsePlaces.Location = new System.Drawing.Point(358, 232);
            this.btnBrowsePlaces.Name = "btnBrowsePlaces";
            this.btnBrowsePlaces.Size = new System.Drawing.Size(36, 28);
            this.btnBrowsePlaces.TabIndex = 15;
            this.btnBrowsePlaces.Text = "...";
            this.btnBrowsePlaces.UseVisualStyleBackColor = true;
            this.btnBrowsePlaces.Click += new System.EventHandler(this.btnBrowsePlaces_Click);
            // 
            // cmbEnteredFromSection
            // 
            this.cmbEnteredFromSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnteredFromSection.FormattingEnabled = true;
            this.cmbEnteredFromSection.Location = new System.Drawing.Point(400, 232);
            this.cmbEnteredFromSection.Name = "cmbEnteredFromSection";
            this.cmbEnteredFromSection.Size = new System.Drawing.Size(154, 28);
            this.cmbEnteredFromSection.TabIndex = 16;
            this.cmbEnteredFromSection.SelectedIndexChanged += new System.EventHandler(this.cmbEnteredFromSection_SelectedIndexChanged);
            // 
            // EditSectionForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(720, 646);
            this.Controls.Add(this.cmbEnteredFromSection);
            this.Controls.Add(this.btnBrowsePlaces);
            this.Controls.Add(this.cmbEnteredFromPlace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbConnectionAvailable);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvGossips);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbVisibleToPlayer);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Section";
            this.cmsEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chbVisibleToPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvGossips;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ContextMenuStrip cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbConnectionAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEnteredFromPlace;
        private System.Windows.Forms.Button btnBrowsePlaces;
        private System.Windows.Forms.ComboBox cmbEnteredFromSection;
    }
}