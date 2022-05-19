using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class StoryOrderForm : Form
    {

        private StoryOrderDesigner designer;

        public StoryOrderForm()
        {
            InitializeComponent();

            designer = new StoryOrderDesigner();
            designer.Dock = DockStyle.Fill;
            designer.TimelineActivated += Designer_TimelineActivated;
            designer.RequestOpenForm += Designer_RequestOpenForm;
            tscDesigner.ContentPanel.Controls.Add(designer);
        }

        private void Designer_RequestOpenForm(FormType type, string[] data)
        {
            RequestOpenForm?.Invoke(type, data);
        }

        private void Designer_TimelineActivated()
        {
            tsbConversation.Enabled = true;
            tsbDiscovery.Enabled = true;
            tsbEvent.Enabled = true;
            tsbExecute.Enabled = true;
        }

        private void tsbNewTimeline_Click(object sender, EventArgs e)
        {
            var simple = new SimpleEntryForm();
            simple.Text = "New Timeline";
            if (simple.ShowDialog() == DialogResult.OK)
            {
                designer.AddTimeline(simple.Value);
            }
        }

        private void tsbConversation_Click(object sender, EventArgs e)
        {
            var simple = new SimpleEntryForm();
            simple.Text = "New Conversation";
            if (simple.ShowDialog() == DialogResult.OK)
            {
                var fullConvoPath = Path.Combine(Globals.CurrentProjectFolder, "Chapters", designer.GetActiveTimeline().Name, simple.Value);
                if (!File.Exists(fullConvoPath))
                {
                    File.WriteAllText(fullConvoPath + ".sdc", "convo Untitled\r\n");
                    File.WriteAllText(fullConvoPath + ".sdd", "Untitled|50|50\r\nLinks:\r\n");
                }

                designer.AddConversation(designer.ActiveTimelineIndex, simple.Value);
            }
        }

        public event OnRequestOpenForm RequestOpenForm;
    }
}
