using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components
{
    partial class StoryOrderDesigner : UserControl
    {

        private int mouseX;
        private int mouseY;
        private bool mouseDown;
        private bool mouseReleased;

        public StoryOrderDesigner()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();



            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            g.Clear(Color.White);


        }

        private void DrawTimeline()
        {

        }
    }
}
