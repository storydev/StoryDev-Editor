using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace StoryDev.Components
{
    internal partial class StoryFlowUI : UserControl
    {

        private Font regularFont;

        private bool mouseReleased;
        private bool mousePressed;
        private bool mouseDown;
        private float mouseX;
        private float mouseY;

        private int selectedIndex = -1;
        private int movingIndex = -1;
        private int lastMouseX;
        private int lastMouseY;
        private int diffX;
        private int diffY;
        private bool movingSelected;

        private float actualOffsetX;
        private float actualOffsetY;

        private int[] groupSizes;


        private DisplayContext context;
        private DisplayView view;

        public void SetGroupContext()
        {
            context = DisplayContext.Groups;
        }

        public void SetTagContext()
        {
            context = DisplayContext.Tags;
        }

        public void SetItemContext()
        {
            context = DisplayContext.Items;
        }

        public void SetHierarchyView()
        {
            view = DisplayView.Hierarchy;
        }

        public void SetListView()
        {
            view = DisplayView.List;
        }

        public StoryFlowUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            regularFont = new Font("Segoe UI", 8.5f, FontStyle.Regular);

            actualOffsetX = 0;
            actualOffsetY = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);
            var flow = Globals.CurrentProject.Flow;

            if (view == DisplayView.Hierarchy)
            {
                if (context == DisplayContext.Groups)
                {
                    groupSizes = new int[flow.Groups.Count];
                    for (int i = 0; i < flow.Groups.Count; i++)
                    {
                        groupSizes[i] = 50;
                        for (int j = 0; j < flow.Items.Count; j++)
                        {
                            if (flow.Items[j].GroupName == flow.Groups[i].Name)
                            {
                                groupSizes[i] += 1;
                            }
                        }
                    }

                    for (int i = 0; i < groupSizes.Length; i++)
                    {
                        var group = flow.Groups[i];
                        e.Graphics.DrawEllipse(new Pen(Color.FromArgb(180, 180, 0), 2.0f), new RectangleF(group.Position.X, group.Position.Y, groupSizes[i], groupSizes[i]));
                        var textSize = e.Graphics.MeasureString(group.Name, regularFont);
                        var padding = 3.0f;

                        var boxWidth = (textSize.Width + padding * 2);
                        var boxHeight = (textSize.Height + padding * 2);
                        var centerX = ((groupSizes[i] - boxWidth) / 2) + group.Position.X;
                        var y = group.Position.Y - (boxHeight / 2);

                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(180, 180, 0)), new RectangleF(centerX, y, boxWidth, boxHeight));
                        e.Graphics.DrawString(group.Name, regularFont, Brushes.White, centerX + padding, y + padding);


                    }

                    
                }
            }

            mouseReleased = false;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mouseX = e.X;
            mouseY = e.Y;

            if (context == DisplayContext.Groups)
            {
                var length = Globals.CurrentProject.Flow.Groups.Count;
                for (int i = 0; i < length; i++)
                {
                    var group = Globals.CurrentProject.Flow.Groups[i];
                    var active = IsMouseOver((int)(group.Position.X - actualOffsetX), (int)(group.Position.Y - actualOffsetY), groupSizes[i], groupSizes[i]);
                    if (active)
                    {
                        movingIndex = i;
                        break;
                    }
                }

                if (movingIndex > -1)
                {
                    lastMouseX = e.X;
                    lastMouseY = e.Y;
                }

                mouseDown = true;
            }

            
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (movingIndex > -1)
            {
                var diffX = e.X - lastMouseX;
                var diffY = e.Y - lastMouseY;

                this.diffX += diffX;
                this.diffY += diffY;

                if (context == DisplayContext.Groups)
                {
                    var groups = Globals.CurrentProject.Flow.Groups;
                    groups[movingIndex].Position.X += diffX;
                    groups[movingIndex].Position.Y += diffY;
                }

                lastMouseX = e.X;
                lastMouseY = e.Y;
                movingSelected = true;
            }

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            mouseX = e.X;
            mouseY = e.Y;
            mouseReleased = true;
            mouseDown = false;

            if (context == DisplayContext.Groups)
            {
                var groups = Globals.CurrentProject.Flow.Groups;
                //if (movingIndex > -1)
                //{
                //    groups[movingIndex].Position.X -= diffX;
                //    groups[movingIndex].Position.Y -= diffY;
                //}

                movingIndex = -1;

                var found = false;
                for (int i = 0; i < groups.Count; i++)
                {
                    var pos = groups[i].Position;
                    var active = IsMouseOver((int)(pos.X - actualOffsetX), (int)(pos.Y - actualOffsetY), groupSizes[i], groupSizes[i]);
                    if (active)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    selectedIndex = -1;
                }
            }

            diffX = 0;
            diffY = 0;
            Invalidate();
        }

        private bool IsMouseOver(int x, int y, int w, int h)
        {
            return (mouseX >= x && mouseX <= x + w && mouseY >= y && mouseY <= y + h);
        }




        public event OnGroupSelected GroupSelected;


        private enum DisplayContext
        {
            Groups,
            Tags,
            Items
        }

        private enum DisplayView
        {
            Hierarchy,
            List
        }
    }


}
