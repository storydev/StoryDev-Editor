using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components
{
    partial class SceneDesignerUI : UserControl
    {

        private Graphics g;

        private readonly float canvasMargin = 75;
        private readonly float canvasCellSize = 64;

        public SceneDesignerUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;

            g.Clear(Color.FromArgb(64, 64, 64));

            var colCount = Math.Ceiling(Width / canvasCellSize);
            var rowCount = Math.Ceiling(Height / canvasCellSize);

            for (int y = 0; y < rowCount; y++)
            {
                g.DrawLine(new Pen(Color.FromArgb(48, 48, 48)), 0, y * canvasCellSize, Width, y * canvasCellSize);
            }

            for (int x = 0; x < colCount; x++)
            {
                g.DrawLine(new Pen(Color.FromArgb(48, 48, 48)), x * canvasCellSize, 0, x * canvasCellSize, Height);
            }

            g.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2), canvasMargin, 0, canvasMargin, Height);
            g.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2), 0, canvasMargin, Width, canvasMargin);
        }
    }
}
