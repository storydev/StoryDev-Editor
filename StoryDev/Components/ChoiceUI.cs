using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Forms;

namespace StoryDev.Components
{
    partial class ChoiceUI : UserControl
    {

        private ChoiceData data;

        public ChoiceUI(ChoiceData data)
        {
            InitializeComponent();

            this.data = data;

            nudPriority.Value = data.Priority;

        }

        public void SetGoingToName(string name)
        {
            lblGoingTo.Text = "Going To: " + name;
        }

        private void lblGoingTo_Click(object sender, EventArgs e)
        {

        }

        private void nudPriority_ValueChanged(object sender, EventArgs e)
        {
            data.Priority = (int)nudPriority.Value;
        }

        private void btnConditions_Click(object sender, EventArgs e)
        {
            var construct = new CodeConstructForm();
            if (!string.IsNullOrEmpty(data.Condition))
            {
                construct.ConstructFromExisting(data.Condition);
            }

            construct.OnlyConditionals = true;
            construct.Method = ConstructMethod.Simple;
            construct.NoSwitching = true;

            if (construct.ShowDialog() == DialogResult.OK)
            {
                data.Condition = construct.Code;
            }
        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            var construct = new CodeConstructForm();
            if (!string.IsNullOrEmpty(data.Condition))
            {
                construct.ConstructFromExisting(data.Condition);
            }

            construct.OnlyExecutables = true;
            construct.Method = ConstructMethod.Simple;
            construct.NoSwitching = true;

            if (construct.ShowDialog() == DialogResult.OK)
            {
                data.Code = construct.Code;
            }
        }
    }
}
