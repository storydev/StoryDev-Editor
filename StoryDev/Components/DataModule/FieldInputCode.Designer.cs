
namespace StoryDev.Components.DataModule
{
    partial class FieldInputCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldInputCode));
            this.lblFieldName = new System.Windows.Forms.Label();
            this.codeEditor = new StoryDev.Components.CodeEditor();
            ((System.ComponentModel.ISupportInitialize)(this.codeEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFieldName
            // 
            this.lblFieldName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFieldName.Location = new System.Drawing.Point(0, 0);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(665, 25);
            this.lblFieldName.TabIndex = 0;
            this.lblFieldName.Text = "Field Name:";
            // 
            // codeEditor
            // 
            this.codeEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeEditor.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.codeEditor.BackBrush = null;
            this.codeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codeEditor.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.codeEditor.CharHeight = 22;
            this.codeEditor.CharWidth = 12;
            this.codeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeEditor.DelayedTextChangedInterval = 170;
            this.codeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.codeEditor.IsReplaceMode = false;
            this.codeEditor.Location = new System.Drawing.Point(0, 25);
            this.codeEditor.Name = "codeEditor";
            this.codeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.codeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.codeEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeEditor.ServiceColors")));
            this.codeEditor.Size = new System.Drawing.Size(665, 500);
            this.codeEditor.TabIndex = 1;
            this.codeEditor.Zoom = 100;
            // 
            // FieldInputCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codeEditor);
            this.Controls.Add(this.lblFieldName);
            this.Name = "FieldInputCode";
            this.Size = new System.Drawing.Size(665, 525);
            ((System.ComponentModel.ISupportInitialize)(this.codeEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFieldName;
        private CodeEditor codeEditor;
    }
}
