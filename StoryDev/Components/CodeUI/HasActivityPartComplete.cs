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
    partial class HasActivityPartComplete : UserControl, ICodeComponent
    {

        public HasActivityPartComplete()
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
            var result = code.Substring("HasActivityPartComplete(".Length, code.LastIndexOf(')') - "HasActivityPartComplete(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int activityID))
                {
                    cmbActivities.SelectedIndexChanged -= cmbActivities_SelectedIndexChanged;

                    cmbActivities.SelectedIndex = Globals.Activities.FindIndex((a) => a.ID == activityID);

                    var activity = Globals.Activities[cmbActivities.SelectedIndex];
                    cmbParts.Items.Clear();
                    for (int i = 0; i < activity.Parts.Count; i++)
                    {
                        cmbParts.Items.Add("" + (i + 1));
                    }

                    cmbActivities.SelectedIndexChanged += cmbActivities_SelectedIndexChanged;
                }

                if (int.TryParse(splitted[1], out int progress))
                {
                    cmbParts.SelectedIndex = progress - 1;
                }
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

            if (cmbParts.SelectedIndex == -1)
                return "You must select a part.";

            return "";
        }

        public bool IsValid()
        {
            return cmbActivities.SelectedIndex > -1 && cmbParts.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasActivityPartComplete({0}, {1})", Globals.Activities[cmbActivities.SelectedIndex].ID, cmbParts.SelectedIndex + 1);
        }

        private void cmbActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActivities.SelectedIndex > -1)
            {
                var activity = Globals.Activities[cmbActivities.SelectedIndex];

                cmbParts.Items.Clear();
                for (int i = 0; i < activity.Parts.Count; i++)
                {
                    cmbParts.Items.Add("" + (i + 1));
                }
            }
        }

        private void btnBrowseActivities_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Activity>("Activities");
            search.SearchSelected += (int index) => cmbActivities.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}
