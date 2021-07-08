using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Gossips", "CharacterID", IdentifierID = "CharacterGossipID")]
    class CharacterGossip : DBObject
    {

        public int ID;
        [SearchRelationship(typeof(MapSection), "ID", "Name", "Sections")]
        public int SectionID;
        [SearchRelationship(typeof(Character), "ID", "FirstName", "Characters")]
        public int CharacterID;
        public string Name;
        public bool Visible;
        public List<string> DisplayOption;
        public List<string> GossipOptionCondition;
        public List<string> Script;

        public CharacterGossip()
        {
            Name = "";
            SectionID = -1;
            CharacterID = -1;
            DisplayOption = new List<string>();
            GossipOptionCondition = new List<string>();
            Script = new List<string>();
        }

    }
}
