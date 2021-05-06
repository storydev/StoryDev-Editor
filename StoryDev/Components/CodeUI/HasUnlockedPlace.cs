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
    partial class HasUnlockedPlace : UserControl, ICodeComponent
    {

        public HasUnlockedPlace()
        {
            InitializeComponent();

            foreach (var place in Globals.Places)
            {
                cmbPlaces.Items.Add(place.Name);
                cmbPlaces.AutoCompleteCustomSource.Add(place.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasUnlockedPlace(".Length, code.LastIndexOf(')') - "HasUnlockedPlace(".Length);
            if (int.TryParse(result, out int place))
            {
                cmbPlaces.SelectedIndex = Globals.Places.FindIndex((p) => p.ID == place);
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbPlaces.SelectedIndex == -1)
                return "You must select a place.";

            return "";
        }

        public bool IsValid()
        {
            return cmbPlaces.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasUnlockedPlace({0})", Globals.Places[cmbPlaces.SelectedIndex].ID);
        }

        private void btnBrowsePlaces_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Place>("Places");
            search.SearchSelected += (int index) => cmbPlaces.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}
