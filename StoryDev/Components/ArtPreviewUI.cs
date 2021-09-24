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
    partial class ArtPreviewUI : UserControl
    {

        private PointF[] positions;
        private SizeF[] sizes;
        private Color[] colors;

        private Image currentImage;
        public Image Image
        {
            get => currentImage;
            set
            {
                if (currentImage != null)
                {
                    currentImage.Dispose();
                }

                currentImage = value;
                Invalidate();
            }
        }

        public ArtPreviewUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            positions = new PointF[0];
            sizes = new SizeF[0];
            colors = new Color[0];
        }

        public int AddSection(PointF pos, SizeF size, Color color)
        {
            Globals.PushArray(ref positions, pos);
            Globals.PushArray(ref sizes, size);
            Globals.PushArray(ref colors, color);

            Invalidate();

            return positions.Length - 1;
        }

        public void EditSection(int index, PointF pos, SizeF size, Color color)
        {
            if (index > -1 && index < positions.Length - 1)
            {
                positions[index] = new PointF(pos.X, pos.Y);
                sizes[index] = new SizeF(size);
                colors[index] = Color.FromArgb(255, color);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            if (Image != null)
            {
                g.DrawImage(Image, new PointF(0, 0));

                for (int i = 0; i < positions.Length; i++)
                {
                    var pos = positions[i];
                    var size = sizes[i];
                    var color = colors[i];

                    g.DrawRectangle(new Pen(color), pos.X, pos.Y, size.Width, size.Height);
                }
            }


        }
    }
}
