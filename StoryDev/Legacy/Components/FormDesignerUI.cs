﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;
using StoryDev.Forms;
using System.Drawing;
using Point = System.Drawing.Point;

namespace StoryDev.Components
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    partial class FormDesignerUI : UserControl
    {

        private int mouseX;
        private int mouseY;

        private Pen elementHighlightPen;
        private Pen mainBorderPen;

        private float gutter = 5;
        private float gapSize = 25;
        private float sides = 60;

        private float[][] grid;
        private int[][] staticWidths;
        private int[] staticHeights;
        private int currentColumn;
        private int currentRow;

        private Font elementFont;
        private float elementLabelHeight;
        private float elementHeight;

        private PointF[] cells;
        private SizeF[] cellSizes;
        private Point[] cellLocations;

        private ElementType[] elementTypes;
        private Point[] elementLocations;
        private string[] elementFieldNames;

        public FormProperties Properties { get; set; }

        public FormDesignerUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            InitializeComponent();

            mainBorderPen = new Pen(Color.FromArgb(12, 73, 158));
            mainBorderPen.Width = gutter;

            elementHighlightPen = new Pen(Color.FromArgb(190, 211, 27), 2f);

            elementFont = new Font("Verdana", 12.0f);

            grid = new float[1][];
            grid[0] = new float[1];
            grid[0][0] = 1.0f;

            staticWidths = new int[1][];
            staticWidths[0] = new int[1];
            staticWidths[0][0] = -1;

            staticHeights = new int[1];
            staticHeights[0] = -1;

            elementTypes = new ElementType[0];
            elementLocations = new Point[0];
            elementFieldNames = new string[0];

            RecalculateCells();
        }

        private void AddElement(ElementType type, int cellX, int cellY, string fieldName)
        {
            var tempElements = elementTypes;
            var tempElementLocations = elementLocations;
            var tempElementFieldNames = elementFieldNames;

            var newElements = new ElementType[tempElements.Length + 1];
            var newElementLocations = new Point[tempElementLocations.Length + 1];
            var newElementFieldNames = new string[tempElementFieldNames.Length + 1];

            for (int i = 0; i < newElements.Length; i++)
            {
                if (i == newElements.Length - 1)
                {
                    newElements[i] = type;
                    newElementLocations[i] = new Point(cellX, cellY);
                    newElementFieldNames[i] = fieldName;
                }
                else
                {
                    newElements[i] = tempElements[i];
                    newElementLocations[i] = tempElementLocations[i];
                    newElementFieldNames[i] = tempElementFieldNames[i];
                }
            }

            elementTypes = newElements;
            elementLocations = newElementLocations;
            elementFieldNames = newElementFieldNames;
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
                    var autoHeights = new int[grid[i].Length];
                    var padding = 10;

                    for (int e = 0; e < elementTypes.Length; e++)
                    {
                        var location = elementLocations[e];
                        if (location.Y == i)
                        {
                            autoHeights[location.X] += GetHeightByType(elementTypes[e]) + padding;
                        }
                    }

                    var maxHeight = 0;
                    foreach (var auto in autoHeights)
                    {
                        if (maxHeight < auto)
                            maxHeight = auto;
                    }

                    if (maxHeight < 100f)
                        height = 100f;
                    else
                        height = maxHeight + padding;
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

        private int GetCellIndexByLocation(int x, int y)
        {
            for (int i = 0; i < cellLocations.Length; i++)
            {
                if (cellLocations[i].X == x && cellLocations[i].Y == y)
                {
                    return i;
                }
            }
            return -1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            if (elementLabelHeight == 0)
            {
                elementLabelHeight = g.MeasureString("M", elementFont).Height;
            }

            g.Clear(Color.White);

            var cellCompleteSizes = new float[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                cellCompleteSizes[i] = new float[grid[i].Length];
            }

            var startingElements = new float[grid.Length][];
            // draw the elements
            for (int i = 0; i < elementTypes.Length; i++)
            {
                var type = elementTypes[i];
                var location = elementLocations[i];
                var padding = 10;

                var cellIndex = GetCellIndexByLocation(location.X, location.Y);
                if (cellIndex > -1)
                {
                    if (startingElements[location.Y] == null)
                    {
                        startingElements[location.Y] = new float[grid[location.Y].Length];
                    }

                    var cellPosition = cells[cellIndex];
                    var cellSize = cellSizes[cellIndex];
                    var height = GetHeightByType(type);

                    var startY = startingElements[location.Y][location.X];

                    g.DrawRectangle(elementHighlightPen, cellPosition.X + padding, cellPosition.Y + padding + startY, cellSize.Width - (padding * 2), height);

                    startingElements[location.Y][location.X] += height + padding;
                }
            }

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
                    staticWidths[currentRow][currentColumn] = -1;

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

        private int GetHeightByType(ElementType type)
        {
            switch (type)
            {
                case ElementType._TEST:
                    return (int)(elementLabelHeight + elementHeight);
                default:
                    break;
            }

            return 0;
        }

        private void insertComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var insertForm = new AddElementForm();
            if (insertForm.ShowDialog() == DialogResult.OK)
            {
                

                RecalculateCells();
                Invalidate();
            }
        }
    }

    enum ElementType
    {
        _TEST,
        // Basic Elements
        InputSingle,
        InputMultiline,
        InputCode,
        Button,
        CheckBox,
        CheckList,
        ComboBox,
        Numeric,
        DatePicker,
        Label,
        IconSelector,
        // Advanced Elements
        ListBox,
        SingleLink,
        LinkedDetailedView,
        TabControl
    }


}