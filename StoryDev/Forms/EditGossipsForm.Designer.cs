
namespace StoryDev.Forms
{
    partial class EditGossipsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbVisible = new System.Windows.Forms.CheckBox();
            this.cmbCharacter = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGossipOptions = new System.Windows.Forms.ListBox();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.pnlCode = new System.Windows.Forms.Panel();
            this.pnlCodeContent = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCondition = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCode.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbVisible);
            this.panel1.Controls.Add(this.cmbCharacter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 40);
            this.panel1.TabIndex = 0;
            // 
            // chbVisible
            // 
            this.chbVisible.AutoSize = true;
            this.chbVisible.Location = new System.Drawing.Point(312, 8);
            this.chbVisible.Name = "chbVisible";
            this.chbVisible.Size = new System.Drawing.Size(146, 24);
            this.chbVisible.TabIndex = 1;
            this.chbVisible.Text = "Visible to Player";
            this.chbVisible.UseVisualStyleBackColor = true;
            this.chbVisible.CheckedChanged += new System.EventHandler(this.chbVisible_CheckedChanged);
            // 
            // cmbCharacter
            // 
            this.cmbCharacter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCharacter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCharacter.FormattingEnabled = true;
            this.cmbCharacter.Location = new System.Drawing.Point(12, 6);
            this.cmbCharacter.Name = "cmbCharacter";
            this.cmbCharacter.Size = new System.Drawing.Size(294, 28);
            this.cmbCharacter.TabIndex = 0;
            this.cmbCharacter.SelectedIndexChanged += new System.EventHandler(this.cmbCharacter_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbGossipOptions);
            this.panel2.Controls.Add(this.txtCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 779);
            this.panel2.TabIndex = 1;
            // 
            // lbGossipOptions
            // 
            this.lbGossipOptions.FormattingEnabled = true;
            this.lbGossipOptions.ItemHeight = 20;
            this.lbGossipOptions.Location = new System.Drawing.Point(12, 38);
            this.lbGossipOptions.Name = "lbGossipOptions";
            this.lbGossipOptions.Size = new System.Drawing.Size(242, 724);
            this.lbGossipOptions.TabIndex = 2;
            this.lbGossipOptions.SelectedIndexChanged += new System.EventHandler(this.lbGossipOptions_SelectedIndexChanged);
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(12, 6);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(242, 26);
            this.txtCreate.TabIndex = 2;
            this.txtCreate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCreate_KeyUp);
            // 
            // pnlCode
            // 
            this.pnlCode.Controls.Add(this.pnlCodeContent);
            this.pnlCode.Controls.Add(this.panel3);
            this.pnlCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCode.Location = new System.Drawing.Point(269, 40);
            this.pnlCode.Name = "pnlCode";
            this.pnlCode.Size = new System.Drawing.Size(775, 779);
            this.pnlCode.TabIndex = 2;
            // 
            // pnlCodeContent
            // 
            this.pnlCodeContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodeContent.Location = new System.Drawing.Point(0, 115);
            this.pnlCodeContent.Name = "pnlCodeContent";
            this.pnlCodeContent.Size = new System.Drawing.Size(775, 664);
            this.pnlCodeContent.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlCondition);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 115);
            this.panel3.TabIndex = 0;
            // 
            // pnlCondition
            // 
            this.pnlCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCondition.Location = new System.Drawing.Point(0, 32);
            this.pnlCondition.Name = "pnlCondition";
            this.pnlCondition.Size = new System.Drawing.Size(775, 83);
            this.pnlCondition.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 32);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(775, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditGossipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 819);
            this.Controls.Add(this.pnlCode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGossipsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edit Gossips";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditGossipsForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCode.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCharacter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbGossipOptions;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.Panel pnlCode;
        private System.Windows.Forms.Panel pnlCodeContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCondition;
        private System.Windows.Forms.CheckBox chbVisible;
    }
}