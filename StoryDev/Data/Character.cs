using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.DBO.SQLite;

namespace StoryDev.Data
{
    [MainSourceData("Characters", "FirstName", IdentifierID = "CharacterID")]
    class Character : DBObject
    {

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
        }

    }
}
