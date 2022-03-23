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
    partial class FormTextMultiline : UserControl, IFormComponent
    {
        public FormTextMultiline()
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
            get => txtValue.Text;
            set => txtValue.Text = (string)value;
        }

        public Control GetValueControl()
        {
            return txtValue;
        }
    }
}
