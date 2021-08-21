using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
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
