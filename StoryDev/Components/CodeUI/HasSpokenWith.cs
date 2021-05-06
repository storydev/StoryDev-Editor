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
    partial class HasSpokenWith : UserControl, ICodeComponent
    {

        public HasSpokenWith()
        {
            InitializeComponent();

            foreach (var gossip in Globals.Gossips)
            {
                cmbGossips.Items.Add(gossip.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasSpokenWith(".Length, code.LastIndexOf(')') - "HasSpokenWith(".Length);
            if (int.TryParse(result, out int gossipID))
            {
                cmbGossips.SelectedIndex = Globals.Gossips.FindIndex((g) => g.ID == gossipID);
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbGossips.SelectedIndex == -1)
                return "You must select a section.";

            return "";
        }

        public bool IsValid()
        {
            return cmbGossips.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasSpokenWith({0})", Globals.Gossips[cmbGossips.SelectedIndex].ID);
        }

        private void btnBrowseSections_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<CharacterGossip>("Gossips");
            search.SearchSelected += (int index) => cmbGossips.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}
