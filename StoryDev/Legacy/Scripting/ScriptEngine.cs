using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Jint;

using StoryDev.Scripting.Modules;

namespace StoryDev.Scripting
{
    [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
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
            // Functions and Actions
            jEngine.SetValue("CreateDataModule", new Func<string, string, Module>(CreateDataModule));
            jEngine.SetValue("RegisterDataModule", new Action<Module>(RegisterDataModule));
            jEngine.SetValue("CreateField", new Func<Module, string, DataType, DataField>(CreateField));

            // Variables
            jEngine.SetValue("TYPE_BOOLEAN", DataType.BOOLEAN);
            jEngine.SetValue("TYPE_DATE", DataType.DATE);
            jEngine.SetValue("TYPE_DATETIME", DataType.DATETIME);
            jEngine.SetValue("TYPE_DECIMAL", DataType.DECIMAL);
            jEngine.SetValue("TYPE_DOUBLE", DataType.DOUBLE);
            jEngine.SetValue("TYPE_FLOAT", DataType.FLOAT);
            jEngine.SetValue("TYPE_INT16", DataType.INT16);
            jEngine.SetValue("TYPE_INT32", DataType.INT32);
            jEngine.SetValue("TYPE_INT64", DataType.INT64);
            jEngine.SetValue("TYPE_INT8", DataType.INT8);
            jEngine.SetValue("TYPE_STRING", DataType.STRING);
            jEngine.SetValue("TYPE_TIMESTAMP", DataType.TIMESTAMP);
            jEngine.SetValue("TYPE_UINT16", DataType.UINT16);
            jEngine.SetValue("TYPE_UINT32", DataType.UINT32);
            jEngine.SetValue("TYPE_UINT64", DataType.UINT64);
            jEngine.SetValue("TYPE_UINT8", DataType.UINT8);

            jEngine.SetValue("LABEL_POS_TOP", LabelPosition.Top);
            jEngine.SetValue("LABEL_POS_LEFT", LabelPosition.Left);
            jEngine.SetValue("LABEL_POS_RIGHT", LabelPosition.Right);
            jEngine.SetValue("LABEL_POS_BOTTOM", LabelPosition.Bottom);
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

        private DataField CreateField(Module module, string name, DataType type)
        {
            var found = false;
            foreach (var f in module.Fields)
            {
                if (f.Name == "name")
                {
                    found = true;
                }
            }

            if (!found)
            {
                var field = new DataField();
                field.Name = name;
                field.Type = type;
                module.Fields.Add(field);

                return module.Fields[module.Fields.Count - 1];
            }
            else
            {
                return null;
            }
        }

        private void RegisterDataModule(Module module)
        {
            DataModules.Add(module);
        }

    }
}
