using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Scripting.Modules
{
    class DataOptions
    {

        //
        // Source Data
        //
        public string CustomDataSource;
        //
        // Search Options
        //
        public int ColumnWidth;
        public bool HiddenInSearch;
        //
        // Relationship Details
        //
        public string RelationshipTypeName;
        public string FieldName;
        public string DisplayField;
        public string SourceName;

        public DataOptions()
        {

        }

    }
}
