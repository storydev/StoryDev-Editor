using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryDev.DBO;

namespace StoryDev.Data
{
    class TimelineElement : DBO.SQLite.DBObject
    {

        [SQLPrimaryKey, SQLAutoIncrement]
        public int ID;
        public int TimelineID;
        public int _Order;
        public string Name;
        public string Content;
        public int Type;
        public int Data0;
        public int Data1;
        public int Data2;
        public int Data3;

        public TimelineElement()
        {

        }

    }

    enum ElementType
    {
        Conversation,
        Discovery,
        Event,
        Code
    }
}
