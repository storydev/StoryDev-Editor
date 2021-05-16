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

namespace StoryDev.Components
{
    partial class VarTrackerUI : UserControl
    {

        private StateTemplate template;
        private Variable[] vars;
        private System.Type[] valueTypes;
        private int initVar;

        private PlayerState state;
        public ref PlayerState State 
        { 
            get
            {
                return ref state;
            }
        }

        public VarTrackerUI(StateTemplate template)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            vars = new Variable[template.ActiveState.Count];
            valueTypes = new System.Type[template.ActiveState.Count];
            state = new PlayerState();
            this.template = template;

        }

        private void InitVars()
        {
            // base

            var kvs = template.ActiveState;

            if (kvs.ContainsKey("PlayerState.Frequency"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "Frequency";
                vars[initVar].FullPath = "PlayerState.Frequency";
                vars[initVar].Reference = typeof(PlayerState).GetField("Frequency");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.ConversationCharacters"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "ConversationCharacters";
                vars[initVar].FullPath = "PlayerState.ConversationCharacters";
                vars[initVar].Reference = typeof(PlayerState).GetField("ConversationCharacters");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].CanExpand = true;
                vars[initVar].Relationship = typeof(Character);
                vars[initVar].RelDisplay = "FirstName";
                vars[initVar].RelPath = "ID";

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CharacterPointOfView"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CharacterPointOfView";
                vars[initVar].FullPath = "PlayerState.CharacterPointOfView";
                vars[initVar].Reference = typeof(PlayerState).GetField("CharacterPointOfView");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].Relationship = typeof(Character);
                vars[initVar].RelDisplay = "FirstName";
                vars[initVar].RelPath = "ID";

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentConversationID"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentConversationID";
                vars[initVar].FullPath = "PlayerState.CurrentConversationID";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentConversationID");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentConversationPosition"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentConversationPosition";
                vars[initVar].FullPath = "PlayerState.CurrentConversationPosition";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentConversationPosition");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentPlace"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentPlace";
                vars[initVar].FullPath = "PlayerState.CurrentPlace";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentPlace");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].Relationship = typeof(Place);
                vars[initVar].RelPath = "ID";
                vars[initVar].RelDisplay = "Name";

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentSection"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentSection";
                vars[initVar].FullPath = "PlayerState.CurrentSection";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSection");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].Relationship = typeof(MapSection);
                vars[initVar].RelPath = "ID";
                vars[initVar].RelDisplay = "Name";

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialConvoID"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentSpecialConvoID";
                vars[initVar].FullPath = "PlayerState.CurrentSpecialConvoID";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialConvoID");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialConversationPosition"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentSpecialConversationPosition";
                vars[initVar].FullPath = "PlayerState.CurrentSpecialConversationPosition";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialConversationPosition");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialPlace"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentSpecialPlace";
                vars[initVar].FullPath = "PlayerState.CurrentSpecialPlace";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialPlace");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].Relationship = typeof(Place);
                vars[initVar].RelPath = "ID";
                vars[initVar].RelDisplay = "Name";

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialSection"))
            {
                vars[initVar] = new Variable();
                vars[initVar].Name = "CurrentSpecialSection";
                vars[initVar].FullPath = "PlayerState.CurrentSpecialSection";
                vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialSection");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].Relationship = typeof(MapSection);
                vars[initVar].RelPath = "ID";
                vars[initVar].RelDisplay = "Name";

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;
            }

            if (kvs.ContainsKey("PlayerState.Inventories"))
            {
                var inv = initVar;

                vars[initVar] = new Variable();
                vars[initVar].Name = "Inventories";
                vars[initVar].FullPath = "PlayerState.Inventories";
                vars[initVar].Reference = typeof(PlayerState).GetField("Inventories");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].CanExpand = true;

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;

                if (kvs.ContainsKey("PlayerState.Inventories.Characters"))
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "Characters";
                    vars[initVar].FullPath = "PlayerState.Inventories.Characters";
                    vars[initVar].Parent = vars[inv];
                    vars[initVar].Reference = typeof(InventoryState).GetField("Characters");
                    vars[initVar].CanExpand = true;
                    vars[initVar].Relationship = typeof(Character);
                    vars[initVar].RelPath = "ID";
                    vars[initVar].RelDisplay = "FirstName";

                    valueTypes[initVar] = typeof(int);

                    initVar++;
                }

                if (kvs.ContainsKey("PlayerState.Inventories.ItemID"))
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "ItemID";
                    vars[initVar].FullPath = "PlayerState.Inventories.ItemID";
                    vars[initVar].Parent = vars[inv];
                    vars[initVar].Reference = typeof(InventoryState).GetField("ItemID");
                    vars[initVar].CanExpand = true;
                    vars[initVar].Relationship = typeof(Item);
                    vars[initVar].RelPath = "ID";
                    vars[initVar].RelDisplay = "Name";

                    valueTypes[initVar] = typeof(int);

                    initVar++;
                }

                if (kvs.ContainsKey("PlayerState.Inventories.Quantity"))
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "Quantity";
                    vars[initVar].FullPath = "PlayerState.Inventories.Quantity";
                    vars[initVar].Parent = vars[inv];
                    vars[initVar].Reference = typeof(InventoryState).GetField("Quantity");
                    vars[initVar].CanExpand = true;

                    valueTypes[initVar] = typeof(int);

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.Artefacts"))
            {
                var inv = initVar;

                vars[initVar] = new Variable();
                vars[initVar].Name = "Artefacts";
                vars[initVar].FullPath = "PlayerState.Artefacts";
                vars[initVar].Reference = typeof(PlayerState).GetField("Artefacts");
                vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                vars[initVar].CanExpand = true;

                valueTypes[initVar] = vars[initVar].Value.GetType();

                initVar++;

                if (kvs.ContainsKey("PlayerState.Artefacts.FragmentsDiscovered"))
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "FragmentsDiscovered";
                    vars[initVar].FullPath = "PlayerState.Artefacts.FragmentsDiscovered";
                    vars[initVar].Parent = vars[inv];
                    vars[initVar].Reference = typeof(InventoryState).GetField("FragmentsDiscovered");
                    vars[initVar].CanExpand = true;
                    vars[initVar].Relationship = typeof(ArtefactFragment);
                    vars[initVar].RelPath = "ID";
                    vars[initVar].RelDisplay = "Name";

                    valueTypes[initVar] = typeof(int);

                    initVar++;
                }


            }
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
            public string RelPath;
            public string RelDisplay;

            public bool CanExpand;

            public Variable()
            {

            }

        }
    }
}
