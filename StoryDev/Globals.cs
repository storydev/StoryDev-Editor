using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.IO;

using StoryDev.Data;
using StoryDev.Simulation;
using Newtonsoft.Json;

namespace StoryDev
{

    delegate void OnFiltersApplied(IEnumerable<DBFilter> filters);
    delegate void OnSearchSelect(int index);
    delegate void OnSectionIndexChanged(int index);
    delegate void OnCodeStringAdded(string code);
    delegate void OnBranchSelectedIndexChanged(int index);
    delegate void OnBranchAdded(string branchName);
    delegate void OnBranchRenamed(int index, string branchName);
    delegate void OnBranchDeleted(int index);
    delegate void OnBranchesLinked(int parent, int child);
    delegate void OnSimulationStarted(StateTemplate template, List<int> outcomes);
    delegate void OnSimulationStopped();
    delegate void OnCallAdded(string path, int outcome);
    delegate void OnMapPointMoved(int index);
    delegate void OnMapAllowConnections(int index);
    delegate void OnMapConnect(int from, int to);
    delegate void OnMapDisconnect(int from, int to);

    enum GameEvent
    {
        GE_ArtefactAcquired,
        GE_ArtefactUnlocked,
        GE_ArtefactActivated,
        GE_ArtefactFragmentDiscovered,
        GE_ActivityPartCompleted,
        GE_ActivityCompleted,
        GE_CharacterAttitudeChanged,
        GE_CharacterAttitudeTowardsChanged,
        GE_CharacterTraitProgressed,
        GE_GroupFrequencyChanged,
        GE_SpecialFeatureProgress,
        GE_SpecialFeatureComplete,
        GE_ItemAcquired,
        GE_ItemUsed,
        GE_ItemExpended,
        GE_JournalProgress,
        GE_JournalInactive,
        GE_JournalComplete,
        GE_SectionDiscovered,
        GE_SectionEntered,
        GE_SectionLeave,
        GE_PlaceUnlocked,
        GE_ConversationChanging,
        GE_ConversationChanged,
        GE_ConversationAdvanced,
        GE_ChapterChanged,
        GE_PointOfViewChanged,
        GE_TimeAdvanced,
        GE_RealTimeAdvanced
    }

    enum ArtefactRarity
    {
        Common,
        Rare,
        ExtraRare
    }

    enum ItemRarity
    {
        Common,
        Uncommon,
        Rare,
        Super,
        Impossible
    }

    enum ItemUseContext
    {
        Feed,
        Thirst,
        Knowledge,
        Wound,
        Antidote,
        MeleeCombat,
        RangedCombat,
        Misc
    }

    class Globals
    {

        public static readonly string[] ArtefactRarities =
        {
            "Common",
            "Rare",
            "ExtraRare"
        };

        public static readonly string[] ItemRarities =
        {
            "Common",
            "Uncommon",
            "Rare",
            "Super",
            "Impossible"
        };

        public static readonly string[] ItemUseContexts =
        {
            "Feed",
            "Thirst",
            "Knowledge",
            "Wound",
            "Antidote",
            "Melee Combat",
            "Ranged Combat",
            "Miscellaneous"
        };

        public static readonly string[] GameEvents =
        {
            "Artefact Acquired",
            "Artefact Unlocked",
            "Artefact Activated",
            "Artefact Fragment Discovered",
            "Activity Part Completed",
            "Activity Completed",
            "Character Attitude Changed",
            "Character Attitude Towards Changed",
            "Character Trait Progressed",
            "Group Frequency Changed",
            "Special Feature Progress",
            "Special Feature Complete",
            "Item Acquired",
            "Item Used",
            "Item Expended",
            "Journal Progress",
            "Journal Inactive",
            "Journal Complete",
            "Section Discovered",
            "Section Entered",
            "Section Leave",
            "Place Unlocked",
            "Conversation Changing",
            "Conversation Changed",
            "Conversation Advanced",
            "Chapter Changed",
            "Point Of View Changed",
            "Time Advanced",
            "Real Time Advanced"
        };

