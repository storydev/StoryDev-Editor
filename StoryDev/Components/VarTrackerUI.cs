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
        public PlayerState State 
        {
            get
            {
                return state;
            }
        }

        public VarTrackerUI(StateTemplate template)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            vars = new Variable[template.ActiveState.Count + 3];
            valueTypes = new System.Type[template.ActiveState.Count + 3];
            state = new PlayerState();
            this.template = template;

            InitVars();
        }

        private void InitVars()
        {
            // base

            var kvs = template.ActiveState;

            if (kvs.ContainsKey("PlayerState.Frequency"))
            {
                if (kvs["PlayerState.Frequency"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "Frequency";
                    vars[initVar].FullPath = "PlayerState.Frequency";
                    vars[initVar].Reference = typeof(PlayerState).GetField("Frequency");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.ConversationCharacters"))
            {
                if (kvs["PlayerState.ConversationCharacters"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "ConversationCharacters";
                    vars[initVar].FullPath = "PlayerState.ConversationCharacters";
                    vars[initVar].Reference = typeof(PlayerState).GetField("ConversationCharacters");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].CanExpand = true;
                    vars[initVar].Relationship = typeof(Character);
                    vars[initVar].RelSource = "Characters";
                    vars[initVar].RelDisplay = "FirstName";
                    vars[initVar].RelPath = "ID";

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CharacterPointOfView"))
            {
                if (kvs["PlayerState.CharacterPointOfView"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CharacterPointOfView";
                    vars[initVar].FullPath = "PlayerState.CharacterPointOfView";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CharacterPointOfView");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].Relationship = typeof(Character);
                    vars[initVar].RelSource = "Characters";
                    vars[initVar].RelDisplay = "FirstName";
                    vars[initVar].RelPath = "ID";

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentConversationID"))
            {
                if (kvs["PlayerState.CurrentConversationID"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentConversationID";
                    vars[initVar].FullPath = "PlayerState.CurrentConversationID";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentConversationID");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentConversationPosition"))
            {
                if (kvs["PlayerState.CurrentConversationPosition"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentConversationPosition";
                    vars[initVar].FullPath = "PlayerState.CurrentConversationPosition";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentConversationPosition");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentPlace"))
            {
                if (kvs["PlayerState.CurrentPlace"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentPlace";
                    vars[initVar].FullPath = "PlayerState.CurrentPlace";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentPlace");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].Relationship = typeof(Place);
                    vars[initVar].RelSource = "Places";
                    vars[initVar].RelPath = "ID";
                    vars[initVar].RelDisplay = "Name";

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentSection"))
            {
                if (kvs["PlayerState.CurrentSection"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentSection";
                    vars[initVar].FullPath = "PlayerState.CurrentSection";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSection");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].Relationship = typeof(MapSection);
                    vars[initVar].RelSource = "Sections";
                    vars[initVar].RelPath = "ID";
                    vars[initVar].RelDisplay = "Name";

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialConvoID"))
            {
                if (kvs["PlayerState.CurrentSpecialConvoID"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentSpecialConvoID";
                    vars[initVar].FullPath = "PlayerState.CurrentSpecialConvoID";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialConvoID");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialConversationPosition"))
            {
                if (kvs["PlayerState.CurrentSpecialConversationPosition"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentSpecialConversationPosition";
                    vars[initVar].FullPath = "PlayerState.CurrentSpecialConversationPosition";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialConversationPosition");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialPlace"))
            {
                if (kvs["PlayerState.CurrentSpecialPlace"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentSpecialPlace";
                    vars[initVar].FullPath = "PlayerState.CurrentSpecialPlace";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialPlace");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].Relationship = typeof(Place);
                    vars[initVar].RelSource = "Places";
                    vars[initVar].RelPath = "ID";
                    vars[initVar].RelDisplay = "Name";

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.CurrentSpecialSection"))
            {
                if (kvs["PlayerState.CurrentSpecialSection"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "CurrentSpecialSection";
                    vars[initVar].FullPath = "PlayerState.CurrentSpecialSection";
                    vars[initVar].Reference = typeof(PlayerState).GetField("CurrentSpecialSection");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].Relationship = typeof(MapSection);
                    vars[initVar].RelSource = "Sections";
                    vars[initVar].RelPath = "ID";
                    vars[initVar].RelDisplay = "Name";

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.Inventories"))
            {
                var inv = initVar;

                if (kvs["PlayerState.Inventories"])
                {
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
                        if (kvs["PlayerState.Inventories.Characters"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "Characters";
                            vars[initVar].FullPath = "PlayerState.Inventories.Characters";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(InventoryState).GetField("Characters");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Character);
                            vars[initVar].RelSource = "Characters";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "FirstName";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Inventories.ItemID"))
                    {
                        if (kvs["PlayerState.Inventories.ItemID"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "ItemID";
                            vars[initVar].FullPath = "PlayerState.Inventories.ItemID";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(InventoryState).GetField("ItemID");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Item);
                            vars[initVar].RelSource = "Items";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Inventories.Quantity"))
                    {
                        if (kvs["PlayerState.Inventories.Quantity"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "Quantity";
                            vars[initVar].FullPath = "PlayerState.Inventories.Quantity";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(InventoryState).GetField("Quantity");
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }
                }
            }

            if (kvs.ContainsKey("PlayerState.Artefacts"))
            {
                if (kvs["PlayerState.Artefacts"])
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
                        if (kvs["PlayerState.Artefacts.FragmentsDiscovered"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "FragmentsDiscovered";
                            vars[initVar].FullPath = "PlayerState.Artefacts.FragmentsDiscovered";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(ArtefactState).GetField("FragmentsDiscovered");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(ArtefactFragment);
                            vars[initVar].RelSource = "Fragments";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Artefacts.ArtefactsUnlocked"))
                    {
                        if (kvs["PlayerState.Artefacts.ArtefactsUnlocked"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "ArtefactsUnlocked";
                            vars[initVar].FullPath = "PlayerState.Artefacts.ArtefactsUnlocked";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(ArtefactState).GetField("ArtefactsUnlocked");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Artefact);
                            vars[initVar].RelSource = "Artefacts";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Artefacts.ArtefactsActivated"))
                    {
                        if (kvs["PlayerState.Artefacts.ArtefactsActivated"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "ArtefactsActivated";
                            vars[initVar].FullPath = "PlayerState.Artefacts.ArtefactsActivated";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(ArtefactState).GetField("ArtefactsActivated");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Artefact);
                            vars[initVar].RelSource = "Artefacts";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }
                }
            }

            if (kvs.ContainsKey("PlayerState.Characters"))
            {
                if (kvs["PlayerState.Characters"])
                {
                    var inv = initVar;

                    vars[initVar] = new Variable();
                    vars[initVar].Name = "Characters";
                    vars[initVar].FullPath = "PlayerState.Characters";
                    vars[initVar].Reference = typeof(PlayerState).GetField("Characters");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].CanExpand = true;

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;

                    if (kvs.ContainsKey("PlayerState.Characters.Characters"))
                    {
                        if (kvs["PlayerState.Characters.Characters"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "Characters";
                            vars[initVar].FullPath = "PlayerState.Characters.Characters";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("Characters");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Character);
                            vars[initVar].RelSource = "Characters";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "FirstName";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.Attitudes"))
                    {
                        if (kvs["PlayerState.Characters.Attitudes"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "Attitudes";
                            vars[initVar].FullPath = "PlayerState.Characters.Attitudes";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("Attitudes");
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.HungerLevel"))
                    {
                        if (kvs["PlayerState.Characters.HungerLevel"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "HungerLevel";
                            vars[initVar].FullPath = "PlayerState.Characters.HungerLevel";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("HungerLevel");
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.ThirstLevel"))
                    {
                        if (kvs["PlayerState.Characters.ThirstLevel"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "ThirstLevel";
                            vars[initVar].FullPath = "PlayerState.Characters.ThirstLevel";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("ThirstLevel");
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.PhysicalLevel"))
                    {
                        if (kvs["PlayerState.Characters.PhysicalLevel"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "PhysicalLevel";
                            vars[initVar].FullPath = "PlayerState.Characters.PhysicalLevel";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("PhysicalLevel");
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.MentalLevel"))
                    {
                        if (kvs["PlayerState.Characters.MentalLevel"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "MentalLevel";
                            vars[initVar].FullPath = "PlayerState.Characters.MentalLevel";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("MentalLevel");
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.AttitudesTowards"))
                    {
                        if (kvs["PlayerState.Characters.AttitudesTowards"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "AttitudesTowards";
                            vars[initVar].FullPath = "PlayerState.Characters.AttitudesTowards";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("AttitudesTowards");
                            vars[initVar].Relationship = typeof(Character);
                            vars[initVar].RelSource = "Characters";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "FirstName";
                            vars[initVar].SubPath = "Attitudes";
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.Traits"))
                    {
                        if (kvs["PlayerState.Characters.Traits"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "Traits";
                            vars[initVar].FullPath = "PlayerState.Characters.Traits";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("Traits");
                            vars[initVar].Relationship = typeof(CharacterTrait);
                            vars[initVar].RelSource = "Traits";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Characters.TraitProgress"))
                    {
                        if (kvs["PlayerState.Characters.TraitProgress"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "TraitProgress";
                            vars[initVar].FullPath = "PlayerState.Characters.TraitProgress";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(CharacterState).GetField("TraitProgress");
                            vars[initVar].CanExpand = true;

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }
                }
            }

            if (kvs.ContainsKey("PlayerState.Places"))
            {
                if (kvs["PlayerState.Places"])
                {
                    var inv = initVar;

                    vars[initVar] = new Variable();
                    vars[initVar].Name = "Places";
                    vars[initVar].FullPath = "PlayerState.Places";
                    vars[initVar].Reference = typeof(PlayerState).GetField("Places");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].CanExpand = true;

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;

                    if (kvs.ContainsKey("PlayerState.Places.PlacesUnlocked"))
                    {
                        if (kvs["PlayerState.Places.PlacesUnlocked"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "PlacesUnlocked";
                            vars[initVar].FullPath = "PlayerState.Places.PlacesUnlocked";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(PlaceState).GetField("PlacesUnlocked");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Place);
                            vars[initVar].RelSource = "Places";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Places.SectionsAccessible"))
                    {
                        if (kvs["PlayerState.Places.SectionsAccessible"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "SectionsAccessible";
                            vars[initVar].FullPath = "PlayerState.Places.SectionsAccessible";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(PlaceState).GetField("SectionsAccessible");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(MapSection);
                            vars[initVar].RelSource = "Sections";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Places.GossipsAvailable"))
                    {
                        if (kvs["PlayerState.Places.GossipsAvailable"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "GossipsAvailable";
                            vars[initVar].FullPath = "PlayerState.Places.GossipsAvailable";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(PlaceState).GetField("GossipsAvailable");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(CharacterGossip);
                            vars[initVar].RelSource = "Gossips";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Places.GossipOptionsAvailable"))
                    {
                        if (kvs["PlayerState.Places.GossipOptionsAvailable"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "GossipOptionsAvailable";
                            vars[initVar].FullPath = "PlayerState.Places.GossipOptionsAvailable";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(PlaceState).GetField("GossipOptionsAvailable");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(CharacterGossip);
                            vars[initVar].RelSource = "Gossips";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDictReference = "DisplayOption";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(Dictionary<int, List<int>>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Places.GossipOptionsHidden"))
                    {
                        if (kvs["PlayerState.Places.GossipOptionsHidden"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "GossipOptionsHidden";
                            vars[initVar].FullPath = "PlayerState.Places.GossipOptionsHidden";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(PlaceState).GetField("GossipOptionsHidden");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(CharacterGossip);
                            vars[initVar].RelSource = "Gossips";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDictReference = "DisplayOption";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(Dictionary<int, List<int>>);

                            initVar++;
                        }
                    }
                }
            }

            if (kvs.ContainsKey("PlayerState.AchievementsUnlocked"))
            {
                if (kvs["PlayerState.AchievementsUnlocked"])
                {
                    vars[initVar] = new Variable();
                    vars[initVar].Name = "AchievementsUnlocked";
                    vars[initVar].FullPath = "PlayerState.AchievementsUnlocked";
                    vars[initVar].Reference = typeof(PlayerState).GetField("AchievementsUnlocked");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].CanExpand = true;

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;
                }
            }

            if (kvs.ContainsKey("PlayerState.Journals"))
            {
                if (kvs["PlayerState.Journals"])
                {
                    var inv = initVar;

                    vars[initVar] = new Variable();
                    vars[initVar].Name = "Journals";
                    vars[initVar].FullPath = "PlayerState.Journals";
                    vars[initVar].Reference = typeof(PlayerState).GetField("Journals");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].CanExpand = true;

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;

                    if (kvs.ContainsKey("PlayerState.Journals.JournalsUnlocked"))
                    {
                        if (kvs["PlayerState.Journals.JournalsUnlocked"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "JournalsUnlocked";
                            vars[initVar].FullPath = "PlayerState.Journals.JournalsUnlocked";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(JournalState).GetField("JournalsUnlocked");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Journal);
                            vars[initVar].RelSource = "Journals";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Journals.JournalsAvailable"))
                    {
                        if (kvs["PlayerState.Journals.JournalsAvailable"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "JournalsAvailable";
                            vars[initVar].FullPath = "PlayerState.Journals.JournalsAvailable";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(JournalState).GetField("JournalsAvailable");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Journal);
                            vars[initVar].RelSource = "Journals";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Journals.JournalsInactive"))
                    {
                        if (kvs["PlayerState.Journals.JournalsInactive"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "JournalsInactive";
                            vars[initVar].FullPath = "PlayerState.Journals.JournalsInactive";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(JournalState).GetField("JournalsInactive");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Journal);
                            vars[initVar].RelSource = "Journals";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Journals.JournalsCompleted"))
                    {
                        if (kvs["PlayerState.Journals.JournalsCompleted"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "JournalsCompleted";
                            vars[initVar].FullPath = "PlayerState.Journals.JournalsCompleted";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(JournalState).GetField("JournalsCompleted");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Journal);
                            vars[initVar].RelSource = "Journals";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.Journals.JournalPagesCompleted"))
                    {
                        if (kvs["PlayerState.Journals.JournalPagesCompleted"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "JournalPagesCompleted";
                            vars[initVar].FullPath = "PlayerState.Journals.JournalPagesCompleted";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(JournalState).GetField("JournalPagesCompleted");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(Journal);
                            vars[initVar].RelSource = "Journals";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(Dictionary<int, int>);

                            initVar++;
                        }
                    }
                }
            }

            if (kvs.ContainsKey("PlayerState.SpecialScenarios"))
            {
                if (kvs["PlayerState.SpecialScenarios"])
                {
                    var inv = initVar;

                    vars[initVar] = new Variable();
                    vars[initVar].Name = "SpecialScenarios";
                    vars[initVar].FullPath = "PlayerState.SpecialScenarios";
                    vars[initVar].Reference = typeof(PlayerState).GetField("SpecialScenarios");
                    vars[initVar].Value = ((FieldInfo)vars[initVar].Reference).GetValue(state);
                    vars[initVar].CanExpand = true;

                    valueTypes[initVar] = vars[initVar].Value.GetType();

                    initVar++;

                    if (kvs.ContainsKey("PlayerState.SpecialScenarios.SpecialScenariosUnlocked"))
                    {
                        if (kvs["PlayerState.SpecialScenarios.SpecialScenariosUnlocked"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "SpecialScenariosUnlocked";
                            vars[initVar].FullPath = "PlayerState.SpecialScenarios.SpecialScenariosUnlocked";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(SpecialScenarioState).GetField("SpecialScenariosUnlocked");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(SpecialScenario);
                            vars[initVar].RelSource = "Scenarios";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);

                            initVar++;
                        }
                    }

                    if (kvs.ContainsKey("PlayerState.SpecialScenarios.SpecialScenariosCompleted"))
                    {
                        if (kvs["PlayerState.SpecialScenarios.SpecialScenariosCompleted"])
                        {
                            vars[initVar] = new Variable();
                            vars[initVar].Name = "SpecialScenariosCompleted";
                            vars[initVar].FullPath = "PlayerState.SpecialScenarios.SpecialScenariosCompleted";
                            vars[initVar].Parent = vars[inv];
                            vars[initVar].Reference = typeof(SpecialScenarioState).GetField("SpecialScenariosCompleted");
                            vars[initVar].CanExpand = true;
                            vars[initVar].Relationship = typeof(SpecialScenario);
                            vars[initVar].RelSource = "Scenarios";
                            vars[initVar].RelPath = "ID";
                            vars[initVar].RelDisplay = "Name";

                            valueTypes[initVar] = typeof(List<int>);
                        }
                    }
                }
            }

            ConstructVariables();
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

        private void ConstructVarIndex(int index, TreeNode parent)
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
                var node = new TreeNode();
                node.Text = variable.Name + " : " + variable.Value.ToString();
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

                        if (valueTypes[index] == typeof(List<int>))
                        {
                            var listNode = new TreeNode();
                            listNode.Text = variable.Name;

                            var data = (List<int>)field.GetValue(stateInstance);
                            for (int i = 0; i < data.Count; i++)
                            {
                                var val = data[i];

                                var node = new TreeNode();
                                var actual = val.ToString();
                                if (!string.IsNullOrEmpty(variable.SubPath))
                                {
                                    var ch = Globals.Characters.Find((c) => c.ID == val);
                                    var pNode = new TreeNode();
                                    pNode.Text = "[" + i + "]: " + ch.FirstName;
                                    foreach (var attitude in ch.Attitudes)
                                    {
                                        var towards = Globals.Characters.Find((_c) => _c.ID == attitude.TowardsCharacter);
                                        pNode.Nodes.Add(towards.FirstName + " : " + attitude.Attitude + " (" +
                                            Globals.GetAttitudeName(attitude.Attitude) + ")");
                                    }
                                    listNode.Nodes.Add(pNode);
                                }
                                else if (prop != null)
                                {
                                    var relSource = (IEnumerable<DBObject>)prop.GetValue(null);
                                    foreach (DBObject obj in relSource)
                                    {
                                        var value = (int)relPathField.GetValue(obj);
                                        if (value == val)
                                        {
                                            actual = (string)relDisplayField.GetValue(obj);
                                        }
                                    }

                                    node.Text = "[" + i + "] : " + actual;
                                    listNode.Nodes.Add(node);
                                }
                            }

                            _parent.Nodes.Add(listNode);
                        }
                    }
                    // for journal pages only
                    else if (field.FieldType == typeof(Dictionary<int, int>))
                    {
                        var listNode = new TreeNode();
                        listNode.Text = variable.Name;

                        var source = Globals.Journals;
                        var data = (Dictionary<int, int>)field.GetValue(state.Journals);
                        foreach (var d in data)
                        {
                            var journal = source.Find((j) => j.ID == d.Key);
                            var node = new TreeNode();
                            node.Text = journal.Name + " : " + d.Value;
                            listNode.Nodes.Add(node);
                        }

                        _parent.Nodes.Add(listNode);
                    }
                    else if (field.FieldType == typeof(Dictionary<int, List<int>>))
                    {
                        var listNode = new TreeNode();
                        listNode.Text = variable.Name;

                        var source = Globals.Gossips;
                        var data = (Dictionary<int, List<int>>)field.GetValue(state.Places);
                        for (int i = 0; i < data.Count; i++)
                        {
                            var d = data.ElementAt(i);
                            var gossip = source.Find((g) => g.ID == d.Key);
                            var pNode = new TreeNode();
                            pNode.Text = "[" + i + "]: " + gossip.Name;

                            var displays = d.Value;
                            for (int j = 0; j < displays.Count; j++)
                            {
                                pNode.Nodes.Add(gossip.DisplayOption[displays[i]]);
                            }
                        }

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
                if (node.Text == splitted[0])
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
                if (result.Text == paths[0])
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
    }
}
