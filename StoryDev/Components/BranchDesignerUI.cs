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
        private Pen highlightPen;
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

        private bool snapping;
        public bool Snapping
        {
            get
            {
                return snapping;
            }
            set
            {
                snapping = value;
                Invalidate();
            }
        }

        private float actualOffsetX;
        private float actualOffsetY;

        private PointF[] positions;
        private string[] names;
        private int[] levels;
        private bool[] manualMove;
        private bool[][] links;
        private bool[] highlightRoute;

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
        private bool movingSelected;

        private float indent;

        private bool redraw = false;

        public BranchDesignerUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            selectedPen = new Pen(Brushes.Blue, 3f);
            highlightPen = new Pen(Brushes.LimeGreen, 2f);
            subSelectedPen = new Pen(Brushes.Blue, 1f);
            subSelectedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            regularFont = new Font("Verdana", 8f);

            Clear();
        }

        public void Clear()
        {
            selectedIndex = -1;
            movingIndex = -1;

            positions = new PointF[MAX_BRANCHES];
            names = new string[MAX_BRANCHES];
            levels = new int[MAX_BRANCHES];
            links = new bool[MAX_BRANCHES][];
            manualMove = new bool[MAX_BRANCHES];
            highlightRoute = new bool[MAX_BRANCHES];

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
        }

        public string ToFileData()
        {
            var result = "";

            for (int i = 0; i <= currentIndex; i++)
            {
                result += names[i] + "|";
                result += positions[i].X + "|";
                result += positions[i].Y;
                result += "\r\n";
            }

            result += "Links:\r\n";
            for (int i = 0; i <= currentIndex; i++)
            {
                for (int j = 0; j <= currentIndex; j++)
                {
                    result += "" + (links[i][j] ? 1 : 0);
                    if (j + 1 <= currentIndex)
                        result += "|";
                }
                result += "\r\n";
            }

            return result;
        }

        public void FromFileData(string contents)
        {
            Clear();

            var lines = contents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var isLinks = false;

            int startingLink = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var splitted = line.Split('|');
                if (line.StartsWith("Links:"))
                {
                    startingLink = i + 1;
                    isLinks = true;
                    continue;
                }

                if (!isLinks)
                {
                    var name = splitted[0];
                    var positionX = float.Parse(splitted[1]);
                    var positionY = float.Parse(splitted[2]);
                    var link = -1;
                    if (splitted.Length == 4)
                        link = int.Parse(splitted[3]);

                    AddBranch(new PointF(positionX, positionY), name, link);
                }
                else
                {
                    for (int j = 0; j <= currentIndex; j++)
                    {
                        links[i - startingLink][j] = int.Parse(splitted[j]) == 1;
                    }
                }
            }
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

        public int GetNameIndex(string name)
        {
            for (int i = 0; i <= currentIndex; i++)
            {
                if (names[i] == name)
                    return i;
            }
            return -1;
        }

        public string GetNameByIndex(int index)
        {
            if (index > -1 && index <= currentIndex)
            {
                return names[index];
            }
            return "";
        }

        public void SelectBranch(int index)
        {
            if (index <= currentIndex)
            {
                selectedIndex = index;
                Invalidate();
            }
        }

        public int[] GetChildren(int index)
        {
            var numChildren = 0;
            for (int i = 0; i <= currentIndex; i++)
            {
                if (links[i][index])
                {
                    numChildren++;
                }
            }

            var result = new int[numChildren];
            var k = 0;
            for (int i = 0; i <= currentIndex; i++)
            {
                if (links[i][index])
                {
                    result[k++] = i;
                }
            }

            return result;
        }

        public int GetSelectedIndex()
        {
            return selectedIndex;
        }

        private void RecalculatePositions(int parentBranch)
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
                var offsetX = 0f;
                var offsetY = 0f;

                var maxWidth = 0f;
                var maxHeight = 0f;

                for (int x = 0; x <= currentIndex; x++)
                {
                    if (positions[x].X + BRANCH_WIDTH > maxWidth)
                        maxWidth = positions[x].X + BRANCH_WIDTH;

                    if (positions[x].Y + BRANCH_HEIGHT > maxHeight)
                        maxHeight = positions[x].Y + BRANCH_HEIGHT;
                }

                maxWidth += 250f;
                maxHeight += 250f;

                if (movingIndex == -1)
                {
                    var remWidth = maxWidth - Width;
                    var remHeight = maxHeight - Height;

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
                }

                var cellWidth = (BRANCH_WIDTH / 2);
                var cellHeight = (BRANCH_HEIGHT / 2);
                var cellsX = (int)Math.Ceiling((maxWidth > Width ? maxWidth : Width) / cellWidth);
                var cellsY = (int)Math.Ceiling((maxHeight > Height ? maxHeight : Height) / cellHeight);

                for (int x = 0; x < cellsX; x++)
                {
                    g.DrawLine(new Pen(Color.FromArgb(220, 220, 255)), (x * cellWidth) - actualOffsetX, 0, (x * cellWidth) - actualOffsetX, Height);
                }

                for (int y = 0; y < cellsY; y++)
                {
                    g.DrawLine(new Pen(Color.FromArgb(220, 220, 255)), 0, (y * cellHeight) - actualOffsetY, Width, (y * cellHeight) - actualOffsetY);
                }

                if (!movingSelected && selectedIndex > -1)
                {
                    highlightRoute = new bool[MAX_BRANCHES];

                    var currentParent = selectedIndex;

                    for (int i = currentIndex; i > -1; i--)
                    {
                        if (links[currentParent][i])
                        {
                            highlightRoute[i] = true;
                            currentParent = i;
                        }
                    }
                }


                // draw branch links
                for (int i = 0; i <= currentIndex; i++)
                {
                    for (int j = 0; j <= currentIndex; j++)
                    {
                        var pen = Pens.Black;

                        if (selectedIndex > -1)
                        {
                            if (links[i][selectedIndex] && !highlightRoute[selectedIndex])
                                pen = selectedPen;
                            else if (highlightRoute[selectedIndex])
                                pen = highlightPen;
                        }

                        if (links[i][j])
                        {
                            var boxA = positions[j];
                            var boxB = positions[i];

                            var leftA = boxA.X + BRANCH_WIDTH;
                            var downA = boxA.Y + (BRANCH_HEIGHT / 2);

                            var rightB = boxB.X;
                            var topB = boxB.Y + (BRANCH_HEIGHT / 2);

                            g.DrawLine(pen, leftA - actualOffsetX, downA - actualOffsetY, rightB - actualOffsetX, topB - actualOffsetY);
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
                        BranchSelectedIndexChanged?.Invoke(selectedIndex);
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
                            BranchSelectedIndexChanged?.Invoke(selectedIndex);
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
            movingSelected = false;
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

            var active = IsMouseOver((int)(position.X - actualOffsetX), (int)(position.Y - actualOffsetY), (int)BRANCH_WIDTH, (int)BRANCH_HEIGHT);
            var pen = Pens.Black;

            if (selectedIndex == index)
                pen = selectedPen;
            else if (selectedIndex > -1)
            {
                if (highlightRoute[index])
                    pen = highlightPen;
                else if (links[index][selectedIndex])
                    pen = subSelectedPen;
            }

            g.FillRectangle(Brushes.White, position.X - actualOffsetX, position.Y - actualOffsetY, BRANCH_WIDTH, BRANCH_HEIGHT);
            g.DrawRectangle(pen, position.X - actualOffsetX, position.Y - actualOffsetY, BRANCH_WIDTH, BRANCH_HEIGHT);

            var textBlockWidth = BRANCH_WIDTH * .9;

            var size = g.MeasureString(text, regularFont);
            if (size.Width < textBlockWidth)
            {
                textBlockWidth = size.Width;
            }

            var textX = (((BRANCH_WIDTH - textBlockWidth) / 2) + position.X) - actualOffsetX;
            var textY = (((BRANCH_HEIGHT - size.Height) / 2) + position.Y) - actualOffsetY;

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

            // check a 5 pixel tolerance when snapping to determine a result outside it's original cell.
            if (movingIndex > -1 && snapping && (diffX > 5 || diffY > 5 || diffX < -5 || diffY < -5))
            {
                var cellX = BRANCH_WIDTH / 2;
                var cellY = BRANCH_HEIGHT / 2;

                var x = positions[movingIndex].X;
                var y = positions[movingIndex].Y;

                var tileX = Math.Floor(x / cellX) * cellX;
                var tileY = Math.Floor(y / cellY) * cellY;

                if (tileX < 0)
                    tileX = 0;

                if (tileY < 0)
                    tileY = 0;

                positions[movingIndex].X = (float)tileX;
                positions[movingIndex].Y = (float)tileY;
            }
            else if (movingIndex > -1 && snapping)
            {
                positions[movingIndex].X -= diffX;
                positions[movingIndex].Y -= diffY;
            }

            movingIndex = -1;

            var found = false;
            for (int i = 0; i <= currentIndex; i++)
            {
                var active = IsMouseOver((int)(positions[i].X - actualOffsetX), (int)(positions[i].Y - actualOffsetY), (int)BRANCH_WIDTH, (int)BRANCH_HEIGHT);
                if (active)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                selectedIndex = -1;
                BranchSelectedIndexChanged?.Invoke(selectedIndex);
            }

            diffX = 0;
            diffY = 0;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mouseX = e.X;
            mouseY = e.Y;
            
            for (int i = 0; i <= currentIndex; i++)
            {
                var active = IsMouseOver((int)(positions[i].X - actualOffsetX), (int)(positions[i].Y - actualOffsetY), (int)BRANCH_WIDTH, (int)BRANCH_HEIGHT);
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

                this.diffX += diffX;
                this.diffY += diffY;

                positions[movingIndex].X += diffX;
                positions[movingIndex].Y += diffY;

                lastMouseX = e.X;
                lastMouseY = e.Y;
                movingSelected = true;
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
                    if (editName.Value.Contains("|"))
                    {
                        MessageBox.Show("Names cannot contain the '|' character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        names[selectedIndex] = editName.Value;
                        BranchRenamed?.Invoke(selectedIndex, editName.Value);
                        Invalidate();
                    }
                }
            }
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedIndex > -1)
            {
                var create = new SimpleEntryForm();
                create.Text = "Create Branch";
                if (create.ShowDialog() == DialogResult.OK)
                {
                    if (create.Value.Contains("|"))
                    {
                        MessageBox.Show("Names cannot contain the '|' character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        AddBranch(new PointF(1, 1), create.Value, selectedIndex);
                        BranchAdded?.Invoke(create.Value);
                    }
                }
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        public event OnBranchSelectedIndexChanged BranchSelectedIndexChanged;
        public event OnBranchAdded BranchAdded;
        public event OnBranchRenamed BranchRenamed;
        
    }

    enum BranchView
    {
        Branch,
        List
    }
}
