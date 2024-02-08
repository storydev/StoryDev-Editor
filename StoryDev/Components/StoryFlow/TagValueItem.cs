using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.StoryFlow
{
    internal partial class TagValueItem : UserControl
    {

        public string TagName
        {
            get => lblTagName.Text;
            set
            {
                lblTagName.Text = value;

                foreach (var t in Globals.CurrentProject.Flow.Tags)
                {
                    if (t.Name == value)
                    {
                        cmbTagValueList.Items.AddRange(t.Values.Keys.ToArray());
                        cmbTagValueList.AutoCompleteCustomSource.AddRange(t.Values.Keys.ToArray());
                        break;
                    }
                }
            }
        }

        public string Value
        {
            get => cmbTagValueList.Text;
            set => cmbTagValueList.Text = value;
        }

        public TagValueItem()
        {
            InitializeComponent();


        }
    }
}
