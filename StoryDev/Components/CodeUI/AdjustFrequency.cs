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
    partial class AdjustFrequency : UserControl, ICodeComponent
    {
        public AdjustFrequency()
        {
            InitializeComponent();
        }

        public bool IsConditional => false;

        public void FromCodeString(string code)
        {
            var result = code.Substring("AdjustFrequency(".Length, code.LastIndexOf(')') - "AdjustFrequency(".Length);
            if (decimal.TryParse(result, out decimal cash))
            {
                nudAmount.Value = cash;
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (nudAmount.Value == 0.00m)
                return "You must set this value greater or less than zero.";

            return "";
        }

        public bool IsValid()
        {
            return nudAmount.Value > 0.00m || nudAmount.Value < 0.00m;
        }

        public string ToCodeString()
        {
            return string.Format("AdjustFrequency({0})", nudAmount.Value);
        }
    }
}
