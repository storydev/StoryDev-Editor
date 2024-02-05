using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    internal class TagValue
    {

        public string TagName { get; set; }
        public string Value { get; set; }

        public TagValue()
        {
            TagName = string.Empty;
            Value = string.Empty;
        }

    }
}
