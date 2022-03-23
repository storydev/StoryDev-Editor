using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components
{
    interface IFormComponent
    {

        string DisplayName { get; set; }

        object Value { get; set; }

        Control GetValueControl();

    }
}
