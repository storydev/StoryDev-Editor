using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

using StoryDev.Data;
using StoryDev.DBO;
using StoryDev.Forms;
using StoryDev.Simulation;

namespace StoryDev.Components
{
    partial class VarTrackerUI : UserControl
    {

        private StateTemplate template;
        private Variable[] vars;
        private System.Type[] valueTypes;
        private int initVar;

        private PlayerState state;
        public PlayerState State 
        {
            get
            {
                return state;
            }
        }

        private int outcome;
        public int Outcome
        { 
            get { return outcome; }
            set
            {
                outcome = value;
                if (outcome == 0)
                {
                    lblOutcomeName.Text = "Best Outcome";
                }
                else if (outcome == 1)
                {
                    lblOutcomeName.Text = "Worst Outcome";
                }
                else if (outcome == -1)
                {
                    lblOutcomeName.Text = "Saved State";
                }
            }
        }


        public VarTrackerUI(StateTemplate template)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            vars = new Variable[template.ActiveState.Count + 3];
            valueTypes = new Type[template.ActiveState.Count + 3];
            state = new PlayerState();
            this.template = template;

            Engine.Instance.CallAdded += Instance_CallAdded;
        }

        private void Instance_CallAdded(string path, int outcome)
        {
            if (this.outcome != outcome)
                return;

            var call = Engine.Instance.CallStack.Calls[path];
            object currentValue = null;
            if (call.Count > 0)
            {
                currentValue = call[call.Count - 1].NewValue;
            }

            Invoke((MethodInvoker)(() => { UpdateItem(path, currentValue); }));
        }

        private void UpdateItem(string path, object currentValue)
        {
            if (Handle != null)
                UpdateVariable(path, currentValue);
        }

        public void RefreshList()
        {
            InitVars();
            ConstructVariables();
        }

        private void InitVars()
        {
            
        }

        public void SetState(PlayerState state)
        {
            this.state = state;

            InitVars();
            ConstructVariables();
        }

        public void UpdateVariable(string fullPath, object value)
        {
            var root = tvVariables.Nodes[0];

            for (int i = 0; i < vars.Length; i++)
            {
                if (vars[i] != null)
                {
                    if (vars[i].FullPath == fullPath)
                    {
                        if (!vars[i].CanExpand)
                            vars[i].Value = value;

                        ConstructVarIndex(i, root, true, true);
                        break;
                    }
                }
            }
        }

        private void ConstructVariables()
        {
            tvVariables.Nodes.Clear();

            var root = new TreeNode();
            root.Text = "PlayerState";

            tvVariables.Nodes.Add(root);

            for (int i = 0; i < vars.Length; i++)
            {
                if (vars[i] != null)
                {
                    ConstructVarIndex(i, root);
                }
            }
        }

