using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StoryDev.Data;

namespace StoryDev.Scripting.Modules
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
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

        public bool IsResultList;
        public List<LinkedColumn> DisplayColumns;
        //
        // Appearance
        //
        public string Group;
        public LabelPosition LabelPosition;

        public DataOptions()
        {
            ColumnWidth = 100;
            HiddenInSearch = false;

            RelationshipTypeName = "";
            FieldName = "";
            DisplayField = "";
            IsResultList = false;
            DisplayColumns = new List<LinkedColumn>();

            CustomDataSource = "";

            Group = "";
            LabelPosition = LabelPosition.Top;
        }

    }
}
