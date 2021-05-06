using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Places", "Name")]
    class Place : DBObject
    {

        public int ID;
        public string Name;
        [SearchOptions(Hidden = true)]
        public string Description;

        public List<int> Activities;
        public List<int> Sections;

        public Place()
        {
            Name = "";
            Description = "";
            Activities = new List<int>();
            Sections = new List<int>();
        }

    }
}
