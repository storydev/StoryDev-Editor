using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDev.Components
{
    interface ICodeComponent
    {
        string ToCodeString();
        void FromCodeString(string code);
        bool IsValid();
        UserControl GetControl();
        string GetErrorMessage();
        bool IsConditional { get; }
    }
}
