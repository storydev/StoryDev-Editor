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
    partial class ConversationEditor : Form
    {
        public ConversationEditor()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            cmbView.SelectedIndex = 0;
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbView.SelectedIndex == 0)
                branchDesignerUI1.View = Components.BranchView.Branch;
            else if (cmbView.SelectedIndex == 1)
                branchDesignerUI1.View = Components.BranchView.List;
        }
    }
}
