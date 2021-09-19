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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            if (Image != null)
            {
                g.DrawImage(Image, new PointF(0, 0));
            }
        }
    }
}
