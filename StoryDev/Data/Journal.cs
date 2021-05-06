using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Journals", "Name")]
    class Journal : DBObject
    {

        public int ID;
        public string Name;
        public bool IsMainStory;

        [SearchCustomDataSource("Chapters")]
        public string MainStoryChapter;
        public int MainStoryProgress;
        [SearchCustomDataSource("Chapters")]
        public string UntilStoryChapter;
        public int UntilStoryProgress;
        
        public bool AccessedViaScript;

        public List<string> Pages;

        public Journal()
        {
            Name = "";
            Pages = new List<string>();
            MainStoryChapter = "";
            MainStoryProgress = 1;

            UntilStoryChapter = "";
            UntilStoryProgress = 1;

            IsMainStory = false;
        }

    }
}
