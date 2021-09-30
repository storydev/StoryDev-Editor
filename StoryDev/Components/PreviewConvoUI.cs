using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Lib.StoryDev;

namespace StoryDev.Components
{
    partial class PreviewConvoUI : UserControl
    {

        private Parser sdParser;
        private CommandBlock currentBlock;

        private string currentPOV;
        private int currentBlockIndex;
        private int currentPosition;

        public PreviewConvoUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            InitializeComponent();

            sdParser = new Parser();
        }

        public void ActivateFile(string path)
        {
            sdParser.Clear();
            sdParser.ParseFile(path);

            currentBlockIndex = 0;
            currentPosition = 0;
        }

        private void Advance()
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            g.Clear(Color.FromArgb(128, 206, 237));

            
        }
    }
}