        private void ConstructVarIndex(int index, TreeNode parent, bool highlight = false, bool existing = false)
        {
            var _parent = parent;
            var variable = vars[index];
            if (variable.Parent != null)
            {
                _parent = GetNodeByPath(variable.Parent.FullPath);
            }

            // this is a simple variable
            if (!variable.CanExpand && variable.Value != null)
            {
                TreeNode node;
                if (existing)
                {
                    node = GetNodeByPath(variable.FullPath);
                }
                else
                {
                    node = new TreeNode();
                }

                if (highlight)
                    node.BackColor = Color.Yellow;

                node.Text = variable.Name + " : " + variable.Value.ToString();
                if (!existing)
                    _parent.Nodes.Add(node);
            }
            else if (variable.CanExpand)
            {
                var field = (FieldInfo)variable.Reference;
                // either a list or dictionary
                if (field.FieldType.IsGenericType)
                {
                    if (field.FieldType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        PropertyInfo prop = null;
                        FieldInfo relPathField = null;
                        FieldInfo relDisplayField = null;
                        object stateInstance = null;
                        if (variable.Relationship != null)
                        {
                            prop = typeof(Globals).GetProperty(variable.RelSource, BindingFlags.Public | BindingFlags.Static);
                            relPathField = variable.Relationship.GetField(variable.RelPath);
                            relDisplayField = variable.Relationship.GetField(variable.RelDisplay);
                        }

                        {
                            var dots = 0;
                            for (int i = 0; i < variable.FullPath.Length; i++)
                                if (variable.FullPath[i] == '.')
                                    dots++;

                            if (dots >= 2)
                            {
                                stateInstance = typeof(PlayerState).GetField(variable.Parent.Name).GetValue(state); 
                            }
                            else
                            {
                                stateInstance = state;
                            }
                        }

                        object[] data;

                        TreeNode listNode;
                        if (existing)
                        {
                            listNode = GetNodeByPath(variable.FullPath);
                            listNode.Nodes.Clear();
                        }
                        else
                        {
                            listNode = new TreeNode();
                        }

                        if (highlight)
                            listNode.BackColor = Color.Yellow;

                        listNode.Text = variable.Name;

                        var isFloat = false;
                        if (field.FieldType == typeof(List<float>))
                        {
                            var _data = (List<float>)field.GetValue(stateInstance);
                            data = new object[_data.Count];
                            for (int i = 0; i < _data.Count; i++)
                            {
                                data[i] = _data[i];
                            }
                            isFloat = true;
                        }
                        else
                        {
                            var _data = (List<int>)field.GetValue(stateInstance);
                            data = new object[_data.Count];
                            for (int i = 0; i < _data.Count; i++)
                            {
                                data[i] = _data[i];
                            }
                        }

                        for (int i = 0; i < data.Length; i++)
                        {
                            var val = data[i];

                            var node = new TreeNode();
                            var actual = val.ToString();
                            if (prop != null && !isFloat)
                            {
                                var relSource = (IEnumerable<IDBObject>)prop.GetValue(null);
                                foreach (IDBObject obj in relSource)
                                {
                                    var value = (int)relPathField.GetValue(obj);
                                    if (value == (int)val)
                                    {
                                        actual = (string)relDisplayField.GetValue(obj);
                                    }
                                }

                                node.Text = "[" + i + "] : " + actual;
                                listNode.Nodes.Add(node);
                            }
                            else
                            {
                                node.Text = actual;
                                listNode.Nodes.Add(node);
                            }
                        }

                        if (!existing)
                            _parent.Nodes.Add(listNode);
                    }
                }
                else
                {
                    var root = new TreeNode();
                    root.Text = variable.Name;
                    _parent.Nodes.Add(root);
                }
            }
        }

        private TreeNode GetNodeByPath(string path)
        {
            TreeNode result = null;

            var splitted = path.Split('.');
            foreach (TreeNode node in tvVariables.Nodes)
            {
                if (node.Text.StartsWith(splitted[0]))
                {
                    if (splitted.Length - 1 <= 0)
                        return node;

                    var _paths = new string[splitted.Length - 1];
                    for (int i = 0; i < _paths.Length; i++)
                    {
                        _paths[i] = splitted[i + 1];
                    }

                    return GetNextInPath(node, _paths);
                }
            }

            return result;
        }

        private TreeNode GetNextInPath(TreeNode current, string[] paths)
        {
            foreach (TreeNode result in current.Nodes)
            {
                if (result.Text.StartsWith(paths[0]))
                {
                    if (paths.Length - 1 <= 0)
                        return result;

                    var _paths = new string[paths.Length - 1];
                    for (int i = 0; i < _paths.Length; i++)
                    {
                        _paths[i] = paths[i + 1];
                    }

                    return GetNextInPath(result, _paths);
                }
            }

            return current;
        }

        private void VarTrackerUI_Paint(object sender, PaintEventArgs e)
        {

        }

        private class Variable
        {

            public string Name;
            public string FullPath;
            public Variable Parent;
            public object Value;
            public object Reference;
            public System.Type Relationship;
            public string SubPath;
            public string RelSource;
            public string RelPath;
            public string RelDisplay;
            public string RelDictReference;

            public bool CanExpand;

            public Variable()
            {

            }

        }

        private void openChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvVariables.SelectedNode != null)
            {
                var changesForm = new VariableChangesForm();
                changesForm.PopulateList(tvVariables.SelectedNode.FullPath, outcome);
                changesForm.GoToConversation += ChangesForm_GoToConversation;
                changesForm.ShowDialog();
            }
        }

        private void ChangesForm_GoToConversation(string file, string blockName, int line)
        {
            GoToConversation?.Invoke(file, blockName, line);
        }

        public event OnGoToConversation GoToConversation;
    }
}
