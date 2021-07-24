using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Scripting.Modules
{
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
