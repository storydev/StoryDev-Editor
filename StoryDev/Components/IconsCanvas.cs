using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StoryDev.Components
{
    partial class IconsCanvas : UserControl
    {

        private Pen highlighter;
        private Image iconset;
        private bool requireImageChange;

        private int selectedIndex = -1;

        public int SelectedIndex
        {
            get { return selectedIndex; }
        }

        private string imagePath;
        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
                requireImageChange = true;

                Invalidate();
            }
        }

        private int iconSize;
        public int IconSize
        {
            get
            {
                return iconSize;
            }
            set
            {
                iconSize = value;

                Invalidate();
            }
        }

        private IconCanvasDrawMode drawMode;
        public IconCanvasDrawMode DrawMode
        {
            get
            {
                return drawMode;
            }
            set
            {
                drawMode = value;
                Invalidate();
            }
        }

        public IconsCanvas()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            highlighter = new Pen(Color.Yellow);
            highlighter.Width = 2;
        }

        public void Free()
        {
            if (iconset != null)
                iconset.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            if (!string.IsNullOrEmpty(imagePath) && (iconset == null || requireImageChange))
            {
                if (File.Exists(imagePath))
                {
                    if (iconset != null)
                        iconset.Dispose();

                    iconset = Image.FromFile(imagePath);
                }
                else
                {
                    if (iconset != null)
                        iconset.Dispose();

                    iconset = null;
                }
            }
            else if (string.IsNullOrEmpty(imagePath))
            {
                if (iconset != null)
                    iconset.Dispose();

                iconset = null;
            }

            if (iconset != null)
            {
                g.Clear(Color.FromArgb(96, 96, 96));

                g.FillRectangle(Brushes.Blue, 0, 0, iconset.PhysicalDimension.Width, iconset.PhysicalDimension.Height);
                g.DrawImage(iconset, 0, 0, iconset.PhysicalDimension.Width, iconset.PhysicalDimension.Height);

                var tilesX = Math.Ceiling((decimal)iconset.Width / iconSize);
                var tilesY = Math.Ceiling((decimal)iconset.Height / iconSize);

                for (int y = 1; y < tilesY + 1; y++)
                {
                    g.DrawLine(Pens.White, 0, y * iconSize, iconset.Width, y * iconSize);
                }

                for (int x = 1; x < tilesX + 1; x++)
                {
                    g.DrawLine(Pens.White, x * iconSize, 0, x * iconSize, iconset.Height);
                }

                if (selectedIndex > -1)
                {
                    var x = 0m;
                    var y = 0m;

                    if (selectedIndex > 0)
                    {
                        x = Math.Floor(selectedIndex % ((decimal)iconset.Width / iconSize)) * iconSize;
                        y = Math.Floor(selectedIndex / ((decimal)iconset.Width / iconSize)) * iconSize;
                    }

                    g.DrawRectangle(highlighter, (float)x + 4, (float)y + 4, iconSize - 8, iconSize - 8);
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (drawMode == IconCanvasDrawMode.Select && iconset != null)
            {
                if (e.X > iconset.PhysicalDimension.Width || e.Y > iconset.PhysicalDimension.Height)
                {
                    return;
                }

                int cellX = (int)Math.Floor((decimal)e.X / iconSize);
                int cellY = (int)Math.Floor((decimal)e.Y / iconSize);

                selectedIndex = (int)(cellY * (iconset.PhysicalDimension.Width / iconSize) + cellX);

                Invalidate();
            }
        }
    }

    enum IconCanvasDrawMode
    {
        Preview,
        Select
    }
}
