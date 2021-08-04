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
    partial class FormDesignerUI : UserControl
    {

        private int mouseX;
        private int mouseY;


        private Pen mainBorderPen;

        private float gutter = 5;
        private float gapSize = 25;
        private float sides = 60;

        private float[][] grid;
        private int[][] staticWidths;
        private int[] staticHeights;
        private int currentColumn;
        private int currentRow;

        private PointF[] cells;
        private SizeF[] cellSizes;
        private Point[] cellLocations;

        public FormDesignerUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            InitializeComponent();

            mainBorderPen = new Pen(Color.FromArgb(12, 73, 158));
            mainBorderPen.Width = gutter;

            grid = new float[1][];
            grid[0] = new float[1];
            grid[0][0] = 1.0f;

            staticWidths = new int[1][];
            staticWidths[0] = new int[1];
            staticWidths[0][0] = -1;

            staticHeights = new int[1];
            staticHeights[0] = -1;

            RecalculateCells();
        }

        private void AddColumn(int row, int column = -1)
        {
            var tempWidths = staticWidths[row];
            var tempGrid = grid[row];

            if (column == -1)
                column = 0;

            float totalWidth = Width - sides - gutter / 2;
            float remWidth = totalWidth;

            for (int i = 0; i < tempWidths.Length; i++)
            {
                if (tempWidths[i] > -1)
                {
                    remWidth -= tempWidths[i];
                }
            }

            var newGrid = new float[tempGrid.Length + 1];
            var newWidths = new int[tempWidths.Length + 1];

            // if column is -1, create a column at the end

            var offset = 0;
            var nextOffset = false;
            var nextOffsetWidth = -1;
            var nextOffsetPerc = 0.0f;
            for (int i = 0; i < newGrid.Length; i++)
            {
                if (column > -1 && column == i)
                {
                    offset = 1;
                    var width = tempWidths[i];
                    //
                    // When adding a column, this is the location we add it to.
                    // Check if the width at this location in the previous state
                    // is -1 or greater.
                    //

                    if (width > -1)
                    {
                        // If width greater than -1, half the value and use it
                        // for both the new width and the last width.
                        // Percentage is irrelevant. Make this 0.0f for both values.

                        var half = width / 2;
                        newWidths[i] = half;
                        newGrid[i] = 0.0f;
                        nextOffset = true;
                        nextOffsetWidth = half;
                    }
                    else
                    {
                        // If percentage, calculate the new percentage based on the
                        // column percentage width last used, halved.
                        var half = tempGrid[i] / 2;
                        newWidths[i] = -1;
                        newGrid[i] = half;

                        nextOffset = true;
                        nextOffsetPerc = half;
                    }
                }
                else
                {
                    // this nextOffset determines if we have just created a column.
                    // This is ultimately the value for the new column.
                    if (nextOffset)
                    {
                        if (nextOffsetWidth > -1)
                        {
                            newGrid[i] = 0.0f;
                            newWidths[i] = nextOffsetWidth;
                        }
                        else
                        {
                            newGrid[i] = nextOffsetPerc;
                            newWidths[i] = -1;
                        }

                        nextOffset = false;
                    }
                    else
                    {
                        newGrid[i] = tempGrid[i - offset];
                        newWidths[i] = tempWidths[i - offset];
                    }
                }
            }

            staticWidths[row] = newWidths;
            grid[row] = newGrid;

            RecalculateCells();
            Invalidate();
        }

        private void AddRow(int row = -1, bool before = false)
        {
            var tempRows = staticHeights;
            var tempGridRows = grid;
            var tempWidthRows = staticWidths;

            var newRows = new int[tempRows.Length + 1];
            var newGridRows = new float[tempGridRows.Length + 1][];
            var newWidthRows = new int[tempWidthRows.Length + 1][];

            var offset = 0;
            for (int i = 0; i < newRows.Length; i++)
            {
                if (row > -1)
                {
                    if (before && row == i + 1)
                    {
                        offset = 1;
                        newRows[i] = -1;
                        newGridRows[i] = new float[1];
                        newGridRows[i][0] = 1.0f;
                        newWidthRows[i] = new int[1];
                        newWidthRows[i][0] = -1;
                        continue;
                    }
                    else if (row == i)
                    {
                        offset = 1;
                        newRows[i] = -1;
                        newGridRows[i] = new float[1];
                        newGridRows[i][0] = 1.0f;
                        newWidthRows[i] = new int[1];
                        newWidthRows[i][0] = -1;
                        continue;
                    }
                }

                newRows[i] = staticHeights[i - offset];
                newGridRows[i] = grid[i - offset];
                newWidthRows[i] = staticWidths[i - offset];
            }

            staticHeights = newRows;
            grid = newGridRows;
            staticWidths = newWidthRows;

            Invalidate();
        }

        private void RecalculateCells()
        {
            if (staticWidths == null)
                return;

            var cellCount = 0;
            for (int i = 0; i < staticWidths.Length; i++)
            {
                cellCount += staticWidths[i].Length;
            }

            cells = new PointF[cellCount];
            cellSizes = new SizeF[cellCount];
            cellLocations = new Point[cellCount];

            var cellIndex = 0;

            // Work out if a static width is greater than -1.
            // If greater than -1, use this as the pixel width for the column
            // in each row.
            // If -1, use the grid[][] values as percentage values.
            // When using percentage values, use the remaining width from the total width
            // of the container to determine it's pixel size.
            // e.g. if we have three values: 200 pixels, 40% and 60% with a total width
            // of 800 pixels, the widths are as follows:
            // 200 pixels, 240 pixels and 360 pixels = 800

            float totalWidth = Width - sides - gutter / 2;
            float remWidth = totalWidth;

            var startX = gapSize;
            var startY = gapSize;

            for (int i = 0; i < staticWidths.Length; i++)
            {
                float height;

                if (staticHeights[i] > -1)
                {
                    height = staticHeights[i];
                }
                else
                {
                    // @TODO: Need elements to progress.
                    // Temporary for testing
                    height = 100f;
                }

                // calculate remainder width
                for (int j = 0; j < staticWidths[i].Length; j++)
                {
                    if (staticWidths[i][j] > -1)
                    {
                        remWidth -= staticWidths[i][j];
                    }
                }

                // specify cell positions and sizes
                for (int j = 0; j < staticWidths[i].Length; j++)
                {
                    cells[cellIndex] = new PointF(startX + gapSize, startY + gapSize);
                    int width;

                    if (staticWidths[i][j] > -1)
                    {
                        width = staticWidths[i][j];
                    }
                    else
                    {
                        width = (int)(grid[i][j] * remWidth);
                    }

                    startX += width;

                    cellSizes[cellIndex] = new SizeF(width, height);
                    cellLocations[cellIndex] = new Point(j, i);
                    cellIndex++;
                }

                startX = gapSize;
                startY += height;
            }
        }

        private void ResolveCurrentLocation()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (mouseX > cells[i].X && mouseX < cells[i].X + cellSizes[i].Width &&
                    mouseY > cells[i].Y && mouseY < cells[i].Y + cellSizes[i].Height)
                {
                    currentRow = cellLocations[i].Y;
                    currentColumn = cellLocations[i].X;
                    return;
                }
            }

            currentRow = -1;
            currentColumn = -1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            g.Clear(Color.White);
            
            // draw the rows
            for (int i = 0; i < cells.Length; i++)
            {
                var position = cells[i];
                var size = cellSizes[i];
                var location = cellLocations[i];

                if (currentRow == location.Y && currentColumn == location.X)
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(125, 0, 40, 195)), position.X, position.Y, size.Width, size.Height);
                }

                g.DrawRectangle(mainBorderPen, position.X, position.Y, size.Width, size.Height);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            mouseX = e.Location.X;
            mouseY = e.Location.Y;

            ResolveCurrentLocation();
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            RecalculateCells();
        }

        private void addRowBeforeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRow(currentRow, true);
            RecalculateCells();
        }

        private void addRowAfterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRow(currentRow);
            RecalculateCells();
        }

        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = currentRow == -1 || currentColumn == -1;

            if (!e.Cancel)
            {
                var len = staticWidths[currentRow].Length;
                percentageWidthToolStripMenuItem.Enabled =
                    fixedWidthToolStripMenuItem.Enabled =
                    len > 1;

                if (staticWidths[currentRow][currentColumn] > -1)
                {
                    fixedWidthToolStripMenuItem.Checked = true;
                    percentageWidthToolStripMenuItem.Checked = false;
                    txtFixedWidth.Text = "" + staticWidths[currentRow][currentColumn];
                }
                else
                {
                    fixedWidthToolStripMenuItem.Checked = false;
                    percentageWidthToolStripMenuItem.Checked = true;
                    txtPercentageWidth.Text = "" + (grid[currentRow][currentColumn] * 100);
                }
            }
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddColumn(currentRow, currentColumn == 0 ? -1 : currentColumn);
            RecalculateCells();
        }

        private void txtPercentageWidth_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtPercentageWidth.Text, out int result))
                {
                    float percentage = (float)result / (float)100;
                    
                    fixedWidthToolStripMenuItem.Checked = false;
                    percentageWidthToolStripMenuItem.Checked = true;

                    grid[currentRow][currentColumn] = percentage;

                    RecalculateCells();
                    Invalidate();

                    cmsMain.Hide();
                    txtPercentageWidth.Text = "";
                }
                else
                {
                    MessageBox.Show("You must enter a valid numerical value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void evenDistributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var len = grid[currentRow].Length;
            var fixedNum = 0;
            for (int i = 0; i < len; i++)
            {
                if (staticWidths[currentRow][i] > -1)
                {
                    fixedNum++;
                }
            }

            len -= fixedNum;
            float percentage = (float)Math.Round(1.0f / (float)len, 2);

            for (int i = 0; i < grid[currentRow].Length; i++)
            {
                grid[currentRow][i] = percentage;
            }

            RecalculateCells();
            Invalidate();
        }

        private void txtFixedWidth_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtFixedWidth.Text, out int result))
                {
                    fixedWidthToolStripMenuItem.Checked = true;
                    percentageWidthToolStripMenuItem.Checked = false;

                    staticWidths[currentRow][currentColumn] = result;

                    RecalculateCells();
                    Invalidate();

                    cmsMain.Hide();
                    txtFixedWidth.Text = "";
                }
            }
        }
    }
}