        public static readonly string[] AchievementCategories =
        {
            "Story",
            "Artefacts",
            "Characters",
            "Activities",
            "Sections",
            "Special Feature",
            "Items"
        };

        public static readonly string[] ScriptFunctions =
        {
            // Adjusts the frequency value of the player.
            "AdjustFrequency",
            // Acquire an artefact fragment by ID value, if unlocked.
            "AcquireArtefactFragment",
            // Unlock access to an artefact by ID.
            "UnlockArtefact",
            // Adjusts the value of a character attitude towards another character.
            "AdjustCharacterAttitudeTowards",
            // Directly set the value of a character attitude towards another character.
            "SetCharacterAttitudeTowards",
            // Adjusts the value of a group's frequency towards the player.
            "AdjustGroupFrequency",
            // Adjusts the value of a character attitude.
            "AdjustCharacterAttitude",
            // Directly set the value of a character attitude.
            "SetCharacterAttitude",
            // Adjusts the progress of a character's trait by id.
            "AdjustCharacterTrait",
            // Adjusts the quantity of a specific item by id. If the item does not exist in the inventory, create it at the value.
            "AdjustInventoryItem",
            // Consumes a single item from the inventory, executing it's script. If the item is not available, this function returns false.
            "ConsumeItem",
            // Adjusts the total cash the player has.
            "AdjustInventoryCash",
            // Unlocks a place by id.
            "UnlockPlace",
            // Unlocks a section of a place by ID.
            "UnlockSection",
            // Accesses a section by ID immediately.
            "AccessSection",
            // Unlocks a character in a section of a map.
            "UnlockCharacterGossip",
            // Hides a character from a section of a map.
            "HideCharacterGossip",
            // Unlocks a journal and adds it to the player's journal list.
            "UnlockJournal",
            // Advances a journal by a given id by one page. Completes the journal if the next page is the last page.
            "AdvanceJournal",
            // Unlocks access to a special feature scenario by ID.
            "UnlockScenario",
            // Completes the currently active scenario.
            "CompleteCurrentScenario",
            // Starts a conversation
            "StartConversation",
            // Requests that the given character's vendor items is displayed.
            "OpenVendor",
        };

        public static readonly string[] ConditionalFunctions =
        {
            // Has a Character an attitude set to a value in or around the given attitude.
            "HasCharacterAttitude",
            // Has a Character an attitude set to a value in or around the given attitude towards a given character.
            "HasCharacterAttitudeTowards",
            // Has the player a frequency of the specified value or greater.
            "HasFrequency",
            // Has the player a frequency of the specified value or greater towards a given character's related group.
            "HasFrequencyWithGroup",
            // Get whether or not the given character is the current point of view in conversation.
            "IsCurrentPOV",
            // Has the player acquired a specific artefact fragment.
            "HasArtefactFragment",
            // Has the player fully completed finding all fragments for the given artefact.
            "HasArtefactCompleted",
            // Has the player activated the given artefact.
            "HasArtefactActivated",
            // Has the player unlocked the given place.
            "HasUnlockedPlace",
            // Has the given activity been progressed by a certain value.
            "HasActivityProgress",
            // Has the given specific activity part been complete.
            "HasActivityPartComplete",
            // Has the given activity been completed.
            "HasActivityComplete",
            // Has the given character's trait been progressed to the given value or higher.
            "HasCharacterTraitProgress",
            // Has the given journal progressed up to the number of pages given.
            "HasJournalProgress",
            // Has the given journal been completed.
            "HasJournalCompleted",
            // Has the player the given item in their inventory.
            "HasItem",
            // Has the player the given item at the number given in their inventory.
            "HasItemNumber",
            // Is the given item available to purchase from the given character.
            "IsItemAvailable",
            // Has the player completed the given scenario from a special feature.
            "HasScenarioCompleted",
            // Has the player unlocked the given section.
            "HasUnlockedSection",
            // Is the given section available to enter from the current section.
            "IsSectionAvailable",
            // Is the player currently within the given section.
            "IsWithinSection",
            // Has the player spoken with a particular character, based on their gossip ID.
            "HasSpokenWith",
            // Has the player chosen the given gossip option with the given gossip.
            "HasGossipOptionChosen",
            // Is the given character nourished.
            "IsCharacterNourished",
            // Does the given character require healing of any kind.
            "CharacterRequiresHealing"
        };

