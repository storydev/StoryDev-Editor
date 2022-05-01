using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class IconSets
    {

        public IconSet Items;

        public IconSets()
        {
            Items = new IconSet();
        }

    }

    class IconSet
    {

        public string FilePath;
        public int IconSize;

        public IconSet()
        {
            FilePath = "";
            IconSize = 32;
        }

    }
}
