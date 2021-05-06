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
    partial class AddJournalInlineCodeForm : Form
    {
        public AddJournalInlineCodeForm()
        {
            InitializeComponent();

            var editor = new CodeEditor();
            editor.CurrentLanguage = Language.HaxeScript;
            editor.Dock = DockStyle.Fill;

            Controls.Add(editor);

        }
    }
}
