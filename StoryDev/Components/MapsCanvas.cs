using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using StoryDev.Data;
using SPoint = StoryDev.Data.Point;

namespace StoryDev.Components
{
    partial class MapsCanvas : UserControl
    {

        private SPoint[] points;
        private SPoint[][] regions;

        private Graphics g;
        private Image img;

        private float actualOffsetX;
        private float actualOffsetY;

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
                if (img != null)
                {
                    img.Dispose();
                }

                if (File.Exists(imagePath))
                {
                    img = Image.FromFile(imagePath);
                }

                Invalidate();
            }
        }

        public MapsCanvas()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();
        }

        public void FreeResources()
        {
            if (img != null)
                img.Dispose();
        }

        public void SelectMap(int index)
        {
            var map = Globals.Maps[index];

            if (img != null)
            {
                img.Dispose();
            }
            
            if (File.Exists(map.ImagePath))
            {
                img = Image.FromFile(map.ImagePath);
            }

            points = new SPoint[map.Points.Count];
            for (int i = 0; i < map.Points.Count; i++)
            {
                var mp = map.Points[i];
                points[i] = mp.Point;
            }

            regions = new SPoint[map.Regions.Count][];
            for (int i = 0; i < map.Regions.Count; i++)
            {
                var region = map.Regions[i];
                regions[i] = new SPoint[region.Points.Count];
                for (int j = 0; j < region.Points.Count; j++)
                {
                    regions[i][j] = region.Points[j];
                }
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;

            g.Clear(Color.FromArgb(64, 64, 64));
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            if (img != null)
            {
                var offsetX = 0f;
                var offsetY = 0f;

                var remWidth = img.PhysicalDimension.Width - Width;
                var remHeight = img.PhysicalDimension.Height - Height;

                hScrollBar.Visible = remWidth > 0;
                vScrollBar.Visible = remHeight > 0;

                if (remWidth > 0)
                {
                    offsetX = (float)hScrollBar.Value / (float)hScrollBar.Maximum;
                    actualOffsetX = offsetX * remWidth;
                }
                else
                {
                    actualOffsetX = 0f;
                }

                if (remHeight > 0)
                {
                    offsetY = (float)vScrollBar.Value / (float)vScrollBar.Maximum;
                    actualOffsetY = offsetY * remHeight;
                }
                else
                {
                    actualOffsetY = 0f;
                }

                g.DrawImage(img, -actualOffsetX, -actualOffsetY, img.PhysicalDimension.Width, img.PhysicalDimension.Height);


            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }
    }
}
