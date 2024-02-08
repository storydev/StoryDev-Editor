using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    internal class Group
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public List<TagValue> Tags { get; set; }
        public PointF Position;

        public Group()
        {
            Name = string.Empty;
            Description = string.Empty;
            Tags = new List<TagValue>();
            Position = new PointF();
        }

    }
}
