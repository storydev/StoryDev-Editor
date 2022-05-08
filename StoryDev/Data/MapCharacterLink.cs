using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class MapCharacterLink : DBO.SQLite.DBObject
    {

        public int MapID;
        public int CharacterID;

        public MapCharacterLink()
        {

        }

    }
}
