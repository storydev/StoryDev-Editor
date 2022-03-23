using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.Forms
{
    partial class FormNumber : UserControl, IFormComponent
    {
        public FormNumber()
        {
            InitializeComponent();
        }

        public string DisplayName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public object Value
        {
            get => nudValue.Value;
            set => nudValue.Value = (decimal)value;
        }

        public Control GetValueControl()
        {
            return nudValue;
        }
    }
}
