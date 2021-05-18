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
        private VarTrackerUI trackerUI;

        public VarTrackerForm(StateTemplate template)
        {
            InitializeComponent();

            this.template = template;

            trackerUI = new VarTrackerUI(template);
            trackerUI.Dock = DockStyle.Fill;

            Controls.Add(trackerUI);
        }
    }
}
