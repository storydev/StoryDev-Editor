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
    partial class SceneDesignerForm : Form
    {
        public SceneDesignerForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();


        }

        private void tsbForeColor_Click(object sender, EventArgs e)
        {
            var picker = new ColorDialog();
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
            var picker = new ColorDialog();
            picker.Color = tsbBackColor.BackColor;
            if (picker.ShowDialog() == DialogResult.OK)
            {
                var color = Color.FromArgb(picker.Color.R, picker.Color.G, picker.Color.B);
                tsbBackColor.BackColor = color;
                sceneDesigner.DrawBackColor = color;
            }
        }
    }
}
