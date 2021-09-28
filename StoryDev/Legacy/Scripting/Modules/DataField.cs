using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Scripting.Modules
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    class DataField
    {

        public string Name;
        public DataType Type;
        public DataOptions Options;

        public DataField()
        {
            Options = new DataOptions();
        }

    }

    
}
