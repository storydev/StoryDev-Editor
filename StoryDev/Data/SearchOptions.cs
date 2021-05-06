using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{

    [AttributeUsage(AttributeTargets.Field)]
    class SearchOptions : Attribute
    {

        public int Width;
        public bool Hidden;

        public SearchOptions(int width = 90, bool hidden = false)
        {
            Width = width;
            Hidden = hidden;
        }

    }
}
