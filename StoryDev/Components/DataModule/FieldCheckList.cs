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
    partial class FieldCheckList : UserControl, IField
    {

        public string FieldName
        {
            get => lblFieldName.Text;
            set => lblFieldName.Text = value;
        }

        public CheckedListBox.ObjectCollection Items
        {
            get => clbValues.Items;
        }

        private int elementIndex;
        public int ElementIndex
        {
            get => elementIndex;
        }

        public ElementType ElementType
        {
            get => ElementType.CheckList;
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

        public FieldCheckList(int elementIndex)
        {
            InitializeComponent();

            this.elementIndex = elementIndex;
        }

        public Control GetControl()
        {
            return this;
        }

        public Control GetInnerComponent()
        {
            return clbValues;
        }
    }
}
