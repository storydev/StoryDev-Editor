using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;
using StoryDev.Forms;

namespace StoryDev.Components
{
    partial class ArtefactsUI : UserControl
    {

        private int selectedArtefact;
        private int globalSelectedArtefact;
        private int selectedFragment;
        private List<ArtefactFragment> fragments;

        private IconSelect btnFragmentIcon;

        public ArtefactsUI()
        {
            InitializeComponent();

            btnFragmentIcon = new IconSelect();
            btnFragmentIcon.Anchor = AnchorStyles.Top;
            btnFragmentIcon.IconSet = Globals.IconSetData.Artefacts;
            btnFragmentIcon.Click += BtnFragmentIcon_Click;
            btnFragmentIcon.Location = new System.Drawing.Point(95, 15);
            pnlFragments.Controls.Add(btnFragmentIcon);

            PopulateList();
            PopulateContexts();
        }

        private void BtnFragmentIcon_Click(object sender, EventArgs e)
        {
            if (globalSelectedArtefact > -1)
            {
                var selector = new IconSelectorForm(Globals.IconSetData.Artefacts.FilePath, Globals.IconSetData.Artefacts.IconSize);
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    btnFragmentIcon.IconIndex = selector.SelectedIndex;
                    btnFragmentIcon.Invalidate();
                    Globals.Fragments[globalSelectedArtefact].IconIndex = selector.SelectedIndex;
                    fragments[selectedFragment].IconIndex = selector.SelectedIndex;
                }
            }
        }

        private void PopulateList()
        {
            lbResults.SelectedIndexChanged -= lbResults_SelectedIndexChanged;

            var temp = lbResults.SelectedIndex;

            lbResults.Items.Clear();
            foreach (var artefact in Globals.Artefacts)
            {
                lbResults.Items.Add(artefact.Name);
            }

            if (temp < lbResults.Items.Count - 1)
                lbResults.SelectedIndex = temp;

            lbResults.SelectedIndexChanged += lbResults_SelectedIndexChanged;
        }

        private void PopulateContexts()
        {
            var keys = Globals.Settings.ArtefactContextNames.Keys;
            clbOnUseContext.Items.Clear();
            foreach (var k in keys)
            {
                clbOnUseContext.Items.Add(k);
            }
        }

        private void PopulateFields()
        {
            if (selectedArtefact > -1)
            {
                var artefact = Globals.Artefacts[selectedArtefact];

                txtName.Text = artefact.Name;
                txtDescription.Text = artefact.Description;
                chbUnlockedByDefault.Checked = artefact.UnlockedByDefault;
                cmbRarity.SelectedIndex = artefact.Rarity;
                nudSeeFrequency.Value = (decimal)artefact.SeeFrequency;
                nudAcquireFrequency.Value = (decimal)artefact.AcquireFrequency;
                var flags = artefact.OnUseContext;
                var keys = Globals.Settings.ArtefactContextNames.Keys;
                for (int i = 0; i < keys.Count; i++)
                {
                    if ((flags & (1 << i)) != 0)
                    {
                        clbOnUseContext.SetItemChecked(i, true);
                    }
                }

                PopulateFragments();
            }
        }

        private void PopulateFragments()
        {
            var artefact = Globals.Artefacts[selectedArtefact];

            fragments = Globals.Fragments.FindAll((f) => f.ArtefactID == artefact.ID);

            selectedFragment = -1;
            lbFragments.Items.Clear();
            foreach (var frag in fragments)
            {
                lbFragments.Items.Add(frag.Name);
            }
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbResults.SelectedIndex > -1)
            {
                selectedArtefact = lbResults.SelectedIndex;

                pnlContent.Enabled = true;

                PopulateFields();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var artefact = new Artefact();
            artefact.ID = ++Globals.GlobalIdentifiers.ArtefactID;
            Globals.SaveIdentifiers();
            Globals.Artefacts.Add(artefact);
            Globals.SaveArtefacts();

            PopulateList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new SearchForm<Artefact>("Artefacts");
            search.SearchSelected += (int index) => lbResults.SelectedIndex = index;
            search.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.SaveArtefacts();
            Globals.SaveFragments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedArtefact > -1)
            {
                var artefact = Globals.Artefacts[selectedArtefact];
                var response = MessageBox.Show("Are you sure you wish to delete the artefact '" + artefact.Name + "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    var temp = selectedArtefact;
                    selectedArtefact = lbResults.SelectedIndex = -1;
                    Globals.Artefacts.RemoveAt(temp);
                    Globals.SaveArtefacts();

                    PopulateList();
                }
            }
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddFragment_Click(object sender, EventArgs e)
        {
            var fragment = new ArtefactFragment();
            fragment.ID = ++Globals.GlobalIdentifiers.ArtefactFragmentID;
            Globals.SaveIdentifiers();
            fragment.ArtefactID = Globals.Artefacts[selectedArtefact].ID;
            Globals.Fragments.Add(fragment);
            Globals.SaveFragments();

            Globals.Artefacts[selectedArtefact].Fragments.Add(fragment.ID);
            Globals.SaveArtefacts();

            PopulateFragments();
        }

