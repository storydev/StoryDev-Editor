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

        private const float CIRCLE_DIAMETER = 48;

        private SPoint[] points;
        private bool[][] pointLinks;
        private int selectedPoint = -1;
        private int startConnectingIndex = -1;
        private int mouseX;
        private int mouseY;

        private Graphics g;
        private Pen connectionsPen;
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
                else
                {
                    img = null;
                }

                Invalidate();
            }
        }

        public bool BrowseOnly { get; set; }

        public int SelectedPoint 
        { 
            get
            {
                return selectedPoint;
            }
        }

        public MapsCanvas()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            connectionsPen = new Pen(Brushes.Blue, 3f);
            connectionsPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            BrowseOnly = false;
        }

        public void FreeResources()
        {
            if (img != null)
                img.Dispose();
        }

        public void StartConnections(int parent)
        {
            if (startConnectingIndex == parent)
                startConnectingIndex = -1;
            else 
                startConnectingIndex = parent;
        }

        public void SelectMap(int index)
        {
            var map = Globals.Maps[index];

            if (img != null)
            {
                img.Dispose();
            }

            imagePath = map.ImagePath;
            if (File.Exists(map.ImagePath))
            {
                img = Image.FromFile(map.ImagePath);
            }

            points = new SPoint[map.Points.Count];
            pointLinks = new bool[map.Points.Count][];
            for (int i = 0; i < map.Points.Count; i++)
            {
                var mp = map.Points[i];
                points[i] = mp.Point;
                pointLinks[i] = new bool[map.Points.Count];
                for (int j = 0; j < mp.Connections.Count; j++)
                {
                    pointLinks[i][mp.Connections[j]] = true;
                }
            }

            Invalidate();
        }

        public void AddAndSelectPoint(int x, int y)
        {
            var temp = new SPoint[points.Length + 1];
            var links = new bool[points.Length + 1][];
            var count = temp.Length;
            for (int i = 0; i < count; i++)
            {
                if (i + 1 <= count - 1)
                {
                    temp[i] = points[i];
                    links[i] = new bool[points.Length + 1];
                    for (int j = 0; j < points.Length; j++)
                    {
                        if (j + 1 <= count - 1)
                            links[i][j] = pointLinks[i][j];
                        else
                            links[i][j] = false;
                    }
                }
                else
                {
                    temp[i] = new SPoint();
                    temp[i].X = x;
                    temp[i].Y = y;

                    links[i] = new bool[points.Length + 1];
                    for (int j = 0; j < points.Length; j++)
                    {
                        if (j + 1 <= count - 1)
                            links[i][j] = false;
                    }
                }
            }

            points = temp;
            pointLinks = links;
            selectedPoint = count - 1;

            Invalidate();
        }

        public void SelectPoint(int index)
        {
            if (index < points.Length)
                selectedPoint = index;

            Invalidate();
        }

        public SPoint GetPointByIndex(int index)
        {
            if (index < points.Length)
                return points[index];

            return null;
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

                for (int i = 0; i < pointLinks.Length; i++)
                {
                    for (int j = 0; j < pointLinks[i].Length; j++)
                    {
                        if (pointLinks[i][j])
                        {
                            var from = points[i];
                            var to = points[j];

                            g.DrawLine(connectionsPen, from.X - actualOffsetX, from.Y - actualOffsetY, to.X - actualOffsetX, to.Y - actualOffsetY);
                        }
                    }
                }

                for (int i = 0; i < points.Length; i++)
                {
                    var p = points[i];
                    var x = p.X - (CIRCLE_DIAMETER / 2) - actualOffsetX;
                    var y = p.Y - (CIRCLE_DIAMETER / 2) - actualOffsetY;

                    g.FillEllipse(Brushes.DarkGray, new RectangleF(x, y, CIRCLE_DIAMETER, CIRCLE_DIAMETER));

                    if (selectedPoint == i)
                    {
                        var yellow = new Pen(Brushes.Yellow);
                        yellow.Width = 2;

                        g.DrawEllipse(yellow, new RectangleF(x, y, CIRCLE_DIAMETER, CIRCLE_DIAMETER));
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (!BrowseOnly)
            {
                if (startConnectingIndex > -1 && e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < points.Length; i++)
                    {
                        var p = points[i];
                        var x = p.X - (CIRCLE_DIAMETER / 2) - actualOffsetX;
                        var y = p.Y - (CIRCLE_DIAMETER / 2) - actualOffsetY;

                        if (IsMouseOver((int)x, (int)y, (int)CIRCLE_DIAMETER, (int)CIRCLE_DIAMETER))
                        {
                            var newValue = pointLinks[startConnectingIndex][i] = !pointLinks[startConnectingIndex][i];
                            if (newValue)
                                MapConnect?.Invoke(startConnectingIndex, i);
                            else
                                MapDisconnect?.Invoke(startConnectingIndex, i);

                            Invalidate();
                            break;
                        }
                    }
                }
                else if (selectedPoint > -1 && e.Button == MouseButtons.Left)
                {
                    var p = points[selectedPoint];
                    p.X = (int)(e.X + actualOffsetX);
                    p.Y = (int)(e.Y + actualOffsetY);
                    MapPointMoved?.Invoke(selectedPoint);
                    Invalidate();
                }
            }
            else
            {
                for (int i = 0; i < points.Length; i++)
                {
                    var p = points[i];
                    var x = p.X - (CIRCLE_DIAMETER / 2) - actualOffsetX;
                    var y = p.Y - (CIRCLE_DIAMETER / 2) - actualOffsetY;

                    if (IsMouseOver((int)x, (int)y, (int)CIRCLE_DIAMETER, (int)CIRCLE_DIAMETER))
                    {
                        selectedPoint = i;
                        break;
                    }
                }

                Invalidate();
            }
        }

        private bool IsMouseOver(int x, int y, int width, int height)
        {
            var result = (mouseX > x && mouseX < x + width && mouseY > y && mouseY < y + height);
            return result;
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        public event OnMapPointMoved MapPointMoved;
        public event OnMapConnect MapConnect;
        public event OnMapDisconnect MapDisconnect;

    }
}