        //
        // Cache and Other Data
        //

        public static Preferences Preferences { get; private set; }

        private static string AppCacheFolder;

        public static void GlobalInit()
        {
            AppCacheFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            AppCacheFolder += "\\StoryDev\\";

            if (!Directory.Exists(AppCacheFolder))
            {
                Directory.CreateDirectory(AppCacheFolder);
                Preferences = new Preferences();
            }
            else
            {
                Preferences = JsonConvert.DeserializeObject<Preferences>(File.ReadAllText(AppCacheFolder + "settings.json"));
            }
        }

        public static void SavePreferences()
        {
            var content = JsonConvert.SerializeObject(Preferences);
            File.WriteAllText(AppCacheFolder + "settings.json", content);
        }

        //
        // Basic Project Stuff
        //

        public static string CurrentProjectFolder;

        public static List<Conversation> Conversations { get; private set; }

        public static StoryOrder StoryOrder { get; private set; }

        public static void SaveStoryOrder()
        {
            var content = JsonConvert.SerializeObject(StoryOrder);
            File.WriteAllText(CurrentProjectFolder + "\\story-order.json", content);
        }

        public static List<string> Chapters { get; private set; }

        public static void ReloadChapters()
        {
            Chapters.Clear();

            foreach (var dir in Directory.GetDirectories(CurrentProjectFolder + "\\Chapters"))
            {
                var folderName = dir.Substring(dir.LastIndexOf('\\') + 1);
                Chapters.Add(folderName);
            }
        }

        public static void SaveAll()
        {
            SaveAchievements();
            SaveActivities();
            SaveArtefacts();
            SaveCharacterGroups();
            SaveCharacters();
            SaveFeature();
            SaveFragments();
            SaveGossips();
            SaveIconSetData();
            SaveItems();
            SaveJournals();
            SaveMaps();
            SavePlaces();
            SaveScenarios();
            SaveSections();
            SaveSettings();
            SaveTraits();
        }

        public static IconSets IconSetData { get; private set; }

        public static void SaveIconSetData()
        {
            var content = JsonConvert.SerializeObject(IconSetData);
            File.WriteAllText(CurrentProjectFolder + "\\iconsets.json", content);
        }

        public static SimulationOptions Simulation { get; private set; }

        public static void SaveSimulationOptions()
        {
            var content = JsonConvert.SerializeObject(Simulation);
            File.WriteAllText(CurrentProjectFolder + "\\simulation-options.json", content);
        }

        public static List<Variable> Variables { get; private set; }

        public static void SaveVariables()
        {
            var content = JsonConvert.SerializeObject(Variables);
            File.WriteAllText(CurrentProjectFolder + "\\variables.json", content);
        }

        //
        // Characters and Functions
        //

        public static List<Character> Characters { get; private set; }

        public static void SaveCharacters()
        {
            var content = JsonConvert.SerializeObject(Characters);
            File.WriteAllText(CurrentProjectFolder + "\\characters.json", content);
        }

        public static Character GetCharacter(int id)
        {
            Character result = null;
            foreach (var character in Characters)
            {
                if (character.ID == id)
                {
                    result = character;
                    break;
                }
            }
            return result;
        }

