using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private Command[] commandList;

        private string currentPOV;
        private int currentCommandIndex;
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

            currentCommandIndex = 0;
            currentPosition = 0;

            commandList = sdParser.TranslateBlock(sdParser.GetBlocks()[0]);
        }

        private void Advance()
        {
            if (currentCommandIndex + 1 < commandList.Length)
            {
                currentCommandIndex++;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            g.Clear(Color.FromArgb(128, 206, 237));



            for (int i = 0; i < currentCommandIndex + 1; i++)
            {
                var command = commandList[i];
                if (command.Type == (int)CommandType.OverlayTitle)
                {

                }
            }
        }
    }
}
