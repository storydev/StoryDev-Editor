using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.DataModule
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
    class FieldCheckBox : CheckBox, IField
    {

        public FieldCheckBox(int elementIndex)
        {
            this.elementIndex = elementIndex;
        }

        public string FieldName
        {
            get => Text;
            set => Text = value;
        }

        public ElementType ElementType
        {
            get => ElementType.CheckBox;
        }

        private LabelPosition labelPosition;
        public LabelPosition LabelPosition
        {
            get => labelPosition;
            set => labelPosition = value;
        }

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
