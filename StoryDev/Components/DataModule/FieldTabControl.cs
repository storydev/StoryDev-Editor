using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.DataModule
{
    class FieldTabControl : TabControl, IField
    {

        public FieldTabControl(int elementIndex)
        {
            this.elementIndex = elementIndex;
        }

        public string FieldName
        {
            get;
            set;
        }

        public ElementType ElementType
        {
            get => ElementType.TabControl;
        }

        public LabelPosition LabelPosition { get; set; }

        private int elementIndex;
        public int ElementIndex
        {
            get => elementIndex;
        }

        public Control GetControl()
        {
            return this;
        }

        public Control GetInnerComponent()
        {
            return this;
        }
    }
}
