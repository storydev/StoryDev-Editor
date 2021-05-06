using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Forms;

namespace StoryDev.Components
{
    partial class BranchDesignerUI : UserControl
    {

        private Graphics g;
        private int mouseX;
        private int mouseY;
        private bool mouseReleased;
        private bool mouseDown;
        private MouseButtons mouseButton;

        private Pen selectedPen;
        private Pen subSelectedPen;
        private Font regularFont;

        private BranchView view;
        public BranchView View
        { 
            get
            {
                return view;
            }
            set
            {
                view = value;
                Invalidate();
            }
        }

        private PointF[] positions;
        private string[] names;
        private int[] levels;
        private bool[] manualMove;
        private bool[][] links;

        private int currentIndex = -1;
        private const int MAX_BRANCHES = 50;

        private const float BRANCH_WIDTH = 275f;
        private const float BRANCH_HEIGHT = 110f;

        private int selectedIndex = -1;
        private int movingIndex = -1;
        private int lastMouseX;
        private int lastMouseY;
        private int diffX;
        private int diffY;

        private float indent;

        private bool redraw = false;

        public BranchDesignerUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            selectedPen = new Pen(Brushes.Blue, 3f);
            subSelectedPen = new Pen(Brushes.Blue, 1f);
            subSelectedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            regularFont = new Font("Verdana", 8f);

            positions = new PointF[MAX_BRANCHES];
            names = new string[MAX_BRANCHES];
            levels = new int[MAX_BRANCHES];
            links = new bool[MAX_BRANCHES][];
            manualMove = new bool[MAX_BRANCHES];

            for (int i = 0; i < MAX_BRANCHES; i++)
            {
                positions[i] = PointF.Empty;
                names[i] = string.Empty;
                levels[i] = -1;
                links[i] = new bool[MAX_BRANCHES];
                for (int j = 0; j < MAX_BRANCHES; j++)
                {
                    links[i][j] = false;
                }
            }

            AddBranch(new PointF(50, 50), "Untitled");
        }

        public void AddBranch(PointF position, string name, int linkedFrom = -1)
        {
            currentIndex++;
            positions[currentIndex] = position;
            names[currentIndex] = name;
            if (linkedFrom > -1)
            {
                var parentLevel = levels[linkedFrom];
                levels[currentIndex] = parentLevel + 1;

                links[currentIndex][linkedFrom] = true;
                RecalculatePositions(linkedFrom);
            }
            else
            {
                levels[currentIndex] = 0;
            }

            Invalidate();
        }

