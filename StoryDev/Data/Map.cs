using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class Map : DBO.SQLite.DBObject
    {

        public string Name;
        public int ParentID;
        public string Description;

        public Map()
        {

        }

    }
}
