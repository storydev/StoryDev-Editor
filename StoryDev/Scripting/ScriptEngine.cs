using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Jint;


namespace StoryDev.Scripting
{
    class ScriptEngine
    {

        private Engine jEngine;

        public List<Module> DataModules { get; private set; }

        public ScriptEngine()
        {
            DataModules = new List<Module>();

            jEngine = new Engine();

            InitScripts();
            InitDataModules();
        }

        public void ExecuteDataModules()
        {
            DataModules.Clear();
            InitDataModules();
        }

        private void InitScripts()
        {
            jEngine.SetValue("CreateDataModule", new Func<string, string, Module>(CreateDataModule));
            jEngine.SetValue("RegisterDataModule", new Action<Module>(RegisterDataModule));
        }

        private void InitDataModules()
        {
            if (Directory.Exists(Globals.CurrentProjectFolder + "\\Data Modules\\"))
            {
                var files = Directory.GetFiles(Globals.CurrentProjectFolder + "\\Data Modules\\", "*.hxs");
                foreach (var file in files)
                {
                    var content = File.ReadAllText(file);
                    jEngine.Execute(content);
                }
            }
        }


        private static ScriptEngine _instance;
        public static ScriptEngine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScriptEngine();

                return _instance;
            }
        }

        //
        // Scripting
        //

        private Module CreateDataModule(string name, string typename)
        {
            var module = new Module();
            module.Name = name;
            module.TypeName = typename;
            return module;
        }

        private void RegisterDataModule(Module module)
        {
            DataModules.Add(module);
        }

    }
}
