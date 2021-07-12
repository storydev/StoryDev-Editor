using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class ConvoMapLink : DBObject
    {

        public int ID;
        public string ConversationFile;
        [SearchRelationship(typeof(Map), "ID", "Name")]
        public int MapID;
        public int MapPoint;

        public ConvoMapLink()
        {

        }

    }
}
