using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Forms
{
    partial class VariableChangesForm : Form
    {
        public VariableChangesForm()
        {
            InitializeComponent();
        }

        public void PopulateList(string variable, int outcome)
        {
            var engine = Simulation.Engine.Instance;
            var actualVarName = variable;
            actualVarName = actualVarName.Substring(0, actualVarName.IndexOf(':') - 1);

            if (engine.CallStack.Calls.ContainsKey(actualVarName))
            {
                var list = engine.CallStack.Calls[actualVarName];
                var results = list.Where((callInfo) => callInfo.ForOutcome == outcome);
                lvResults.Items.Clear();
                foreach (var call in results)
                {
                    var item = new ListViewItem();
                    item.Text = call.OriginalFile;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = "" + call.Line
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = "" + call.BlockName
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = call.LastValue.ToString()
                    });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem()
                    {
                        Text = call.NewValue.ToString()
                    });
                    lvResults.Items.Add(item);
                }
            }
        }

        private void lvResults_DoubleClick(object sender, EventArgs e)
        {
            if (lvResults.SelectedIndices.Count > 0)
            {
                var index = lvResults.SelectedIndices[0];
                var blockName = lvResults.Items[index].SubItems[2].Text;
                var file = lvResults.Items[index].Text;
                var line = lvResults.Items[index].SubItems[1].Text;

                GoToConversation?.Invoke(file, blockName, int.Parse(line));
                Close();
            }
        }

        public event OnGoToConversation GoToConversation;
    }
}
