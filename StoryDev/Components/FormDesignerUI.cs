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

        private Pen mainBorderPen;

        private float gutter = 5;
        private float gapSize = 25;
        private float sides = 60;

        private float[][] grid;
        private int[][] staticWidths;
        private int[] staticHeights;
        private int currentColumn;
        private int currentRow;

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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

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
            float startX = sides, startY = sides;

            float remWidth = totalWidth;

            for (int i = 0; i < staticWidths.Length; i++)
            {
                for (int j = 0; j < staticWidths.Length; j++)
                {
                    if (staticWidths[i][j] > -1)
                    {
                        remWidth -= staticWidths[i][j];
                    }
                }
            }
            
            // draw the row
            for (int i = 0; i < staticWidths.Length; i++)
            {
                var offsetX = 0f;
                var height = 0f;

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

                for (int j = 0; j < staticWidths[i].Length; j++)
                {
                    if (staticWidths[i][j] > -1)
                    {
                        g.DrawRectangle(mainBorderPen, startX + offsetX, startY, staticWidths[i][j], height);

                        offsetX += staticWidths[i][j];
                    }
                    else
                    {
                        var perc = grid[i][j];
                        var width = perc * remWidth;

                        g.DrawRectangle(mainBorderPen, startX + offsetX, startY, width, height);
                    }
                }

                startY += height;
            }
        }
    }
}
