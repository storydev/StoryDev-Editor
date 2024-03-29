﻿using System;
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
    partial class FilterNumber : UserControl
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

        public DBOperator Operator
        {
            get
            {
                var index = cmbOperator.SelectedIndex;
                if (index == 0)
                    return DBOperator.Equals;
                else if (index == 1)
                    return DBOperator.LessThan;
                else if (index == 2)
                    return DBOperator.LessThanEquals;
                else if (index == 3)
                    return DBOperator.GreaterThan;
                else if (index == 4)
                    return DBOperator.GreaterThanEquals;

                return DBOperator.None;
            }
        }

        public int Value
        {
            get
            {
                return (int)nudValue.Value;
            }
        }

        public FilterNumber()
        {
            InitializeComponent();
        }
    }
}
