using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class FormProperties
    {

        public string FormName;
        public string InstanceName;

        public int GlobalPadding;
        public int DefaultLabelPosition;
        public bool AutoWidthFields;
        public bool AllMargins;
        public int Margin;
        public int TopMargin;
        public int LeftMargin;
        public int RightMargin;
        public int BottomMargin;
        public List<FormComponent> FormComponents;

        public FormProperties()
        {
            FormComponents = new List<FormComponent>();
        }

    }
}
