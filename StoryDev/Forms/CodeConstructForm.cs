﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

using StoryDev.Components;

namespace StoryDev.Forms
{
    partial class CodeConstructForm : Form
    {

        private int editingComponent = -1;

        private ListBox lbCommands;
        private CodeEditor editor;
        
        public ConstructMethod Method { get; set; }

        private bool noSwitching;
        public bool NoSwitching
        {
            get
            {
                return noSwitching;
            }
            set
            {
                noSwitching = value;
                btnChangeView.Visible = !value;
            }
        }

        public bool OnlyConditionals
        {
            get
            {
                return !sbtnExecute.Visible;
            }
            set
            {
                sbtnExecute.Visible = !value;
            }
        }

        public bool OnlyExecutables
        {
            get
            {
                return !sbtnConditions.Visible;
            }
            set
            {
                sbtnConditions.Visible = !value;
            }
        }



        public string Code
        {
            get; private set;
        }

        public CodeConstructForm()
        {
            InitializeComponent();

            lbCommands = new ListBox();
            lbCommands.Dock = DockStyle.Fill;
            lbCommands.DoubleClick += lbCommands_DoubleClick;
            lbCommands.KeyUp += LbCommands_KeyUp;

            editor = new CodeEditor();
            editor.CurrentLanguage = Language.HaxeScript;
            editor.Dock = DockStyle.Fill;
            editor.KeyUp += Editor_KeyUp;

            Method = ConstructMethod.Simple;

            SwitchMethod();
        }

        private void LbCommands_KeyUp(object sender, KeyEventArgs e)
        {
            if (lbCommands.SelectedIndex > -1 && e.KeyCode == Keys.Delete)
            {
                var response = MessageBox.Show("Delete this option?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    lbCommands.Items.RemoveAt(lbCommands.SelectedIndex);
                    lbCommands.SelectedIndex = -1;
                }
            }
        }

