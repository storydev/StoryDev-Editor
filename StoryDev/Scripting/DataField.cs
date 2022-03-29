using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Scripting
{
    internal class DataField
    {

        public string Name;
        public DataFieldType Type;
        public DataFieldType ArrayType;
        public FieldDisplay DisplayedAs;
        public string StructReference;
        public string FieldReference;
        public string DisplayReference;
        public string[] CustomDisplayReference;
        public string CustomReferenceSource;

        public DataField()
        {
            
        }

    }
}
