using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FastColoredTextBoxNS;

namespace StoryDev.Components
{
    partial class CodeEditor : FastColoredTextBox
    {

        public Language CurrentLanguage;

        private TextStyle hs_Keywords = new TextStyle(Brushes.LightSeaGreen, Brushes.Transparent, FontStyle.Regular);
        private TextStyle hs_Numbers = new TextStyle(Brushes.Magenta, Brushes.Transparent, FontStyle.Regular);
        private TextStyle hs_Quotes = new TextStyle(Brushes.OrangeRed, Brushes.Transparent, FontStyle.Regular);

        private TextStyle ss_Keywords = new TextStyle(Brushes.LightSeaGreen, Brushes.Transparent, FontStyle.Regular);
        private TextStyle ss_Dialogue = new TextStyle(Brushes.Orange, Brushes.Transparent, FontStyle.Regular);
        private TextStyle ss_Overlay = new TextStyle(Brushes.OrangeRed, Brushes.Transparent, FontStyle.Regular);
        private TextStyle ss_PrefixedVar = new TextStyle(Brushes.Blue, Brushes.Transparent, FontStyle.Regular);
        private TextStyle ss_Code = new TextStyle(Brushes.LightSeaGreen, Brushes.Transparent, FontStyle.Regular);


        public static readonly string[] Keywords = new string[]
        {
            "if",
            "else",
            "for",
            "while",
            "var",
            "function",
            "try",
            "catch",
            "continue",
            "break",
            "in",
            "switch",
            "case",
            "new",
            "return",
            "throw",
            "true",
            "false"
        };

        public CodeEditor()
        {
            BackColor = Color.FromArgb(64, 64, 64);
            SelectionColor = Color.FromArgb(213, 218, 239);
            CaretColor = Color.FromArgb(216, 216, 216);
            ForeColor = Color.FromArgb(195, 195, 195);

            CurrentLanguage = Components.Language.HaxeScript;

            TextChangedDelayed += CodeEditor_TextChangedDelayed;
            DelayedTextChangedInterval = 170;
        }

        private void CodeEditor_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            if (CurrentLanguage == Components.Language.HaxeScript)
            {
                e.ChangedRange.ClearFoldingMarkers();
                e.ChangedRange.SetFoldingMarkers("{", "}");

                e.ChangedRange.ClearStyle(hs_Keywords, hs_Numbers, hs_Quotes);
                e.ChangedRange.SetStyle(hs_Keywords, "\b(if|else|for|while|var|function|try|catch|continue|break|in|switch|case|new|return|throw|true|false)\b");
                e.ChangedRange.SetStyle(hs_Numbers, @"\b([0-9]+|0x[0-9a-fA-F]{4,6})\b");
                e.ChangedRange.SetStyle(hs_Quotes, @"(""[^""]+""|'[^']+')");
            }
            else if (CurrentLanguage == Components.Language.StoryScript)
            {
                e.ChangedRange.ClearStyle(ss_Keywords, ss_Dialogue, ss_Overlay, ss_PrefixedVar, ss_Code);
                e.ChangedRange.ClearFoldingMarkers();

                e.ChangedRange.SetFoldingMarkers("^=!", System.Text.RegularExpressions.RegexOptions.Multiline);

                e.ChangedRange.SetStyle(ss_Keywords, @"\b(convo|char)\b");
                e.ChangedRange.SetStyle(ss_Overlay, @"^~\s.+", System.Text.RegularExpressions.RegexOptions.Multiline);

                e.ChangedRange.SetStyle(ss_PrefixedVar, @"\b(\$_?[a-zA-Z0-9_]+)\b");
                e.ChangedRange.SetStyle(ss_Code, @"^(!|=!|=)\s.+", System.Text.RegularExpressions.RegexOptions.Multiline);
                e.ChangedRange.SetStyle(ss_Dialogue, @"^([^:]+\s)?:\s.+", System.Text.RegularExpressions.RegexOptions.Multiline);
            }
        }

        private void CodeEditor_Load(object sender, EventArgs e)
        {
            if (Globals.Preferences != null)
                WordWrap = Globals.Preferences.CodeSettings.WordWrap;
        }
    }

    enum Language
    { 
        HaxeScript,
        StoryScript
    }

}