        public void RecalculatePositions(int parentBranch)
        {
            var numChildren = 0;
            var level = 0;
            for (int i = 0; i <= currentIndex; i++)
            {
                if (levels[i] == levels[parentBranch] + 1 && !manualMove[i])
                {
                    level = levels[i];
                    numChildren++;
                }
            }

            var padding = 35f;
            var maxHeight = numChildren * (BRANCH_HEIGHT + padding - padding);
            var actualHeight = maxHeight - BRANCH_HEIGHT;

            var startPosY = (positions[parentBranch].Y + (BRANCH_HEIGHT / 2)) - (actualHeight / 2);
            var shiftValue = 0f;
            if (startPosY < 0)
            {
                shiftValue = -startPosY + padding;
                startPosY += shiftValue;
            }

            for (int i = 0; i <= currentIndex; i++)
            {
                if (shiftValue > 0f)
                {
                    positions[i].Y += shiftValue;
                }
            }

            for (int i = 0; i <= currentIndex; i++)
            {
                if (levels[i] == levels[parentBranch] + 1 && !manualMove[i])
                {
                    positions[i].X = positions[parentBranch].X + BRANCH_WIDTH + padding;
                    positions[i].Y = startPosY;
                    startPosY += BRANCH_HEIGHT + padding;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;

            g.Clear(Color.FromArgb(247, 247, 255));

            if (view == BranchView.Branch)
            {
                var cellsX = (int)Math.Ceiling(Width / 180f);
                var cellsY = (int)Math.Ceiling(Height / 100f);

                for (int x = 0; x < cellsX; x++)
                {
                    g.DrawLine(new Pen(Color.FromArgb(220, 220, 255)), x * 180f, 0, x * 180f, Height);
                }

                for (int y = 0; y < cellsY; y++)
                {
                    g.DrawLine(new Pen(Color.FromArgb(220, 220, 255)), 0, y * 100f, Width, y * 100f);
                }

                // draw branch links
                for (int i = 0; i <= currentIndex; i++)
                {
                    for (int j = 0; j <= currentIndex; j++)
                    {
                        var pen = Pens.Black;

                        if (selectedIndex > -1)
                        {
                            if (links[i][selectedIndex])
                                pen = selectedPen;
                        }

                        if (links[i][j])
                        {
                            var boxA = positions[j];
                            var boxB = positions[i];

                            var leftA = boxA.X + BRANCH_WIDTH;
                            var downA = boxA.Y + (BRANCH_HEIGHT / 2);

                            var rightB = boxB.X;
                            var topB = boxB.Y + (BRANCH_HEIGHT / 2);

                            g.DrawLine(pen, leftA, downA, rightB, topB);
                        }
                    }
                }

                // draw branches

                var toRenderLast = new bool[MAX_BRANCHES];
                for (int i = 0; i <= currentIndex; i++)
                {
                    if (selectedIndex > -1)
                    {
                        if (links[i][selectedIndex] || i == selectedIndex)
                        {
                            toRenderLast[i] = true;
                            continue;
                        }
                    }

                    if (Branch(i))
                    {
                        selectedIndex = i;
                        redraw = true;
                    }
                }

                for (int i = 0; i <= currentIndex; i++)
                {
                    if (toRenderLast[i])
                    {
                        if (Branch(i))
                        {
                            selectedIndex = i;
                            redraw = true;
                        }
                    }
                }

                var showingMenu = false;
                if (selectedIndex > -1 && mouseButton == MouseButtons.Right)
                {
                    cmsBranchOptions.Show(this, new Point(mouseX, mouseY));
                    showingMenu = true;
                }

                if (redraw && !showingMenu)
                {
                    redraw = false;
                    Invalidate();
                }
            }
            else if (view == BranchView.List)
            {
                var startY = 0f;
                for (int i = 0; i <= currentIndex; i++)
                {
                    if (ListItem(i, ref startY))
                    {
                        selectedIndex = i;
                    }
                }


            }

            mouseReleased = false;
            mouseButton = MouseButtons.None;
        }

        private bool ListItem(int index, ref float startY)
        {
            var text = names[index];

            var size = g.MeasureString(text, regularFont);
            var padding = 6;
            var active = IsMouseOver(0, (int)startY, Width, (int)(size.Height + padding * 2));

            g.DrawString(text, regularFont, Brushes.Black, padding, padding + startY);

            startY += size.Height + padding;

            return (active && mouseReleased);
        }

        private bool Branch(int index)
        {
            var position = positions[index];
            var text = names[index];

            var active = IsMouseOver((int)position.X, (int)position.Y, (int)BRANCH_WIDTH, (int)BRANCH_HEIGHT);
            var pen = Pens.Black;

            if (selectedIndex == index)
                pen = selectedPen;
            else if (selectedIndex > -1)
            {
                if (links[index][selectedIndex])
                    pen = subSelectedPen;
            }

            g.FillRectangle(Brushes.White, position.X, position.Y, BRANCH_WIDTH, BRANCH_HEIGHT);
            g.DrawRectangle(pen, position.X, position.Y, BRANCH_WIDTH, BRANCH_HEIGHT);

            var textBlockWidth = BRANCH_WIDTH * .9;

            var size = g.MeasureString(text, regularFont);
            if (size.Width < textBlockWidth)
            {
                textBlockWidth = size.Width;
            }

            var textX = ((BRANCH_WIDTH - textBlockWidth) / 2) + position.X;
            var textY = ((BRANCH_HEIGHT - size.Height) / 2) + position.Y;

            g.DrawString(text, regularFont, Brushes.Black, new RectangleF((float)textX, textY, (float)textBlockWidth, size.Height));

            return (mouseReleased && active);
        }

        private bool IsMouseOver(int x, int y, int w, int h)
        {
            return (mouseX >= x && mouseX <= x + w && mouseY >= y && mouseY <= y + h);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            mouseX = e.X;
            mouseY = e.Y;
            mouseReleased = true;
            mouseDown = false;
            mouseButton = e.Button;

            movingIndex = -1;

            var found = false;
            for (int i = 0; i <= currentIndex; i++)
            {
                var active = IsMouseOver((int)positions[i].X, (int)positions[i].Y, (int)BRANCH_WIDTH, (int)BRANCH_HEIGHT);
                if (active)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
                selectedIndex = -1;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mouseX = e.X;
            mouseY = e.Y;
            
            for (int i = 0; i <= currentIndex; i++)
            {
                var active = IsMouseOver((int)positions[i].X, (int)positions[i].Y, (int)BRANCH_WIDTH, (int)BRANCH_HEIGHT);
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

                manualMove[movingIndex] = true;
            }

            mouseDown = true;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (movingIndex > -1)
            {
                var diffX = e.X - lastMouseX;
                var diffY = e.Y - lastMouseY;

                positions[movingIndex].X += diffX;
                positions[movingIndex].Y += diffY;

                lastMouseX = e.X;
                lastMouseY = e.Y;
            }

            Invalidate();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1)
            {
                var editName = new SimpleEntryForm();
                editName.Text = "Rename Branch";
                editName.Value = names[selectedIndex];
                if (editName.ShowDialog() == DialogResult.OK)
                {
                    names[selectedIndex] = editName.Value;
                    Invalidate();
                }
            }
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1)
            {
                var create = new SimpleEntryForm();
                create.Text = "Rename Branch";
                if (create.ShowDialog() == DialogResult.OK)
                {
                    AddBranch(new PointF(1, 1), create.Value, selectedIndex);
                }
            }
        }
    }

    enum BranchView
    {
        Branch,
        List
    }
}
