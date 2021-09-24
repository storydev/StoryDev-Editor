
namespace StoryDev.Forms.ArtManager
{
    partial class StandardSheetPropertiesForm
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
            this.lbSheetCells = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.pnlScale9Rect = new System.Windows.Forms.Panel();
            this.nudScale9Bottom = new System.Windows.Forms.NumericUpDown();
            this.nudScale9Right = new System.Windows.Forms.NumericUpDown();
            this.nudScale9Left = new System.Windows.Forms.NumericUpDown();
            this.nudScale9Top = new System.Windows.Forms.NumericUpDown();
            this.chbScale9Rect = new System.Windows.Forms.CheckBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPosY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPosX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            this.pnlScale9Rect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSheetCells);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 315);
            this.panel1.TabIndex = 0;
            // 
            // lbSheetCells
            // 
            this.lbSheetCells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSheetCells.FormattingEnabled = true;
            this.lbSheetCells.ItemHeight = 20;
            this.lbSheetCells.Location = new System.Drawing.Point(0, 0);
            this.lbSheetCells.Name = "lbSheetCells";
            this.lbSheetCells.Size = new System.Drawing.Size(328, 315);
            this.lbSheetCells.TabIndex = 1;
            this.lbSheetCells.SelectedIndexChanged += new System.EventHandler(this.lbSheetCells_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(328, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(51, 315);
            this.panel3.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Location = new System.Drawing.Point(6, 38);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(39, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlProperties
            // 
            this.pnlProperties.Controls.Add(this.pnlScale9Rect);
            this.pnlProperties.Controls.Add(this.chbScale9Rect);
            this.pnlProperties.Controls.Add(this.nudHeight);
            this.pnlProperties.Controls.Add(this.label5);
            this.pnlProperties.Controls.Add(this.nudWidth);
            this.pnlProperties.Controls.Add(this.label6);
            this.pnlProperties.Controls.Add(this.label4);
            this.pnlProperties.Controls.Add(this.nudPosY);
            this.pnlProperties.Controls.Add(this.label3);
            this.pnlProperties.Controls.Add(this.nudPosX);
            this.pnlProperties.Controls.Add(this.label2);
            this.pnlProperties.Controls.Add(this.label1);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProperties.Enabled = false;
            this.pnlProperties.Location = new System.Drawing.Point(0, 315);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(379, 382);
            this.pnlProperties.TabIndex = 1;
            // 
            // pnlScale9Rect
            // 
            this.pnlScale9Rect.Controls.Add(this.nudScale9Bottom);
            this.pnlScale9Rect.Controls.Add(this.nudScale9Right);
            this.pnlScale9Rect.Controls.Add(this.nudScale9Left);
            this.pnlScale9Rect.Controls.Add(this.nudScale9Top);
            this.pnlScale9Rect.Enabled = false;
            this.pnlScale9Rect.Location = new System.Drawing.Point(38, 195);
            this.pnlScale9Rect.Name = "pnlScale9Rect";
            this.pnlScale9Rect.Size = new System.Drawing.Size(290, 98);
            this.pnlScale9Rect.TabIndex = 11;
            // 
            // nudScale9Bottom
            // 
            this.nudScale9Bottom.Location = new System.Drawing.Point(98, 67);
            this.nudScale9Bottom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScale9Bottom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudScale9Bottom.Name = "nudScale9Bottom";
            this.nudScale9Bottom.Size = new System.Drawing.Size(94, 26);
            this.nudScale9Bottom.TabIndex = 13;
            this.nudScale9Bottom.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudScale9Right
            // 
            this.nudScale9Right.Location = new System.Drawing.Point(193, 35);
            this.nudScale9Right.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScale9Right.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudScale9Right.Name = "nudScale9Right";
            this.nudScale9Right.Size = new System.Drawing.Size(94, 26);
            this.nudScale9Right.TabIndex = 12;
            this.nudScale9Right.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudScale9Left
            // 
            this.nudScale9Left.Location = new System.Drawing.Point(3, 35);
            this.nudScale9Left.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScale9Left.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudScale9Left.Name = "nudScale9Left";
            this.nudScale9Left.Size = new System.Drawing.Size(94, 26);
            this.nudScale9Left.TabIndex = 11;
            this.nudScale9Left.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // nudScale9Top
            // 
            this.nudScale9Top.Location = new System.Drawing.Point(98, 3);
            this.nudScale9Top.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudScale9Top.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudScale9Top.Name = "nudScale9Top";
            this.nudScale9Top.Size = new System.Drawing.Size(94, 26);
            this.nudScale9Top.TabIndex = 10;
            this.nudScale9Top.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // chbScale9Rect
            // 
            this.chbScale9Rect.AutoSize = true;
            this.chbScale9Rect.Location = new System.Drawing.Point(30, 165);
            this.chbScale9Rect.Name = "chbScale9Rect";
            this.chbScale9Rect.Size = new System.Drawing.Size(170, 24);
            this.chbScale9Rect.TabIndex = 10;
            this.chbScale9Rect.Text = "Scale-9 Rectangle:";
            this.chbScale9Rect.UseVisualStyleBackColor = true;
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(244, 124);
            this.nudHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(94, 26);
            this.nudHeight.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Height:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(78, 124);
            this.nudWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(94, 26);
            this.nudWidth.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Size:";
            // 
            // nudPosY
            // 
            this.nudPosY.Location = new System.Drawing.Point(208, 51);
            this.nudPosY.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPosY.Name = "nudPosY";
            this.nudPosY.Size = new System.Drawing.Size(94, 26);
            this.nudPosY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y:";
            // 
            // nudPosX
            // 
            this.nudPosX.Location = new System.Drawing.Point(78, 51);
            this.nudPosX.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPosX.Name = "nudPosX";
            this.nudPosX.Size = new System.Drawing.Size(94, 26);
            this.nudPosX.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // StandardSheetPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 697);
            this.Controls.Add(this.pnlProperties);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandardSheetPropertiesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlProperties.ResumeLayout(false);
            this.pnlProperties.PerformLayout();
            this.pnlScale9Rect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScale9Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbSheetCells;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.Panel pnlScale9Rect;
        private System.Windows.Forms.NumericUpDown nudScale9Bottom;
        private System.Windows.Forms.NumericUpDown nudScale9Right;
        private System.Windows.Forms.NumericUpDown nudScale9Left;
        private System.Windows.Forms.NumericUpDown nudScale9Top;
        private System.Windows.Forms.CheckBox chbScale9Rect;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPosY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPosX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}