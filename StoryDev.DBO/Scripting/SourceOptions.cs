using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.DBO.Scripting
{
    public struct SourceOptions
    {

        public SourceType Type { get; set; }
        public DatabaseVendor DBVendor { get; set; }
        public string Info { get; set; }

        public SourceOptions(SourceType type, string info)
        {
            Type = type;
            Info = info;
            DBVendor = DatabaseVendor.None;
        }

        public SourceOptions(SourceType type, string info, DatabaseVendor dbVendor)
        {
            Type = type;
            Info = info;
            DBVendor = dbVendor;
        }

    }

    public enum SourceType
    { 
        File,
        Database,
    }

    public enum DatabaseVendor
    {
        None,
        SQLite,
    }

}
