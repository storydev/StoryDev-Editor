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
    partial class FormArray : UserControl, IFormComponent
    {
        public FormArray()
        {
            InitializeComponent();
        }

        public string DisplayName
        {
            get => lblHeader.Text;
            set => lblHeader.Text = value;
        }

        public object Value
        {
            get => GetResultArray();
            set => SetResultArray((object[])value);
        }

        public object[] GetResultArray()
        {
            object[] result = new object[1];
            // @TODO

            return result;
        }

        public Control GetValueControl()
        {
            return null;
        }

        public void SetResultArray(object[] values)
        {
            // @TODO
        }
    }
}
