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

using StoryDev.Forms;
using StoryDev.Data;

namespace StoryDev.Components
{
    partial class StoryOrderDesigner : UserControl
    {

        private Font regularFont;
        private Font smallerFont;

        private Graphics g;
        private int mouseX;
        private int mouseY;
        private bool mouseDown;
        private bool mouseReleased;
        private int mouseDelta;

        private float totalTimelineWidth = 350.0f;

        private string[] timelineNames;
        private PointF[] timelinePositions;
        private int[] timelineConnectedTo;
        private int[] timelineConnectedPosition;
        private bool[] timelineOpen;
        private bool[] timelineVisible;
        private float[] timelineTotalHeight;

        private SizeF iconSize = new SizeF(24, 24);
        private Image convoIcon;

        // Database objects
        private IEnumerable<Timeline> timelines;
        private Dictionary<int, IEnumerable<TimelineElement>> timelineElements;

        private int activeTimelineIndex;
        public int ActiveTimelineIndex
        {
            get => activeTimelineIndex;
        }

        public StoryOrderDesigner()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            regularFont = new Font("Segoe UI", 10.0f, FontStyle.Regular);
            smallerFont = new Font("Segoe UI", 8.0f, FontStyle.Regular);

            convoIcon = Properties.Resources.Conversation;


            timelineElements = new Dictionary<int, IEnumerable<TimelineElement>>();

            PopulateTimelines();

            Invalidate();
        }

        public Timeline GetActiveTimeline()
        {
            return timelines.ElementAt(activeTimelineIndex);
        }

        public void AddTimeline(string name)
        {
            var timeline = new Timeline();
            timeline.Name = name;
            timeline.PositionX = 50;
            timeline.PositionY = 50;
            timeline.Insert();

            var found = false;
            foreach (var chapter in Globals.Chapters)
            {
                if (chapter == name)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                var fullChapterPath = Path.Combine(Globals.CurrentProjectFolder, "Chapters", name);
                Directory.CreateDirectory(fullChapterPath);
            }

            PopulateTimelines();
        }

        public void AddConversation(int timelineIndex, string name)
        {
            var conversation = new TimelineElement();
            conversation.TimelineID = timelines.ElementAt(timelineIndex).ID;
            conversation._Order = timelineElements[timelineIndex].Count() + 1;
            conversation.Type = (int)ElementType.Conversation;
            conversation.Name = name;
            conversation.Insert();

            PopulateElementsForTimeline(timelineIndex);
        }

        private void PopulateTimelines()
        {
            timelines = Globals.MainProjectDatabase.Search<Timeline>();

            timelineNames = new string[timelines.Count()];
            timelinePositions = new PointF[timelines.Count()];
            timelineConnectedTo = new int[timelines.Count()];
            timelineConnectedPosition = new int[timelines.Count()];
            timelineOpen = new bool[timelines.Count()];
            timelineVisible = new bool[timelines.Count()];
            timelineTotalHeight = new float[timelines.Count()];

            for (int i = 0; i < timelines.Count(); i++)
            {
                var timeline = timelines.ElementAt(i);
                // during testing, timelines have already been created
                // this code is just to cover myself
                var found = false;
                foreach (var chapter in Globals.Chapters)
                {
                    if (chapter == timeline.Name)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    var fullChapterPath = Path.Combine(Globals.CurrentProjectFolder, "Chapters", timeline.Name);
                    Directory.CreateDirectory(fullChapterPath);
                }

                timelineNames[i] = timeline.Name;
                timelinePositions[i] = new PointF(timeline.PositionX, timeline.PositionY);
                timelineConnectedTo[i] = timeline.ParentTimeline;
                timelineConnectedPosition[i] = timeline.ParentPosition;
                timelineOpen[i] = false;
                timelineTotalHeight[i] = 0.0f;

                if (timeline.ParentTimeline == -1)
                    timelineVisible[i] = true;
                else
                    timelineVisible[i] = false;
            }

            Invalidate();
        }

        private void PopulateElementsForTimeline(int index)
        {
            var timeline = timelines.ElementAt(index);
            DBO.Searching.Order("_Order", DBO.OrderMethod.Ascending);
            var results = Globals.MainProjectDatabase.Search<TimelineElement>(new DBO.DBFilter()
            {
                FieldName = "TimelineID",
                Operator = DBO.DBOperator.Equals,
                ConditionValue = timeline.ID
            });

            if (!timelineElements.ContainsKey(index))
            { 
                timelineElements.Add(index, results);
            }
            else
            {
                timelineElements[index] = results;
            }
        }

