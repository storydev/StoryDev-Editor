using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data.Art
{
    class SheetCell
    {

        public string Name;
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public Scale9Rect Scale9Rect;

        public SheetCell()
        {
            Scale9Rect = new Scale9Rect();
            Name = string.Empty;

            X = 0;
            Y = 0;
            Width = Height = 50;
        }

    }
}
