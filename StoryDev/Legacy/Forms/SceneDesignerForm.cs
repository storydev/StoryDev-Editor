using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cyotek.Windows.Forms;

namespace StoryDev.Forms
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    partial class SceneDesignerForm : Form
    {

        

        public SceneDesignerForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();


        }

        private void tsbForeColor_Click(object sender, EventArgs e)
        {
            var picker = new ColorPickerDialog();
            picker.Color = tsbForeColor.BackColor;
            if (picker.ShowDialog() == DialogResult.OK)
            {
                var color = Color.FromArgb(picker.Color.R, picker.Color.G, picker.Color.B);
                tsbForeColor.BackColor = color;
                sceneDesigner.DrawForeColor = color;
            }
        }

        private void tsbBackColor_Click(object sender, EventArgs e)
        {
            var picker = new ColorPickerDialog();
            picker.Color = tsbBackColor.BackColor;
            if (picker.ShowDialog() == DialogResult.OK)
            {
                var color = Color.FromArgb(picker.Color.R, picker.Color.G, picker.Color.B);
                tsbBackColor.BackColor = color;
                sceneDesigner.DrawBackColor = color;
            }
        }

        private void tsbDrawLine_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbDrawLine_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void tsbDrawLine_CheckedChanged(object sender, EventArgs e)
        {
            if (tsbDrawLine.Checked)
                sceneDesigner.StartDrawElement(Components.SceneElementType.DrawLine);
            else
                sceneDesigner.StartDrawElement(Components.SceneElementType.DrawNone);
        }

        private void rectangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rectangleToolStripMenuItem1.Checked)
                sceneDesigner.StartDrawElement(Components.SceneElementType.DrawRect);
            else
                sceneDesigner.StartDrawElement(Components.SceneElementType.DrawNone);
        }

        private void circleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (circleToolStripMenuItem1.Checked)
                sceneDesigner.StartDrawElement(Components.SceneElementType.DrawCircle);
            else
                sceneDesigner.StartDrawElement(Components.SceneElementType.DrawNone);
        }
    }

}