        private void Editor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                SelectFullFunctionCall();
            }
        }

        public void ConstructFromExisting(string code)
        {
            var found = false;
            foreach (var keyword in CodeEditor.Keywords)
            {
                if (code.Contains(keyword))
                {
                    found = true;
                }
            }

            if (!found)
            {
                var calls = code.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var call in calls)
                {
                    if (call.Contains("&&") || call.Contains("||"))
                    {
                        var value = "";
                        var total = call;
                        for (int i = 0; i < total.Length; i++)
                        {
                            if ((total[i] == '&' && total[i + 1] == '&') || (total[i] == '|' && total[i + 1] == '|'))
                            {
                                lbCommands.Items.Add(value + total[i] + total[i + 1]);
                                value = "";
                                i += 2;
                            }
                            else if (i == total.Length - 1)
                            {
                                value += total[i];
                                lbCommands.Items.Add(value);
                                value = "";
                            }
                            else
                            {
                                value += total[i];
                            }
                        }
                    }
                    else
                    {
                        var temp = call.TrimStart(' ');
                        lbCommands.Items.Add(temp);
                    }
                }
            }
            else
            {
                Method = ConstructMethod.Advanced;
                SwitchMethod();

                var result = code;
                result = result.Replace("\\r\\n", "\r\n");

                editor.Text = result;
            }
        }

        private void SwitchMethod()
        {
            if (Method == ConstructMethod.Simple)
            {
                pnlContent.Controls.Clear();

                pnlContent.Controls.Add(lbCommands);
            }
            else
            {
                pnlContent.Controls.Clear();
                if (lbCommands.Items.Count > 0)
                    editor.Text = ToCode();
                else
                    editor.Text = "";

                pnlContent.Controls.Add(editor);
            }
        }

        private void Condition_CodeStringAdded(string code)
        {
            if (Method == ConstructMethod.Simple)
            {
                if (editingComponent > -1)
                {
                    lbCommands.Items[editingComponent] = code;
                    editingComponent = -1;
                }
                else
                {
                    lbCommands.Items.Add(code);
                }
            }
            else
            {
                if (editor.Selection.IsEmpty)
                {
                    editor.InsertText(code);
                }
                else
                {
                    editor.ClearSelected();
                    if (code.EndsWith("&") || code.EndsWith("|"))
                    {
                        code = code.TrimEnd('&', '|', ' ');
                    }

                    editor.InsertText(code);
                }
            }
        }

        private void SelectFullFunctionCall()
        {
            if (!string.IsNullOrEmpty(editor.Text) && editor.Text.Contains(")"))
            {
                editor.Selection.GoWordLeft(false);
                if (!IsLetter(editor.Selection.CharAfterStart))
                    return;

                editor.Selection.GoWordRight(true, true);

                while (editor.Selection.Chars.ElementAt(editor.Selection.Chars.Count() - 1).c != ')')
                {
                    editor.Selection.GoWordRight(true);
                }
            }

            if (editor.SelectionLength > 0)
            {
                LaunchFormFromFuncString(editor.SelectedText);
            }
        }

        private bool IsLetter(char v)
        {
            return (v >= 'A' && v <= 'Z') || (v >= 'a' && v <= 'z');
        }

        private void lbCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbCommands_DoubleClick(object sender, EventArgs e)
        {
            if (lbCommands.SelectedIndex > -1)
            {
                var code = (string)lbCommands.Items[lbCommands.SelectedIndex];
                editingComponent = lbCommands.SelectedIndex;
                LaunchFormFromFuncString(code);
            }
        }

        private void LaunchFormFromFuncString(string code)
        {
            code = code.TrimStart('\r', '\n');
            var paranIndex = code.IndexOf('(');
            if (paranIndex > -1)
            {
                var func = code.Substring(0, paranIndex);
                var resolvedType = Type.GetType("StoryDev.Components.CodeUI." + func);
                if (resolvedType != null)
                {
                    var uc = (UserControl)Activator.CreateInstance(resolvedType);
                    uc.Dock = DockStyle.Fill;
                    var component = (ICodeComponent)uc;
                    component.FromCodeString(code);
                    var instance = new CodeComponentForm(component);
                    instance.CodeStringAdded += Condition_CodeStringAdded;
                    instance.ShowDialog();
                }
            }
            else
            {
                //var customVariable = new GetCustomVariable()
                //{
                //    Dock = DockStyle.Fill
                //};
                //customVariable.FromCodeString(code);
                //var condition = new CodeComponentForm(customVariable);
                //condition.CodeStringAdded += Condition_CodeStringAdded;
                //condition.ShowDialog();
            }
        }

        private string ToCode()
        {
            var result = "";
            for (int i = 0; i < lbCommands.Items.Count; i++)
            {
                var item = (string)lbCommands.Items[i];

                if (i > 0)
                    result += " ";

                if (i == lbCommands.Items.Count - 1)
                {
                    if (item.EndsWith("&&") || item.EndsWith("||"))
                    {
                        result += item.TrimEnd('&', '|', ' ');
                    }
                    else
                    {
                        result += item;
                    }

                    if (!item.EndsWith(";"))
                        result += ";";
                }
                else
                {
                    if (OnlyExecutables)
                        result += item + ";";
                    else
                        result += item;
                }
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Method == ConstructMethod.Simple)
                Code = ToCode();
            else
                Code = editor.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnChangeView_Click(object sender, EventArgs e)
        {
            var go = true;
            if (Method == ConstructMethod.Advanced)
            {
                var response = MessageBox.Show("Any changes made in the advanced editor will not be parsed into the simple version. Do you wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.No)
                {
                    go = false;
                }
            }

            if (!go)
                return;

            Method = Method == ConstructMethod.Simple ? ConstructMethod.Advanced : ConstructMethod.Simple;
            SwitchMethod();

            if (Method == ConstructMethod.Simple)
                btnChangeView.Text = "Advanced >>";
            else
                btnChangeView.Text = "<< Simple";
        }

        private void customVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var condition = new CodeComponentForm(new GetCustomVariable()
            //{
            //    Dock = DockStyle.Fill
            //});

            //condition.CodeStringAdded += Condition_CodeStringAdded;
            //condition.ShowDialog();
        }
    }

    enum ConstructMethod
    {
        Simple,
        Advanced
    }
}
