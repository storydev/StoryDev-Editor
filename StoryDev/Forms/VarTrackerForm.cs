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
        private VarTrackerUI savedStateTracker;

        public VarTrackerForm(StateTemplate template, List<int> outcomes)
        {
            InitializeComponent();

            this.template = template;

            if (outcomes.Count > 0)
            {
                var maxWidth = 0;
                foreach (var outcome in outcomes)
                {
                    if (outcome == -1)
                    {
                        savedStateTracker = new VarTrackerUI(template);
                        savedStateTracker.Outcome = -1;
                        savedStateTracker.Dock = DockStyle.Left;
                        Controls.Add(savedStateTracker);

                        maxWidth += savedStateTracker.Width;
                    }
                    else if (outcome == 0) // best
                    {
                        bestOutcomeTracker = new VarTrackerUI(template);
                        bestOutcomeTracker.Dock = DockStyle.Left;
                        bestOutcomeTracker.Outcome = 0;
                        Controls.Add(bestOutcomeTracker);

                        maxWidth += bestOutcomeTracker.Width;
                    }
                    else if (outcome == 1) // worst
                    {
                        worstOutcomeTracker = new VarTrackerUI(template);
                        worstOutcomeTracker.Dock = DockStyle.Left;
                        worstOutcomeTracker.Outcome = 1;
                        Controls.Add(worstOutcomeTracker);

                        maxWidth += worstOutcomeTracker.Width;
                    }
                }

                Width = maxWidth + 20;
            }
        }

        public void AddState(PlayerState state, int outcome)
        {
            if (outcome == 0)
            {
                bestOutcomeTracker.SetState(state);
            }
            else if (outcome == 1)
            {
                worstOutcomeTracker.SetState(state);
            }
        }
    }
}
