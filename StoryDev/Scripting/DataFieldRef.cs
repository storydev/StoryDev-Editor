using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using StoryDev.DBO.Scripting;

namespace StoryDev.Scripting
{
    internal class DataFieldRef
    {

        public DataField FieldRef;
        public object Value;
        public Control ValueControl;
        public FieldInfo FieldInfo;

        public DataFieldRef()
        {

        }

    }
}
