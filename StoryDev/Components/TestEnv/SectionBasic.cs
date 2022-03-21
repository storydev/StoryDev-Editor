using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.TestEnv
{
    partial class SectionBasic : UserControl, IWizardPage
    {
        public SectionBasic()
        {
            InitializeComponent();

            PopulateLists();
        }

        public bool CanGoForwards
        {
            get
            {
                return Scripting.Environment.TestEnv.Errors.Count() == 0;
            }
        }

        private void PopulateLists()
        {
            var errors = Scripting.Environment.TestEnv.Errors;
            lvErrors.Items.Clear();
            foreach (var error in errors)
            {
                var item = new ListViewItem();
                item.Text = error.FilePath;
                item.SubItems.Add("" + error.LineNumber);
                item.SubItems.Add("" + error.Column);
                item.SubItems.Add(error.Message);
                lvErrors.Items.Add(item);
            }
        }
    }
}
