using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("CharacterGroups", "Name", IdentifierID = "CharacterGroupID")]
    class CharacterGroup : DBObject
    {

        public int ID;
        public string Name;
        public float DefaultFrequencyRate;
        public float InitialFrequency;

        public CharacterGroup()
        {
            Name = "";
            DefaultFrequencyRate = 1.0f;
            InitialFrequency = 3.0f;
        }

    }
}
