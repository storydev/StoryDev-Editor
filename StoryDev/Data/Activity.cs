using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Activities", "Name", IdentifierID = "ActivityID")]
    class Activity : DBObject
    {

        public int ID;
        [SearchRelationship(typeof(Place), "ID", "Name", "Places")]
        public int PlaceID;
        public string Name;
        [SearchOptions(Hidden = true)]
        public string Description;

        [SearchRelationship(typeof(CharacterTrait), "ID", "Name", "Traits")]
        public int CharacterTraitID;
        public int ProgressOnComplete;
        public int ProgressOnPart;

        public bool HiddenUntilDiscovered;

        public List<ActivityPart> Parts;

        public Activity()
        {
            Parts = new List<ActivityPart>();
            Name = "";
            Description = "";
            CharacterTraitID = -1;
            ProgressOnComplete = 3;
            ProgressOnPart = 1;
            HiddenUntilDiscovered = false;
        }

    }
}
