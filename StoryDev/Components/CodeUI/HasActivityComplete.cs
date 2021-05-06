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
using StoryDev.Forms;

namespace StoryDev.Components.CodeUI
{
    partial class HasActivityComplete : UserControl, ICodeComponent
    {
        public HasActivityComplete()
        {
            InitializeComponent();

            foreach (var activity in Globals.Activities)
            {
                cmbActivities.Items.Add(activity.Name);
                cmbActivities.AutoCompleteCustomSource.Add(activity.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasActivityComplete(".Length, code.LastIndexOf(')') - "HasActivityComplete(".Length);
            if (int.TryParse(result, out int activityID))
            {
                cmbActivities.SelectedIndex = Globals.Activities.FindIndex((a) => a.ID == activityID);
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbActivities.SelectedIndex == -1)
                return "You must select an activity.";

            return "";
        }

        public bool IsValid()
        {
            return cmbActivities.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasActivityComplete({0})");
        }

        private void btnBrowseActivities_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Activity>("Activities");
            search.SearchSelected += (int index) => cmbActivities.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}
