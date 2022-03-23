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
    partial class FormCheckBox : UserControl, IFormComponent
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        public string DisplayName
        {
            get => chbValue.Text;
            set => chbValue.Text = value;
        }
        public object Value
        {
            get => chbValue.Checked;
            set => chbValue.Checked = (bool)value;
        }

        public Control GetValueControl()
        {
            return chbValue;
        }
    }
}
