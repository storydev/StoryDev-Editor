using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data.Art;

namespace StoryDev.Forms.ArtManager
{
    partial class StandardSheetPropertiesForm : Form
    {

        private int selectedCell;
        private List<SheetCell> cells;

        public StandardSheetPropertiesForm()
        {
            InitializeComponent();

            cells = new List<SheetCell>();
        }

        public void LoadFileData(string content)
        {
            var lines = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                var lineData = lines[i].Split('|');
                if (lineData.Length != 9) continue;

                // name
                var name = lineData[0];
                // x-pos
                if (int.TryParse(lineData[1], out int x)) continue;
                // y-pos
                if (int.TryParse(lineData[2], out int y)) continue;
                // width
                if (int.TryParse(lineData[3], out int width)) continue;
                // height
                if (int.TryParse(lineData[4], out int height)) continue;

                // scale-9
                if (int.TryParse(lineData[5], out int scale_top)) continue;
                if (int.TryParse(lineData[6], out int scale_bottom)) continue;
                if (int.TryParse(lineData[7], out int scale_left)) continue;
                if (int.TryParse(lineData[8], out int scale_right)) continue;

                var cell = new SheetCell();
                cell.Name = name;
                cell.X = x;
                cell.Y = y;
                cell.Width = width;
                cell.Height = height;
                cell.Scale9Rect.Top = scale_top;
                cell.Scale9Rect.Bottom = scale_bottom;
                cell.Scale9Rect.Left = scale_left;
                cell.Scale9Rect.Right = scale_right;

                cells.Add(cell);
            }

            PopulateList();
        }

        private void PopulateList()
        {
            lbSheetCells.Items.Clear();

            foreach (var cell in cells)
            {
                lbSheetCells.Items.Add(cell.Name);
            }
        }

        private void PopulateFields()
        {
            if (selectedCell > -1)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var entry = new SimpleEntryForm();
            entry.NotEmpty = true;
            if (entry.ShowDialog() == DialogResult.OK)
            {
                var cell = new SheetCell();
                cell.Name = entry.Value;
                cells.Add(cell);

                lbSheetCells.SelectedIndex = selectedCell = -1;
                PopulateList();
            }
        }

        private void lbSheetCells_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSheetCells.SelectedIndex > -1)
            {
                selectedCell = lbSheetCells.SelectedIndex;


            }
        }
    }
}
