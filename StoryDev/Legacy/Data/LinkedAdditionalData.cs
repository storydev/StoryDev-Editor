using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    class LinkedAdditionalData
    {

        public string SelectedModule;
        public string Relationship;
        public List<LinkedColumn> Columns;

        public LinkedAdditionalData()
        {
            Columns = new List<LinkedColumn>();
        }

    }

    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    class LinkedColumn
    {

        public string FieldName;
        public bool Visible;
        public int Width;

        public LinkedColumn()
        {

        }

    }
}
