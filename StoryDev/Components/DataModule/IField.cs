using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.DataModule
{
    interface IField
    {
        string FieldName { get; set; }

        ElementType ElementType { get; }

        LabelPosition LabelPosition { get; set; }

        int ElementIndex { get; }

        Control GetControl();

        Control GetInnerComponent();

    }
}
