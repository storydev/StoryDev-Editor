using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.DBO.Scripting
{

    public class SourceOptions
    {

        public string Name;
        public string Info;
        public SourceType Type;
        public DatabaseVendor Vendor;
        public bool IsDefaultConnection;

        public SourceOptions()
        {
            
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
        MySQL,
        Postgresql,
        Oracle,
        Microsoft
    }

}
