using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.DataModule
{
    partial class FieldLinkedDetailedView : UserControl, IField
    {
        public FieldLinkedDetailedView(int elementIndex)
        {
            InitializeComponent();

            this.elementIndex = elementIndex;
        }

        public string FieldName
        {
            get => lblFieldName.Text;
            set => lblFieldName.Text = value;
        }

        public ElementType ElementType
        {
            get => ElementType.LinkedDetailedView;
        }

        private LabelPosition labelPosition;
        public LabelPosition LabelPosition
        {
            get => labelPosition;
            set
            {
                labelPosition = value;

                if (labelPosition == LabelPosition.Top)
                    lblFieldName.Anchor = AnchorStyles.Top;
                else if (labelPosition == LabelPosition.Left)
                    lblFieldName.Anchor = AnchorStyles.Left;
                else if (labelPosition == LabelPosition.Right)
                    lblFieldName.Anchor = AnchorStyles.Right;
                else if (labelPosition == LabelPosition.Bottom)
                    lblFieldName.Anchor = AnchorStyles.Bottom;
            }
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
            return lvResults;
        }
    }
}
