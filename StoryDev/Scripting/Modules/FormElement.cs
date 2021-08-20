using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;

namespace StoryDev.Scripting.Modules
{
    class FormElement
    {

        public string FieldName;
        public string ReferenceName;
        public ElementType Type;

        public string CustomDataSource;

        public string RelationshipSource;
        public string RelationshipDisplayField;
        public string RelationshipField;

        public Control Instance;

        public FormElement()
        {

        }

    }
}
