using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;

namespace StoryDev.Components.Data
{
    partial class FilterString : UserControl
    {

        public string FieldName
        {
            get { return lblFieldName.Text; }
            set { lblFieldName.Text = value; }
        }

        public DBOperator Operator
        {
            get
            {
                var index = cmbOperator.SelectedIndex;
                if (cmbOperator.SelectedIndex == 0)
                    return DBOperator.Contains;
                else if (cmbOperator.SelectedIndex == 1)
                    return DBOperator.Begins;
                else if (cmbOperator.SelectedIndex == 2)
                    return DBOperator.Ends;

                return DBOperator.None;
            }
        }

        public string Value
        {
            get { return txtValue.Text; }
        }

        public FilterString()
        {
            InitializeComponent();
        }
    }
}
