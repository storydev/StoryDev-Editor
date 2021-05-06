using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Traits", "Name")]
    class CharacterTrait : DBObject
    {

        public int ID;
        
        [SearchRelationship(typeof(Character), "ID", "FirstName", "Characters")]
        public int CharacterID;
        public string Name;
        
        [SearchOptions(Hidden = true)]
        public string Description;
        public int InitialValue;
        public int MaxValue;

        [SearchCustomDataSource("TraitPriorities")]
        public int CharacterPriority;

        public CharacterTrait()
        {
            Name = "";
            Description = "";
            InitialValue = 0;
            MaxValue = 10;
            CharacterPriority = 0;
        }

    }
}
