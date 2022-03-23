using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Scripting
{
    internal class DataStruct
    {

        public string Name;
        public List<DataField> Fields;
        public string SourceFile;
        public string DefinedFormName;

        public DataStruct()
        {
            Fields = new List<DataField>();
        }

    }
}
