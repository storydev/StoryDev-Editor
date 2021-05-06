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
    partial class UnlockCharacterGossip : UserControl, ICodeComponent
    {
        public UnlockCharacterGossip()
        {
            InitializeComponent();

            foreach (var gossip in Globals.Gossips)
            {
                cmbGossips.Items.Add(gossip.Name);
                cmbGossips.AutoCompleteCustomSource.Add(gossip.Name);
            }
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("UnlockCharacterGossip(".Length, code.LastIndexOf(')') - "UnlockCharacterGossip(".Length);
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
                return "You must select a gossip.";

            return "";
        }

        public bool IsValid()
        {
            return cmbGossips.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("UnlockCharacterGossip({0})", Globals.Gossips[cmbGossips.SelectedIndex].ID);
        }

        private void btnBrowseGossips_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<CharacterGossip>("Gossips");
            search.SearchSelected += (int index) => cmbGossips.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}
