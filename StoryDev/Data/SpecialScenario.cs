using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Scenarios", "Name", IdentifierID = "ScenarioID")]
    class SpecialScenario : DBObject
    {

        public int ID;
        public string Name;
        [SearchOptions(Hidden = true)]
        public string Description;
        public int Difficulty;
        [SearchOptions(Hidden = true)]
        public string StartScript;
        [SearchOptions(Hidden = true)]
        public string EndScript;


        public SpecialScenario()
        {
            Name = "";
            Description = "";
            Difficulty = 0;
            StartScript = "";
            EndScript = "";
        }

    }
}
