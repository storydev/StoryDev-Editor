using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using StoryDev.Data;

namespace StoryDev.Components
{
    class IconSelect : Button
    {

        private Image iconset;

        [Browsable(false)]
        public IconSet IconSet { get; set; }

        public int IconIndex { get; set; }

        public IconSelect()
        {
            Size = new Size(68, 68);
            IconIndex = -1;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            var g = pevent.Graphics;

            if (IconIndex > -1 && IconSet != null)
            {
                if (iconset != null)
                    iconset.Dispose();

                if (File.Exists(IconSet.FilePath))
                    iconset = Image.FromFile(IconSet.FilePath);
            }

            if (iconset != null)
            {
                g.Clear(Color.White);

                var x = 0m;
                var y = 0m;

                if (IconIndex > 0)
                {
                    x = Math.Floor(IconIndex % (decimal)(iconset.Width / IconSet.IconSize)) * IconSet.IconSize;
                    y = Math.Floor(IconIndex / (decimal)(iconset.Width / IconSet.IconSize)) * IconSet.IconSize;
                }

                g.FillRectangle(Brushes.Blue, 2, 2, 64, 64);
                g.DrawImage(iconset, new Rectangle(2, 2, 64, 64), new Rectangle((int)x, (int)y, IconSet.IconSize, IconSet.IconSize), GraphicsUnit.Pixel);
            }
        }

    }
}