        private void FindResetAndOpenIndex(int index)
        {
            var current = timelineConnectedTo[index];
            for (int i = 0; i < timelines.Count(); i++)
            {
                if (timelineConnectedTo[i] == current && timelineOpen[i])
                {
                    timelineOpen[i] = false;
                }
            }

            timelineOpen[index] = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(Color.FromArgb(196, 196, 196));

            for (int i = 0; i < timelineTotalHeight.Length; i++)
            {
                timelineTotalHeight[i] = 0.0f;
            }

            for (int i = 0; i < timelineNames.Length; i++)
            {
                if (BeginTimeline(i) && timelineOpen[i])
                {
                    if (!timelineElements.ContainsKey(i))
                    {
                        EndTimeline(i);
                        continue;
                    }

                    for (int j = 0; j < timelineElements[i].Count(); j++)
                    {
                        var element = timelineElements[i].ElementAt(j);
                        if (element.Type == (int)ElementType.Conversation)
                        {
                            DrawConversation(i, j, element.Name);
                        }
                    }

                    EndTimeline(i);
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

        private int[] GetAllTimelinesConnectedTo(int timeline, int position)
        {
            var results = new List<int>();
            for (int i = 0; i < timelineConnectedTo.Length; i++)
            {
                if (timelineConnectedTo[i] == timeline && timelineConnectedPosition[i] == position)
                {
                    results.Add(i);
                }
            }
            return results.ToArray();
        }

        private bool BeginTimeline(int index)
        {
            PointF startPosition = timelinePositions[index];
            float padding = 4.0f;
            SizeF textSize = g.MeasureString(timelineNames[index], regularFont);
            SizeF totalBarSize = new SizeF(textSize.Width + padding * 2, textSize.Height + padding * 2);
            var active = IsMouseOver((int)startPosition.X, (int)startPosition.Y, (int)totalTimelineWidth, (int)totalBarSize.Height);

            g.FillRectangle(Brushes.Blue, new RectangleF(startPosition.X, startPosition.Y, totalTimelineWidth, totalBarSize.Height));
            g.DrawString(timelineNames[index], regularFont, Brushes.White, startPosition.X + padding, startPosition.Y + padding);

            if (active && mouseReleased)
            {
                if (activeTimelineIndex == index)
                {
                    activeTimelineIndex = -1;
                    timelineOpen[index] = false;
                }
                else
                {
                    activeTimelineIndex = index;
                    FindResetAndOpenIndex(index);
                    PopulateElementsForTimeline(index);
                    TimelineActivated?.Invoke();
                }
            }

            timelineTotalHeight[index] += totalBarSize.Height;

            return activeTimelineIndex == index;
        }

        private void DrawConversation(int timelineIndex, int elementIndex, string name)
        {
            var padding = 4.0f;
            var position = timelinePositions[timelineIndex];
            var offsetY = timelineTotalHeight[timelineIndex] + padding;
            var contentX = position.X + iconSize.Width + padding;
            var boxHeight = 24.0f + (padding * 2);

            var active = IsMouseOver((int)position.X, (int)(position.Y + offsetY), (int)totalTimelineWidth, (int)boxHeight);

            g.FillRectangle(Brushes.White, position.X, position.Y + timelineTotalHeight[timelineIndex], totalTimelineWidth, boxHeight);
            g.DrawImage(convoIcon, position.X + 2, position.Y + offsetY, iconSize.Width, iconSize.Height);
            g.DrawString(name, regularFont, Brushes.Black, contentX, position.Y + offsetY);

            var hasExpander = GetAllTimelinesConnectedTo(timelineIndex, elementIndex).Length > 0;
            if (hasExpander)
            {
                // draw expander
            }

            var plusSign = g.MeasureString("+", smallerFont);
            var rectAddConnection = new RectangleF(position.X + totalTimelineWidth - plusSign.Width - padding,
                position.Y + offsetY + ((boxHeight - plusSign.Height) / 2), plusSign.Width, boxHeight);
            var isPlusActive = IsMouseOver((int)rectAddConnection.X, (int)rectAddConnection.Y, (int)rectAddConnection.Width, (int)rectAddConnection.Height);
            var plusColor = Color.FromArgb(128, 128, 128);
            if (isPlusActive)
            {
                plusColor = Color.FromArgb(77, 77, 77);
            }

            g.DrawString("+", smallerFont, new SolidBrush(plusColor), rectAddConnection.X, rectAddConnection.Y);

            if (isPlusActive && mouseReleased)
            {

            }

            if (active && mouseReleased)
            {
                var convoPath = Path.Combine(Globals.CurrentProjectFolder, "Chapters",
                    timelines.ElementAt(timelineIndex).Name,
                    timelineElements[timelineIndex].ElementAt(elementIndex).Name);

                RequestOpenForm?.Invoke(FormType.Form_ConversationEditor, new string[] { convoPath });
            }

            timelineTotalHeight[timelineIndex] += boxHeight;
        }

        private void EndTimeline(int timelineIndex)
        {
            var position = timelinePositions[timelineIndex];
            // draw left border
            g.DrawLine(Pens.Blue, position.X, position.Y, position.X, position.Y + timelineTotalHeight[timelineIndex]);
            // draw right border
            g.DrawLine(Pens.Blue, position.X + totalTimelineWidth, position.Y, position.X + totalTimelineWidth, position.Y + timelineTotalHeight[timelineIndex]);
            // draw bottom border
            g.DrawLine(Pens.Blue, position.X, position.Y + timelineTotalHeight[timelineIndex], position.X + totalTimelineWidth, position.Y + timelineTotalHeight[timelineIndex]);
        }

        private bool IsMouseOver(int x, int y, int width, int height)
        {
            return (mouseX > x && mouseX < x + width && mouseY > y && mouseY < y + height);
        }

        public event OnTimelineActivated TimelineActivated;
        public event OnRequestOpenForm RequestOpenForm;

    }
}
