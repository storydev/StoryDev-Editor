using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.DataModule
{
    partial class FieldButton : Button, IField
    {
        public FieldButton(int elementIndex)
        {
            InitializeComponent();

            this.elementIndex = elementIndex;
        }

        public string FieldName
        {
            get => Text;
            set => Text = value;
        }

        public ElementType ElementType
        {
            get => ElementType.Button;
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
