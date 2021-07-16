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
    }
}
