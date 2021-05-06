using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components.CodeUI
{
    partial class HasFrequency : UserControl, ICodeComponent
    {
        public HasFrequency()
        {
            InitializeComponent();
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            var result = code.Substring("HasFrequency(".Length, code.LastIndexOf(')') - "HasFrequency(".Length);
            if (int.TryParse(result, out int frequency))
            {
                nudFrequency.Value = frequency;
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (nudFrequency.Value == 0.00m)
                return "The frequency value must be greater than zero.";

            return "";
        }

        public bool IsValid()
        {
            return nudFrequency.Value > 0.00m;
        }

        public string ToCodeString()
        {
            return string.Format("HasFrequency({0})", nudFrequency.Value);
        }
    }
}
