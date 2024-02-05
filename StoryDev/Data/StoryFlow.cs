using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    internal class StoryFlow
    {

        public List<Group> Groups { get; set; }
        public List<Tag> Tags { get; set; }
        public List<StoryItem> Items { get; set; }

        public StoryFlow()
        {
            Groups = new List<Group>();
            Tags = new List<Tag>();
            Items = new List<StoryItem>();
        }

    }
}
