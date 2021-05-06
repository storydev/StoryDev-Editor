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
    partial class AccessSection : UserControl, ICodeComponent
    {
        public AccessSection()
        {
            InitializeComponent();

            foreach (var section in Globals.Sections)
            {
                cmbSections.Items.Add(section.Name);
                cmbSections.AutoCompleteCustomSource.Add(section.Name);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("AccessSection(".Length, code.LastIndexOf(')') - "AccessSection(".Length);
            if (int.TryParse(result, out int sectionID))
            {
                cmbSections.SelectedIndex = Globals.Sections.FindIndex((s) => s.ID == sectionID);
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbSections.SelectedIndex == -1)
                return "You must select a section.";

            return "";
        }

        public bool IsValid()
        {
            return cmbSections.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("AccessSection({0})", Globals.Sections[cmbSections.SelectedIndex].ID);
        }

        private void btnBrowseSections_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<MapSection>("Sections");
            search.SearchSelected += (int index) => cmbSections.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}