        private void btnRemoveFragment_Click(object sender, EventArgs e)
        {
            if (selectedFragment > -1)
            {
                var gIndex = Globals.Fragments.FindIndex((f) => f.ID == fragments[selectedFragment].ID);
                Globals.Fragments.RemoveAt(gIndex);
                Globals.SaveFragments();

                Globals.Artefacts[selectedArtefact].Fragments.RemoveAt(selectedFragment);
                Globals.SaveArtefacts();
                var temp = selectedFragment;
                selectedFragment = lbResults.SelectedIndex = -1;
                lbResults.Items.RemoveAt(temp);
                fragments.RemoveAt(temp);

                txtFragmentName.Text = "";
                btnFragmentIcon.IconIndex = -1;
                btnFragmentIcon.Invalidate();
                pnlFragments.Enabled = false;
            }
        }

        private void lbFragments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFragments.SelectedIndex > -1)
            {
                selectedFragment = lbFragments.SelectedIndex;

                var frag = fragments[selectedFragment];

                globalSelectedArtefact = Globals.Fragments.FindIndex((f) => f.ID == frag.ID);
                txtFragmentName.Text = frag.Name;
                btnFragmentIcon.IconIndex = frag.IconIndex;
                btnFragmentIcon.Invalidate();

                pnlFragments.Enabled = true;
                btnRemoveFragment.Enabled = true;
            }
        }

        private void txtFragmentName_TextChanged(object sender, EventArgs e)
        {
            if (globalSelectedArtefact > -1)
            {
                Globals.Fragments[globalSelectedArtefact].Name = txtFragmentName.Text;
                fragments[selectedFragment].Name = txtFragmentName.Text;
                lbFragments.Items[selectedFragment] = txtFragmentName.Text;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (selectedArtefact > -1)
            {
                Globals.Artefacts[selectedArtefact].Name = txtName.Text;
                lbResults.Items[selectedArtefact] = txtName.Text;
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (selectedArtefact > -1)
            {
                Globals.Artefacts[selectedArtefact].Description = txtDescription.Text;
            }
        }

        private void chbUnlockedByDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedArtefact > -1)
            {
                Globals.Artefacts[selectedArtefact].UnlockedByDefault = chbUnlockedByDefault.Checked;
            }
        }

        private void cmbRarity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedArtefact > -1)
            {
                Globals.Artefacts[selectedArtefact].Rarity = cmbRarity.SelectedIndex;
            }
        }

        private void nudSeeFrequency_ValueChanged(object sender, EventArgs e)
        {
            if (selectedArtefact > -1)
            {
                Globals.Artefacts[selectedArtefact].SeeFrequency = (float)nudSeeFrequency.Value;
            }
        }

        private void nudAcquireFrequency_ValueChanged(object sender, EventArgs e)
        {
            if (selectedArtefact > -1)
            {
                Globals.Artefacts[selectedArtefact].AcquireFrequency = (float)nudAcquireFrequency.Value;
            }
        }

        private void btnSetUseContexts_Click(object sender, EventArgs e)
        {
            if (new SetArtefactUseContextsForm().ShowDialog() == DialogResult.OK)
            {
                PopulateContexts();
                if (selectedArtefact > -1)
                {
                    PopulateFields();
                }
            }
        }

        private void clbOnUseContext_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)(
            () =>
            {
                var flags = 0;
                for (int i = 0; i < clbOnUseContext.Items.Count; i++)
                {
                    if (clbOnUseContext.GetItemChecked(i))
                        flags |= (1 << i);
                }

                if (selectedArtefact > -1)
                {
                    Globals.Artefacts[selectedArtefact].OnUseContext = flags;
                }
            }));
        }
    }
}
