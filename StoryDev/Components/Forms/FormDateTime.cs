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
    partial class FormDateTime : UserControl, IFormComponent
    {
        public FormDateTime()
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
            get => dtpValue.Value;
            set => dtpValue.Value = (DateTime)value;
        }

        public Control GetValueControl()
        {
            return dtpValue;
        }
    }
}
