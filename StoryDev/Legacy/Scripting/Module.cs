using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StoryDev.Scripting.Modules;

namespace StoryDev.Scripting
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    class Module
    {

        public string Name;
        public string TypeName;
        public List<DataField> Fields;

        public Module()
        {
            Name = "";
            TypeName = "";
            Fields = new List<DataField>();
        }

    }
}
