using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tscDesigner.ContentPanel.Controls.Add(designer);
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
    }
}
