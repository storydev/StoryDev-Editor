using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Scripting
{
    class ControlMethod
    {

        public Control Container;
        public ControlType Type;
        public Control ContentContainer;

        public ControlMethod()
        {

        }

    }

    enum ControlType
    {
        Standard,
        Pages
    }
}
