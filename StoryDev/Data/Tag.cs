﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    internal class Tag
    {

        public string Name { get; set; }
        public Color Color { get; set; }
        public Dictionary<string, string> Values { get; set; }
        public TagApplication Application { get; set; }

        public Tag()
        {
            Name = string.Empty;
            Application = TagApplication.Both;
        }

    }
}
