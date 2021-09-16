using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components
{
    partial class SceneDesignerUI : UserControl
    {

        private Graphics g;
        private Bitmap buffer;
        private bool redrawNeeded;
        private bool mouseDown;

        // SOA for faster caching.

        private SceneElementType[] elementTypes;
        private PointF[] elementStarts;
        private PointF[] elementEnds;
        private Color[] elementForeColors;
        private Color[] elementBackColors;

        private SceneElementType drawType;
        private PointF drawBegin;
        private PointF drawEnd;

        private readonly float canvasMargin = 75;
        private readonly float canvasCellSize = 64;

        public Color DrawBackColor;
        public Color DrawForeColor;

        public SceneDesignerUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            elementTypes = new SceneElementType[0];
            elementBackColors = new Color[0];
            elementEnds = new PointF[0];
            elementForeColors = new Color[0];
            elementStarts = new PointF[0];

            buffer = new Bitmap(1024, 768);
            redrawNeeded = true;
        }

        public void FreeResources()
        {
            buffer.Dispose();
        }

        public void StartDrawElement(SceneElementType type)
        {
            drawType = type;
        }


        private void AddElement(SceneElementType type)
        {
            PushArray(ref elementTypes, type);

            var startX = drawBegin.X;
            var startY = drawBegin.Y;
            var endX = drawEnd.X;
            var endY = drawEnd.Y;

            if (type == SceneElementType.DrawCircle)
            {
                var centerX = drawBegin.X;
                var centerY = drawBegin.Y;
                var radius = 0f;

                if (drawEnd.X >= drawEnd.Y)
                    radius = drawEnd.X - centerX;
                else
                    radius = drawEnd.Y - centerY;

                if (radius < 0)
                    radius = -radius;

                startX = centerX - (radius * 2);
                startY = centerY - (radius * 2);
                endX = radius * 2;
                endY = radius * 2;
            }
            else
            {
                startX -= canvasMargin;
                startY -= canvasMargin;
                endX -= canvasMargin;
                endY -= canvasMargin;
            }


            PushArray(ref elementStarts, new PointF(startX, startY));
            PushArray(ref elementEnds, new PointF(endX, endY));
            PushArray(ref elementForeColors, Color.FromArgb(DrawForeColor.A, DrawForeColor.R, DrawForeColor.G, DrawForeColor.B));
            PushArray(ref elementBackColors, Color.FromArgb(DrawBackColor.A, DrawBackColor.R, DrawBackColor.G, DrawBackColor.B));
        }

        private void PushArray<T>(ref T[] arr, T obj)
        {
            var temp = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++) temp[i] = arr[i];
            temp[arr.Length] = obj;
            arr = temp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;

            g.Clear(Color.FromArgb(64, 64, 64));

            var colCount = Math.Ceiling(Width / canvasCellSize);
            var rowCount = Math.Ceiling(Height / canvasCellSize);

            // draw grid
            for (int y = 0; y < rowCount; y++)
            {
                g.DrawLine(new Pen(Color.FromArgb(48, 48, 48)), 0, y * canvasCellSize, Width, y * canvasCellSize);
            }

            for (int x = 0; x < colCount; x++)
            {
                g.DrawLine(new Pen(Color.FromArgb(48, 48, 48)), x * canvasCellSize, 0, x * canvasCellSize, Height);
            }

            if (redrawNeeded)
            {
                using (Graphics backBuffer = Graphics.FromImage(buffer))
                {
                    backBuffer.Clear(Color.Black);
                    // draw elements
                    for (int i = 0; i < elementTypes.Length; i++)
                    {
                        var type = elementTypes[i];
                        var foreColor = elementForeColors[i];
                        var backColor = elementBackColors[i];
                        var start = elementStarts[i];
                        var end = elementEnds[i];

                        if (type == SceneElementType.DrawLine)
                        {
                            backBuffer.DrawLine(new Pen(foreColor), start.X, start.Y, 
                                end.X, end.Y);
                        }
                        else if (type == SceneElementType.DrawRect)
                        {
                            var x = start.X;
                            var y = start.Y;
                            var w = 0f;
                            var h = 0f;

                            if (end.X < x)
                            {
                                x = end.X;
                                w = start.X - end.X;
                            }
                            else
                                w = end.X - start.X;

                            if (end.Y < y)
                            {
                                y = end.Y;
                                h = start.Y - end.Y;
                            }
                            else
                                h = end.Y - start.Y;

                            backBuffer.FillRectangle(new SolidBrush(backColor), x, y, w, h);
                            backBuffer.DrawRectangle(new Pen(foreColor), x, y, w, h);
                        }
                        else if (type == SceneElementType.DrawCircle)
                        {
                            backBuffer.FillEllipse(new SolidBrush(backColor), start.X, start.Y, end.X, end.Y);
                            backBuffer.DrawEllipse(new Pen(foreColor), start.X, start.Y, end.X, end.Y);
                        }
                    }
                }

                redrawNeeded = false;
            }

            g.DrawImageUnscaled(buffer, (int)canvasMargin, (int)canvasMargin);

            // draw canvas boundaries
            g.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2), canvasMargin, 0, canvasMargin, Height);
            g.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2), 0, canvasMargin, Width, canvasMargin);

            if (drawType != SceneElementType.DrawNone)
            {
                if (drawType == SceneElementType.DrawLine)
                {
                    g.DrawLine(new Pen(DrawForeColor), drawBegin.X, drawBegin.Y, drawEnd.X, drawEnd.Y);
                }
                else if (drawType == SceneElementType.DrawRect)
                {
                    var x = drawBegin.X;
                    var y = drawBegin.Y;
                    var w = 0f;
                    var h = 0f;

                    if (drawEnd.X < x)
                    {
                        x = drawEnd.X;
                        w = drawBegin.X - drawEnd.X;
                    }
                    else
                        w = drawEnd.X - drawBegin.X;

                    if (drawEnd.Y < y)
                    {
                        y = drawEnd.Y;
                        h = drawBegin.Y - drawEnd.Y;
                    }
                    else
                        h = drawEnd.Y - drawBegin.Y;

                    g.FillRectangle(new SolidBrush(DrawBackColor), x, y, w, h);
                    g.DrawRectangle(new Pen(DrawForeColor), x, y, w, h);
                }
                else if (drawType == SceneElementType.DrawCircle)
                {
                    var centerX = drawBegin.X;
                    var centerY = drawBegin.Y;
                    var radius = 0f;

                    if (drawEnd.X >= drawEnd.Y)
                        radius = drawEnd.X - centerX;
                    else
                        radius = drawEnd.Y - centerY;

                    if (radius < 0)
                        radius = -radius;

                    g.FillEllipse(new SolidBrush(DrawBackColor), centerX - radius, centerY - radius, radius * 2, radius * 2);
                    g.DrawEllipse(new Pen(DrawForeColor), centerX - radius, centerY - radius, radius * 2, radius * 2);
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (drawType != SceneElementType.DrawNone && e.Button == MouseButtons.Left)
            {
                drawBegin = new PointF(e.X, e.Y);
                drawEnd = new PointF(e.X, e.Y);
                Invalidate();
            }

            mouseDown = true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (drawType != SceneElementType.DrawNone && mouseDown)
            {
                drawEnd = new PointF(e.X, e.Y);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (drawType != SceneElementType.DrawNone)
            {
                AddElement(drawType);
                drawBegin = new PointF(-1, -1);
                drawEnd = new PointF(-1, -1);
                redrawNeeded = true;

                Invalidate();
            }

            mouseDown = false;
        }
    }

    enum SceneElementType
    {
        DrawNone,
        DrawLine,
        DrawRect,
        DrawCircle,
        DrawTriangle,
        DrawImage,
        DrawText
    }
}
