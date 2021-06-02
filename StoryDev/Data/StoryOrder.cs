using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class StoryOrder
    {

        public List<string> MainStory;
        public Dictionary<int, List<string>> JournalStories;
        public Dictionary<int, int> JournalsAfterPart;
        public bool IncludeJournals;

        public StoryOrder()
        {
            MainStory = new List<string>();
            JournalStories = new Dictionary<int, List<string>>();
            JournalsAfterPart = new Dictionary<int, int>();
        }

    }
}
