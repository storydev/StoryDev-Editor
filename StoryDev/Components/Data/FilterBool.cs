using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.Data
{
    partial class FilterBool : UserControl
    {

        public string FieldName
        {
            get
            {
                return lblFieldName.Text;
            }
            set
            {
                lblFieldName.Text = value;
            }
        }

        /// <summary>
        /// A value that is greater than -1 is a boolean.
        /// </summary>
        public int Value
        {
            get
            {
                return cmbValue.SelectedIndex;
            }
        }

        public FilterBool()
        {
            InitializeComponent();
        }
    }
}
