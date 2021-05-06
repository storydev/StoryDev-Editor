using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Sections", "Name")]
    class MapSection : DBObject
    {

        public int ID;
        [SearchRelationship(typeof(Place), "ID", "Name", "Places")]
        public int PlaceID;
        public string Name;
        [SearchOptions(Hidden = true)]
        public string Description;

        public bool VisibleToPlayer;
        public int ConnectionAvailability;
        public int EnteredFromPlace;
        public int EnteredFromSection;

        public List<int> CharacterGossips;

        public MapSection()
        {
            VisibleToPlayer = false;
            ConnectionAvailability = 0;
            CharacterGossips = new List<int>();

            EnteredFromPlace = -1;
            EnteredFromSection = -1;
        }

    }
}
