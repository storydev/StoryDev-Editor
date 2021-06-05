using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Data;

namespace StoryDev.Components.CodeUI
{
    partial class GetCustomVariable : UserControl, ICodeComponent
    {

        private IEnumerable<Variable> variables;

        public GetCustomVariable()
        {
            InitializeComponent();

            variables = Globals.Variables.Where((v) => v.Type == 0);
            foreach (var _var in variables)
            {
                cmbVariables.Items.Add(_var.Name);
                cmbVariables.AutoCompleteCustomSource.Add(_var.Name);
            }
        }

        public bool IsConditional => true;

        public void FromCodeString(string code)
        {
            if (!code.Contains("(") || code.Contains("=="))
            {
                cmbValue.SelectedIndex = code.StartsWith("!") ? 0 : 1;

                var variableName = "";
                for (int i = 0; i < code.Length; i++)
                {
                    if (code[i] == '=')
                    {
                        break;
                    }
                    else if (code[i] != '!' && code[i] != '=' && code[i] != ';' && code[i] != ' ')
                    {
                        variableName += code[i];
                    }
                }

                for (int i = 0; i < variables.Count(); i++)
                {
                    if (variables.ElementAt(i).Name == variableName)
                        cmbVariables.SelectedIndex = i;
                }
            }
        }

        public UserControl GetControl()
        {
            return this;
        }

        public string GetErrorMessage()
        {
            if (cmbVariables.SelectedIndex == -1)
                return "You must select a variable.";

            if (cmbValue.SelectedIndex == -1)
                return "You must select a value.";

            return "";
        }

        public bool IsValid()
        {
            return cmbVariables.SelectedIndex > -1;
        }

        public string ToCodeString()
        {
            return string.Format("{0}{1}", cmbValue.SelectedIndex == 0 ? "!" : "", (string)cmbVariables.SelectedItem);
        }
    }
}
