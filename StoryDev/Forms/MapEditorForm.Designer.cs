namespace StoryDev.Forms
{
    partial class MapEditorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.gbPlaces = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMapImage = new System.Windows.Forms.TextBox();
            this.btnSelectMapImage = new System.Windows.Forms.Button();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvPlaces = new System.Windows.Forms.ListView();
            this.btnSetupEntrances = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenMapPointsEditor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbPlaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(69, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 26);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(278, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(37, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(466, 223);
            this.txtDescription.TabIndex = 5;
            // 
            // gbPlaces
            // 
            this.gbPlaces.Controls.Add(this.btnSetupEntrances);
            this.gbPlaces.Controls.Add(this.lvPlaces);
            this.gbPlaces.Controls.Add(this.btnRemove);
            this.gbPlaces.Controls.Add(this.btnAddPlace);
            this.gbPlaces.Location = new System.Drawing.Point(520, 26);
            this.gbPlaces.Name = "gbPlaces";
            this.gbPlaces.Size = new System.Drawing.Size(562, 417);
            this.gbPlaces.TabIndex = 6;
            this.gbPlaces.TabStop = false;
            this.gbPlaces.Text = "Places";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Map Image:";
            // 
            // txtMapImage
            // 
            this.txtMapImage.Location = new System.Drawing.Point(132, 327);
            this.txtMapImage.Name = "txtMapImage";
            this.txtMapImage.Size = new System.Drawing.Size(305, 26);
            this.txtMapImage.TabIndex = 8;
            // 
            // btnSelectMapImage
            // 
            this.btnSelectMapImage.Location = new System.Drawing.Point(443, 324);
            this.btnSelectMapImage.Name = "btnSelectMapImage";
            this.btnSelectMapImage.Size = new System.Drawing.Size(60, 32);
            this.btnSelectMapImage.TabIndex = 9;
            this.btnSelectMapImage.Text = "...";
            this.btnSelectMapImage.UseVisualStyleBackColor = true;
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.Location = new System.Drawing.Point(18, 28);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(119, 30);
            this.btnAddPlace.TabIndex = 0;
            this.btnAddPlace.Text = "Add...";
            this.btnAddPlace.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(143, 28);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lvPlaces
            // 
            this.lvPlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPlaces.HideSelection = false;
            this.lvPlaces.Location = new System.Drawing.Point(18, 64);
            this.lvPlaces.Name = "lvPlaces";
            this.lvPlaces.Size = new System.Drawing.Size(523, 299);
            this.lvPlaces.TabIndex = 2;
            this.lvPlaces.UseCompatibleStateImageBehavior = false;
            this.lvPlaces.View = System.Windows.Forms.View.Details;
            // 
            // btnSetupEntrances
            // 
            this.btnSetupEntrances.Location = new System.Drawing.Point(18, 369);
            this.btnSetupEntrances.Name = "btnSetupEntrances";
            this.btnSetupEntrances.Size = new System.Drawing.Size(182, 30);
            this.btnSetupEntrances.TabIndex = 3;
            this.btnSetupEntrances.Text = "Setup Entrances";
            this.btnSetupEntrances.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Location";
            this.columnHeader3.Width = 100;
            // 
            // btnOpenMapPointsEditor
            // 
            this.btnOpenMapPointsEditor.Location = new System.Drawing.Point(37, 359);
            this.btnOpenMapPointsEditor.Name = "btnOpenMapPointsEditor";
            this.btnOpenMapPointsEditor.Size = new System.Drawing.Size(258, 30);
            this.btnOpenMapPointsEditor.TabIndex = 10;
            this.btnOpenMapPointsEditor.Text = "Open Map Points Editor...";
            this.btnOpenMapPointsEditor.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(958, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(828, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MapEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 506);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpenMapPointsEditor);
            this.Controls.Add(this.btnSelectMapImage);
            this.Controls.Add(this.txtMapImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbPlaces);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MapEditorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map Editor";
            this.gbPlaces.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox gbPlaces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMapImage;
        private System.Windows.Forms.Button btnSelectMapImage;
        private System.Windows.Forms.Button btnSetupEntrances;
        private System.Windows.Forms.ListView lvPlaces;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddPlace;
        private System.Windows.Forms.Button btnOpenMapPointsEditor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}