using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;

namespace StoryDev.Components
{
    partial class StoryOrderDesigner : UserControl
    {

        private Font regularFont;

        private Graphics g;
        private int mouseX;
        private int mouseY;
        private bool mouseDown;
        private bool mouseReleased;
        private int mouseDelta;

        private string[] timelineNames;
        private PointF[] timelinePositions;
        private int[] timelineConnectedTo;
        private int[] timelineConnectedPosition;
        private bool[] timelineOpen;

        // Database objects
        private IEnumerable<Timeline> timelines;

        private int activeTimeline;
        public int ActiveTimeline
        {
            get => activeTimeline;
        }

        public StoryOrderDesigner()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            regularFont = new Font("Segoe UI", 10.0f, FontStyle.Regular);

            PopulateTimelines();

            Invalidate();
        }

        public void AddTimeline(string name)
        {
            var timeline = new Timeline();
            timeline.Name = name;
            timeline.PositionX = 50;
            timeline.PositionY = 50;
            timeline.Insert();

            PopulateTimelines();
        }

        private void PopulateTimelines()
        {
            timelines = Globals.MainProjectDatabase.Search<Timeline>();

            timelineNames = new string[timelines.Count()];
            timelinePositions = new PointF[timelines.Count()];
            timelineConnectedTo = new int[timelines.Count()];
            timelineConnectedPosition = new int[timelines.Count()];
            timelineOpen = new bool[timelines.Count()];

            for (int i = 0; i < timelines.Count(); i++)
            {
                var timeline = timelines.ElementAt(i);
                timelineNames[i] = timeline.Name;
                timelinePositions[i] = new PointF(timeline.PositionX, timeline.PositionY);
                timelineConnectedTo[i] = timeline.ParentTimeline;
                timelineConnectedPosition[i] = timeline.ParentPosition;
                timelineOpen[i] = false;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(Color.White);

            for (int i = 0; i < timelineNames.Length; i++)
            {
                if (BeginTimeline(i))
                {


                    EndTimeline();
                }
            }

            mouseReleased = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            mouseDown = false;
            mouseReleased = true;
            Invalidate();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            mouseDelta = e.Delta;
            Invalidate();
        }

        private bool BeginTimeline(int index)
        {
            PointF startPosition = timelinePositions[index];
            float totalWidth = 350.0f;
            float padding = 4.0f;
            SizeF textSize = g.MeasureString(timelineNames[index], regularFont);
            SizeF totalBarSize = new SizeF(textSize.Width + padding * 2, textSize.Height + padding * 2);
            var active = IsMouseOver((int)startPosition.X, (int)startPosition.Y, (int)totalWidth, (int)totalBarSize.Height);

            g.FillRectangle(Brushes.Blue, new RectangleF(startPosition.X, startPosition.Y, totalWidth, totalBarSize.Height));
            g.DrawString(timelineNames[index], regularFont, Brushes.White, startPosition.X + padding, startPosition.Y + padding);

            if (active && mouseReleased)
            {
                if (activeTimeline == index)
                {
                    activeTimeline = -1;
                }
                else
                {
                    activeTimeline = index;
                }


            }

            return activeTimeline == index;
        }

        private void EndTimeline()
        {

        }

        private bool IsMouseOver(int x, int y, int width, int height)
        {
            return (mouseX > x && mouseX < x + width && mouseY > y && mouseY < y + height);
        }
    }
}
