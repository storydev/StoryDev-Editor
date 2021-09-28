using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    class FormComponent
    {

        public int FieldType;
        public int DefaultWidth;
        public int DefaultHeight;
        public int LabelPosition;

        public FormComponent()
        {

        }

    }
}