        public static int GetCharacterIndex(int id)
        {
            int result = -1;
            for (int i = 0; i < Characters.Count; i++)
            {
                if (Characters[i].ID == id)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static readonly string[] Attitudes =
        {
            "Hate",
            "Angry",
            "Upset",
            "Content",
            "Happy",
            "Joyous",
            "Love"
        };

        public static readonly string[] TraitPriorities =
        {
            "Normal",
            "High",
            "Highest"
        };

        public static string GetAttitudeName(int value)
        {
            if (value >= -50 && value < -30)
            {
                return "Hate";
            }
            else if (value >= -30 && value < -10)
            {
                return "Angry";
            }
            else if (value >= -10 && value < 0)
            {
                return "Upset";
            }
            else if (value >= 0 && value < 10)
            {
                return "Content";
            }
            else if (value >= 10 && value < 30)
            {
                return "Happy";
            }
            else if (value >= 30 && value < 45)
            {
                return "Joyous";
            }
            else if (value >= 45 && value <= 50)
            {
                return "Love";
            }

            return string.Empty;
        }

        public static int ResolveAttitudeIndex(int index)
        {
            if (index == 0)
                return -50;
            else if (index == 1)
                return -30;
            else if (index == 2)
                return -10;
            else if (index == 3)
                return 0;
            else if (index == 4)
                return 10;
            else if (index == 5)
                return 30;
            else if (index == 6)
                return 50;

            return 0;
        }

        /// <summary>
        /// Gets the index 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetAttitudeIndexByValue(int value)
        {
            if (value >= -50 && value < -30)
                return 0;
            else if (value >= -30 && value < -10)
                return 1;
            else if (value >= -10 && value < 0)
                return 2;
            else if (value >= 0 && value < 10)
                return 3;
            else if (value >= 10 && value < 30)
                return 4;
            else if (value >= 30 && value < 45)
                return 5;
            else if (value >= 45 && value <= 50)
                return 6;

            return -1;
        }

        //
        // Character Groups and Functions
        //

        public static List<CharacterGroup> CharacterGroups { get; private set; }

        public static void SaveCharacterGroups()
        {
            var content = JsonConvert.SerializeObject(CharacterGroups);
            File.WriteAllText(CurrentProjectFolder + "\\character-groups.json", content);
        }

        public static CharacterGroup GetCharacterGroup(int id)
        {
            CharacterGroup result = null;
            foreach (var group in CharacterGroups)
            {
                if (group.ID == id)
                {
                    result = group;
                    break;
                }
            }
            return result;
        }

        public static int GetCharacterGroupIndex(int id)
        {
            int result = -1;
            for (int i = 0; i < CharacterGroups.Count; i++)
            {
                if (CharacterGroups[i].ID == id)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        //
        // Gossips and Functions
        //

        public static List<CharacterGossip> Gossips { get; private set; }

        public static void SaveGossips()
        {
            var content = JsonConvert.SerializeObject(Gossips);
            File.WriteAllText(CurrentProjectFolder + "\\character-gossips.json", content);
        }

        //
        // Traits and Functions
        //

        public static List<CharacterTrait> Traits { get; private set; }

        public static void SaveTraits()
        {
            var content = JsonConvert.SerializeObject(Traits);
            File.WriteAllText(CurrentProjectFolder + "\\traits.json", content);
        }

        public static int GetTraitIndex(int id)
        {
            int result = -1;
            for (int i = 0; i < Traits.Count; i++)
            {
                if (Traits[i].ID == id)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static List<CharacterTrait> GetTraits(int characterId)
        {
            List<CharacterTrait> result = new List<CharacterTrait>();
            foreach (var trait in Traits)
            {
                if (trait.CharacterID == characterId)
                {
                    result.Add(trait);
                }
            }

            return result;
        }

        //
        // Items and Functions
        //

        public static List<Item> Items { get; private set; }

        public static void SaveItems()
        {
            var content = JsonConvert.SerializeObject(Items);
            File.WriteAllText(CurrentProjectFolder + "\\items.json", content);
        }

        public static Item GetItem(int id)
        {
            Item result = null;
            foreach (var item in Items)
            {
                if (item.ID == id)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }

        //
        // Journals and Functions
        //

        public static List<Journal> Journals { get; private set; }

        public static int GetJournalIndex(int id)
        {
            for (int i = 0; i < Journals.Count; i++)
            {
                if (Journals[i].ID == id)
                    return i;
            }

            return -1;
        }

        public static void SaveJournals()
        {
            var content = JsonConvert.SerializeObject(Journals);
            File.WriteAllText(CurrentProjectFolder + "\\journals.json", content);
        }

        //
        // Places and Functions
        //

        public static List<Place> Places { get; private set; }

        public static void SavePlaces()
        {
            var content = JsonConvert.SerializeObject(Places);
            File.WriteAllText(CurrentProjectFolder + "\\places.json", content);
        }

        //
        // Activities and Functions
        //

        public static List<Activity> Activities { get; private set; }

        public static List<Activity> GetActivitiesByPlace(int placeId)
        {
            var results = new List<Activity>();

            foreach (var activity in Activities)
            {
                if (activity.PlaceID == placeId)
                {
                    results.Add(activity);
                }
            }

            return results;
        }

        public static void SaveActivities()
        {
            var content = JsonConvert.SerializeObject(Activities);
            File.WriteAllText(CurrentProjectFolder + "\\activities.json", content);
        }

        //
        // Sections and Functions
        //

        public static List<MapSection> Sections { get; private set; }

        public static void SaveSections()
        {
            var content = JsonConvert.SerializeObject(Sections);
            File.WriteAllText(CurrentProjectFolder + "\\sections.json", content);
        }

        public static List<MapSection> GetSectionsByPlace(int placeID)
        {
            return Sections.FindAll((s) => s.PlaceID == placeID);
        }

        //
        // Artefacts and Functions
        //

        public static List<Artefact> Artefacts { get; private set; }

        public static void SaveArtefacts()
        {
            var content = JsonConvert.SerializeObject(Artefacts);
            File.WriteAllText(CurrentProjectFolder + "\\artefacts.json", content);
        }

        //
        // Artefact Fragments and Functions
        //

        public static List<ArtefactFragment> Fragments { get; private set; }

        public static void SaveFragments()
        {
            var content = JsonConvert.SerializeObject(Fragments);
            File.WriteAllText(CurrentProjectFolder + "\\fragments.json", content);
        }

        //
        // Special Feature, Scenarios and Functions
        //

        public static SpecialFeature Feature { get; private set; }

        public static void SaveFeature()
        {
            var content = JsonConvert.SerializeObject(Feature);
            File.WriteAllText(CurrentProjectFolder + "\\special-feature.json", content);
        }

        public static List<SpecialScenario> Scenarios { get; private set; }

        public static void SaveScenarios()
        {
            var content = JsonConvert.SerializeObject(Scenarios);
            File.WriteAllText(CurrentProjectFolder + "\\scenarios.json", content);
        }

        //
        // Achievements and Functions
        //

        public static List<Achievement> Achievements { get; private set; }

        public static void SaveAchievements()
        {
            var content = JsonConvert.SerializeObject(Achievements);
            File.WriteAllText(CurrentProjectFolder + "\\achievements.json", content);
        }

        //
        // Maps
        //

        public static List<Map> Maps { get; private set; }

        public static void SaveMaps()
        {
            var content = JsonConvert.SerializeObject(Maps);
            File.WriteAllText(CurrentProjectFolder + "\\maps.json", content);
        }

        //
        // Global Data
        //

        public static Identifiers GlobalIdentifiers { get; private set; }

        public static void SaveIdentifiers()
        {
            var content = JsonConvert.SerializeObject(GlobalIdentifiers);
            File.WriteAllText(CurrentProjectFolder + "\\identifiers.json", content);
        }

        public static GlobalSettings Settings { get; private set; }

        public static void SaveSettings()
        {
            var content = JsonConvert.SerializeObject(Settings);
            File.WriteAllText(CurrentProjectFolder + "\\settings.json", content);
        }


        public static string PurgeFilePath(string path)
        {
            var result = "";

            var chars = Path.GetInvalidPathChars();
            for (int i = 0; i < chars.Length; i++)
            {
                result = path.Replace(chars[i], '_');
            }

            return result;
        }

        public static string GetResourcesPath()
        {
            if (!Directory.Exists(CurrentProjectFolder + "\\Resources"))
            {
                Directory.CreateDirectory(CurrentProjectFolder + "\\Resources");
            }

            return CurrentProjectFolder + "\\Resources";
        }

        public static void SetProjectFolder(string path)
        {
            CurrentProjectFolder = path;

            if (!Directory.Exists(path + "\\Chapters"))
            {
                Directory.CreateDirectory(path + "\\Chapters");
                Chapters = new List<string>();
            }
            else
            {
                Chapters = new List<string>();
                ReloadChapters();
            }

            if (File.Exists(path + "\\identifiers.json"))
            {
                var content = File.ReadAllText(path + "\\identifiers.json");
                GlobalIdentifiers = JsonConvert.DeserializeObject<Identifiers>(content);
            }
            else
            {
                GlobalIdentifiers = new Identifiers();
            }

            if (File.Exists(path + "\\Chapters\\conversations.json"))
            {
                var content = File.ReadAllText(path + "\\Chapters\\conversations.json");
                Conversations = JsonConvert.DeserializeObject<List<Conversation>>(content);
            }
            else
            {
                Conversations = new List<Conversation>();
            }

            // Load Characters
            if (File.Exists(path + "\\characters.json"))
            {
                var content = File.ReadAllText(path + "\\characters.json");
                Characters = JsonConvert.DeserializeObject<List<Character>>(content);
            }
            else
            {
                Characters = new List<Character>();
            }

            // Load Character Groups
            if (File.Exists(path + "\\character-groups.json"))
            {
                var content = File.ReadAllText(path + "\\character-groups.json");
                CharacterGroups = JsonConvert.DeserializeObject<List<CharacterGroup>>(content);
            }
            else
            {
                CharacterGroups = new List<CharacterGroup>();
            }

            // Load Gossips
            if (File.Exists(path + "\\character-gossips.json"))
            {
                var content = File.ReadAllText(path + "\\character-gossips.json");
                Gossips = JsonConvert.DeserializeObject<List<CharacterGossip>>(content);
            }
            else
            {
                Gossips = new List<CharacterGossip>();
            }

            // Load Traits
            if (File.Exists(path + "\\traits.json"))
            {
                var content = File.ReadAllText(path + "\\traits.json");
                Traits = JsonConvert.DeserializeObject<List<CharacterTrait>>(content);
            }
            else
            {
                Traits = new List<CharacterTrait>();
            }

            // Load Items
            if (File.Exists(path + "\\items.json"))
            {
                var content = File.ReadAllText(path + "\\items.json");
                Items = JsonConvert.DeserializeObject<List<Item>>(content);
            }
            else
            {
                Items = new List<Item>();
            }

            // Load Journals
            if (File.Exists(path + "\\journals.json"))
            {
                var content = File.ReadAllText(path + "\\journals.json");
                Journals = JsonConvert.DeserializeObject<List<Journal>>(content);
            }
            else
            {
                Journals = new List<Journal>();
            }

            // Load Places
            if (File.Exists(path + "\\places.json"))
            {
                var content = File.ReadAllText(path + "\\places.json");
                Places = JsonConvert.DeserializeObject<List<Place>>(content);
            }
            else
            {
                Places = new List<Place>();
            }

            // Load Activities
            if (File.Exists(path + "\\activities.json"))
            {
                var content = File.ReadAllText(path + "\\activities.json");
                Activities = JsonConvert.DeserializeObject<List<Activity>>(content);
            }
            else
            {
                Activities = new List<Activity>();
            }

            // Load Sections
            if (File.Exists(path + "\\sections.json"))
            {
                var content = File.ReadAllText(path + "\\sections.json");
                Sections = JsonConvert.DeserializeObject<List<MapSection>>(content);
            }
            else
            {
                Sections = new List<MapSection>();
            }

            // Load Icon Sets
            if (File.Exists(path + "\\iconsets.json"))
            {
                var content = File.ReadAllText(path + "\\iconsets.json");
                IconSetData = JsonConvert.DeserializeObject<IconSets>(content);
            }
            else
            {
                IconSetData = new IconSets();
            }

            // Load Artefacts
            if (File.Exists(path + "\\artefacts.json"))
            {
                var content = File.ReadAllText(path + "\\artefacts.json");
                Artefacts = JsonConvert.DeserializeObject<List<Artefact>>(content);
            }
            else
            {
                Artefacts = new List<Artefact>();
            }

            // Load Fragments
            if (File.Exists(path + "\\fragments.json"))
            {
                var content = File.ReadAllText(path + "\\fragments.json");
                Fragments = JsonConvert.DeserializeObject<List<ArtefactFragment>>(content);
            }
            else
            {
                Fragments = new List<ArtefactFragment>();
            }

            // Load Settings
            if (File.Exists(path + "\\settings.json"))
            {
                var content = File.ReadAllText(path + "\\settings.json");
                Settings = JsonConvert.DeserializeObject<GlobalSettings>(content);
            }
            else
            {
                Settings = new GlobalSettings();
            }

            // Load Special Feature
            if (File.Exists(path + "\\special-feature.json"))
            {
                var content = File.ReadAllText(path + "\\special-feature.json");
                Feature = JsonConvert.DeserializeObject<SpecialFeature>(content);
            }
            else
            {
                Feature = new SpecialFeature();
            }

            // Load Scenarios
            if (File.Exists(path + "\\scenarios.json"))
            {
                var content = File.ReadAllText(path + "\\scenarios.json");
                Scenarios = JsonConvert.DeserializeObject<List<SpecialScenario>>(content);
            }
            else
            {
                Scenarios = new List<SpecialScenario>();
            }

            // Load Achievements
            if (File.Exists(path + "\\achievements.json"))
            {
                var content = File.ReadAllText(path + "\\achievements.json");
                Achievements = JsonConvert.DeserializeObject<List<Achievement>>(content);
            }
            else
            {
                Achievements = new List<Achievement>();
            }

            // Load Simulation Options
            if (File.Exists(path + "\\simulation-options.json"))
            {
                var content = File.ReadAllText(path + "\\simulation-options.json");
                Simulation = JsonConvert.DeserializeObject<SimulationOptions>(content);
            }
            else
            {
                Simulation = new SimulationOptions();
                SaveSimulationOptions();
            }

            // Load Story Order data
            if (File.Exists(path + "\\story-order.json"))
            {
                var content = File.ReadAllText(path + "\\story-order.json");
                StoryOrder = JsonConvert.DeserializeObject<StoryOrder>(content);
            }
            else
            {
                StoryOrder = new StoryOrder();
            }

            // Load Custom Variables
            if (File.Exists(path + "\\variables.json"))
            {
                var content = File.ReadAllText(path + "\\variables.json");
                Variables = JsonConvert.DeserializeObject<List<Variable>>(content);
            }
            else
            {
                Variables = new List<Variable>();
            }

            // Load Maps
            if (File.Exists(path + "\\maps.json"))
            {
                var content = File.ReadAllText(path + "\\maps.json");
                Maps = JsonConvert.DeserializeObject<List<Map>>(content);
            }
            else
            {
                Maps = new List<Map>();
            }
        }

        

    }

    class PlayerState
    {

        public float Cash;
        public float Frequency;
        public List<int> ConversationCharacters;
        public int CharacterPointOfView;
        public int CurrentConversationID;
        public int CurrentConversationPosition;
        public int CurrentPlace;
        public int CurrentSection;

        public int CurrentSpecialConvoID;
        public int CurrentSpecialConversationPosition;
        public int CurrentSpecialPlace;
        public int CurrentSpecialSection;

        public GroupState Groups;
        public InventoryState Inventories;
        public ArtefactState Artefacts;
        public CharacterState Characters;
        public PlaceState Places;
        public List<int> AchievementsUnlocked;
        public JournalState Journals;
        public SpecialScenarioState SpecialScenarios;

        public PlayerState()
        {
            Cash = 0.0f;
            Frequency = 3.0f;
            CharacterPointOfView = -1;
            CurrentConversationID = -1;
            CurrentConversationPosition = -1;
            CurrentPlace = -1;
            CurrentSection = -1;
            ConversationCharacters = new List<int>();

            CurrentSpecialConvoID = -1;
            CurrentSpecialConversationPosition = -1;
            CurrentSpecialPlace = -1;
            CurrentSpecialSection = -1;

            Groups = new GroupState();
            Inventories = new InventoryState();
            Artefacts = new ArtefactState();
            Characters = new CharacterState();
            Places = new PlaceState();
            AchievementsUnlocked = new List<int>();
            Journals = new JournalState();
            SpecialScenarios = new SpecialScenarioState();
        }

    }

    class GroupState
    {

        public List<int> Groups;
        public List<float> GroupFrequencies;
        public List<float> GroupFrequencyRates;

        public GroupState()
        {
            Groups = new List<int>();
            GroupFrequencies = new List<float>();
            GroupFrequencyRates = new List<float>();
        }

    }
    
    class InventoryState
    {

        public List<int> Characters;
        public List<int> ItemID;
        public List<int> Quantity;

        public InventoryState()
        {
            Characters = new List<int>();
            ItemID = new List<int>();
            Quantity = new List<int>();
        }

    }

    class ArtefactState
    {

        public List<int> FragmentsDiscovered;
        public List<int> ArtefactsUnlocked;
        public List<int> ArtefactsActivated;

        public ArtefactState()
        {
            FragmentsDiscovered = new List<int>();
            ArtefactsActivated = new List<int>();
            ArtefactsUnlocked = new List<int>();
        }

    }

    class CharacterState
    {

        public List<int> Characters;
        public List<int> Attitudes;
        public List<int> HungerLevel;
        public List<int> ThirstLevel;
        public List<int> PhysicalLevel;
        public List<int> MentalLevel;

        public List<int> AttitudesTowards;
        public List<int> Traits;
        public List<int> TraitProgress;

        public CharacterState()
        {
            Characters = new List<int>();
            Attitudes = new List<int>();
            HungerLevel = new List<int>();
            ThirstLevel = new List<int>();
            PhysicalLevel = new List<int>();
            MentalLevel = new List<int>();
            AttitudesTowards = new List<int>();
            Traits = new List<int>();
            TraitProgress = new List<int>();

            AttitudesTowards.Add(Globals.Characters[0].ID);
        }

    }

    class PlaceState
    {

        public List<int> PlacesUnlocked;
        public List<int> SectionsAccessible;
        public List<int> GossipsAvailable;
        public Dictionary<int, List<int>> GossipOptionsAvailable;
        public Dictionary<int, List<int>> GossipOptionsHidden;

        public PlaceState()
        {
            PlacesUnlocked = new List<int>();
            SectionsAccessible = new List<int>();
            GossipsAvailable = new List<int>();
            GossipOptionsAvailable = new Dictionary<int, List<int>>();
            GossipOptionsHidden = new Dictionary<int, List<int>>();
        }

    }

    class JournalState
    {

        public List<int> JournalsUnlocked;
        public List<int> JournalsAvailable;
        public List<int> JournalsInactive;
        public List<int> JournalsCompleted;
        public Dictionary<int, int> JournalPagesCompleted;

        public JournalState()
        {
            JournalPagesCompleted = new Dictionary<int, int>();
            JournalsAvailable = new List<int>();
            JournalsCompleted = new List<int>();
            JournalsInactive = new List<int>();
            JournalsUnlocked = new List<int>();
        }

    }

    class SpecialScenarioState
    {

        public List<int> SpecialScenariosUnlocked;
        public List<int> SpecialScenariosCompleted;
        public List<float> SpecialScenarioScores;

        public SpecialScenarioState()
        {
            SpecialScenariosUnlocked = new List<int>();
            SpecialScenariosCompleted = new List<int>();
            SpecialScenarioScores = new List<float>();
        }

    }

    class SimulationOptions
    {

        public bool EnableSimulationsStartup;
        public bool Resimulate;
        public int BestOutcome;
        public int WorstOutcome;
        public string StateRecordingsFolder;
        public bool EnableStateRecording;
        public List<StateTemplate> Templates;

        public SimulationOptions()
        {
            EnableSimulationsStartup = true;
            Resimulate = false;
            BestOutcome = 7;
            WorstOutcome = 3;
            StateRecordingsFolder = "";
            EnableStateRecording = true;
            Templates = new List<StateTemplate>();
        }

    }

    class StateTemplate
    {

        public string Name;
        public bool SaveStatePerChange;
        public Dictionary<string, bool> ActiveState;

        public StateTemplate()
        {
            Name = "";
            SaveStatePerChange = false;
            ActiveState = new Dictionary<string, bool>();
        }

    }
    
}
