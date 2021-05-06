using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class IconSelectorForm : Form
    {

        private IconsCanvas canvas;

        public int SelectedIndex;

        public IconSelectorForm(string imagePath, int iconSize)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            InitializeComponent();

            canvas = new IconsCanvas();
            canvas.Dock = DockStyle.Fill;
            canvas.DrawMode = IconCanvasDrawMode.Select;
            canvas.ImagePath = imagePath;
            canvas.IconSize = iconSize;
            canvas.DoubleClick += Canvas_DoubleClick;
            Controls.Add(canvas);
        }

        private void Canvas_DoubleClick(object sender, EventArgs e)
        {
            SelectedIndex = canvas.SelectedIndex;
            DialogResult = DialogResult.OK;
        }

        private void IconSelectorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            canvas.Free();
        }
    }
}
