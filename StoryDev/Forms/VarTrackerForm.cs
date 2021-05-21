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
    partial class VarTrackerForm : Form
    {

        private StateTemplate template;
        private VarTrackerUI worstOutcomeTracker;
        private VarTrackerUI bestOutcomeTracker;

        public VarTrackerForm(StateTemplate template, List<int> outcomes)
        {
            InitializeComponent();

            this.template = template;

            if (outcomes.Count > 0)
            {
                var maxWidth = 0;
                foreach (var outcome in outcomes)
                {
                    if (outcome == 0) // best
                    {
                        bestOutcomeTracker = new VarTrackerUI(template);
                        bestOutcomeTracker.Dock = DockStyle.Left;
                        Controls.Add(bestOutcomeTracker);

                        maxWidth += bestOutcomeTracker.Width;
                    }
                    else if (outcome == 1) // worst
                    {
                        worstOutcomeTracker = new VarTrackerUI(template);
                        worstOutcomeTracker.Dock = DockStyle.Left;
                        Controls.Add(worstOutcomeTracker);

                        maxWidth += worstOutcomeTracker.Width;
                    }
                }

                Width = maxWidth + 20;
            }

            
        }
    }
}
