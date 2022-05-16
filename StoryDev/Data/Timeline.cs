using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryDev.DBO;

namespace StoryDev.Data
{
    class Timeline : DBO.SQLite.DBObject
    {

        [SQLPrimaryKey, SQLAutoIncrement]
        public int ID;
        public string Name;
        public int ParentTimeline;
        public int ParentPosition;
        public float PositionX;
        public float PositionY;
        public string TimelineAllowCondition;


        public Timeline()
        {

        }

    }
}
