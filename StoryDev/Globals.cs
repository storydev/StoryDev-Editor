using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.IO;

using StoryDev.Components;
using StoryDev.Data;
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
    delegate void OnCallAdded(string path, int outcome);
    delegate void OnGoToConversation(string file, string blockName, int line);
    delegate void OnTabNameChange(string text);
    delegate void OnRequestDataModuleRefresh();

    class Globals
    {

        public static string ShortenName(string path)
        {
            string result = "";
            int startIndex = 0;
            for (int i = path.Length - 1; i > -1; i--)
            {
                if (path[i] == '\\' || path[i] == '/')
                {
                    startIndex = i + 1;
                    break;
                }
            }

            for (int i = startIndex; i < path.Length; i++)
            {
                result += path[i];
            }
            return result;
        }

        //
        // Cache and Other Data
        //

        public static Preferences Preferences { get; private set; }

        private static string AppCacheFolder;

        public static void GlobalInit()
        {
            AppCacheFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "StoryDev");

            if (!Directory.Exists(AppCacheFolder))
            {
                Directory.CreateDirectory(AppCacheFolder);
                Preferences = new Preferences();
            }
            else
            {
                var settingsPath = Path.Combine(AppCacheFolder, "settings.json");
                if (File.Exists(settingsPath))
                    Preferences = JsonConvert.DeserializeObject<Preferences>(File.ReadAllText(settingsPath));
            }
        }

        public static void SavePreferences()
        {
            var content = JsonConvert.SerializeObject(Preferences);
            File.WriteAllText(Path.Combine(AppCacheFolder, "settings.json"), content);
        }

        //
        // Basic Project Stuff
        //

        public static string CurrentProjectFolder;

        public static List<Conversation> Conversations { get; private set; }

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
            SaveIconSetData();
        }

        public static IconSets IconSetData { get; private set; }

        public static void SaveIconSetData()
        {
            var content = JsonConvert.SerializeObject(IconSetData);
            File.WriteAllText(CurrentProjectFolder + "\\iconsets.json", content);
        }

        public static List<Variable> Variables { get; private set; }

        public static void SaveVariables()
        {
            var content = JsonConvert.SerializeObject(Variables);
            File.WriteAllText(CurrentProjectFolder + "\\variables.json", content);
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

            if (!Directory.Exists(path + "\\Scripts"))
            {
                Directory.CreateDirectory(path + "\\Scripts");
            }

            if (!Directory.Exists(path + "\\Events"))
            {
                Directory.CreateDirectory(path + "\\Events");
            }

            if (!Directory.Exists(path + "\\Data Modules"))
            {
                Directory.CreateDirectory(path + "\\Data Modules");
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
        }

        //
        // Misc Utilities
        //

        public static void PushArray<T>(ref T[] arr, T obj)
        {
            var temp = new T[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++) temp[i] = arr[i];
            temp[arr.Length] = obj;
            arr = temp;
        }

    }
    
}
