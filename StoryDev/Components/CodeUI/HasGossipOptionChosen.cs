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
    partial class HasGossipOptionChosen : UserControl, ICodeComponent
    {
        public HasGossipOptionChosen()
        {
            InitializeComponent();

            foreach (var gossip in Globals.Gossips)
            {
                cmbGossips.Items.Add(gossip.Name);
                cmbGossips.AutoCompleteCustomSource.Add(gossip.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasGossipOptionChosen(".Length, code.LastIndexOf(')') - "HasGossipOptionChosen(".Length);
            var splitted = result.Split(',');
            if (splitted.Length == 2)
            {
                if (int.TryParse(splitted[0], out int gossipID))
                {
                    cmbGossips.SelectedIndexChanged -= cmbGossips_SelectedIndexChanged;

                    cmbGossips.SelectedIndex = Globals.Gossips.FindIndex((g) => g.ID == gossipID);

                    var options = Globals.Gossips[cmbGossips.SelectedIndex].DisplayOption;
                    cmbGossipOptions.Items.Clear();
                    foreach (var opt in options)
                    {
                        cmbGossipOptions.Items.Add(opt);
                    }

                    cmbGossips.SelectedIndexChanged += cmbGossips_SelectedIndexChanged;
                }

                if (int.TryParse(splitted[1], out int option))
                {
                    cmbGossipOptions.SelectedIndex = option;
                }
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

            if (cmbGossipOptions.SelectedIndex == -1)
                return "You must select a gossip option.";

            return "";
        }

        public bool IsValid()
        {
            return cmbGossips.SelectedIndex > -1 && cmbGossipOptions.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("HasGossipOptionChosen({0}, {1})", Globals.Gossips[cmbGossips.SelectedIndex].ID, cmbGossipOptions.SelectedIndex);
        }

        private void cmbGossips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGossips.SelectedIndex > -1)
            {
                var options = Globals.Gossips[cmbGossips.SelectedIndex].DisplayOption;
                cmbGossipOptions.Items.Clear();
                foreach (var opt in options)
                {
                    cmbGossipOptions.Items.Add(opt);
                }
            }
        }

        private void btnBrowseGossips_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<CharacterGossip>("Gossips");
            search.SearchSelected += (int index) => cmbGossips.SelectedIndex = index;
            search.ShowDialog();
        }
    }
}
