using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.DataModule
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
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
