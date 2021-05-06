using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Achievements", "Name")]
    class Achievement : DBObject
    {

        public int ID;
        public string Name;
        [SearchOptions(Hidden = true)]
        public string Description;
        [SearchCustomDataSource("AchievementCategories")]
        public int Category;
        [SearchOptions(Hidden = true)]
        public int SubCategory;

        [SearchCustomDataSource("GameEvents")]
        public int GameEvent;
        [SearchOptions(Hidden = true)]
        public int ScriptType;
        [SearchOptions(Hidden = true)]
        public string Script;

        public Achievement()
        {
            Name = "";
            Description = "";
            Category = 0;
            SubCategory = 0;
            GameEvent = 0;
            ScriptType = 0;
            Script = "";
        }

    }
}
