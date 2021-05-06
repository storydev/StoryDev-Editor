using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Data
{
    [MainSourceData("Characters", "FirstName")]
    class Character : DBObject
    {

        public int ID;
        public string FirstName;
        public string LastName;
        public int ColorRed;
        public int ColorGreen;
        public int ColorBlue;

        [SearchOptions(Hidden = true)]
        public string Description;
        [SearchOptions(Hidden = true)]
        public string Appearance;

        public bool PlayerCharacter;
        [SearchCustomDataSource("Attitudes")]
        public int Attitude;

        //
        // NPC Fields
        //
        [SearchRelationship(typeof(CharacterGroup), "ID", "Name", "CharacterGroups")]
        public int GroupID;
        public bool IsVendor;
        public List<VendorItem> VendorItems;

        //
        // Player Fields
        //
        public List<CharacterAttitude> Attitudes;
        public List<int> Traits;

        public Character()
        {
            FirstName = "";
            LastName = "";
            ColorRed = 255;
            ColorGreen = 255;
            ColorBlue = 255;
            Description = "";
            Appearance = "";
            PlayerCharacter = false;
            Attitude = 0;
            GroupID = -1;
            IsVendor = false;

            Attitudes = new List<CharacterAttitude>();
            Traits = new List<int>();
            VendorItems = new List<VendorItem>();
        }

    }
}
