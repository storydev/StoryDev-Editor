using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Newtonsoft.Json;
using System.IO;
using StoryDev.DBO.Scripting;

namespace StoryDev.DBO.Json
{
    public class DBObject : IDBObject
    {

        public int ID;

        public static DBManager Manager { get; private set; }

        public static void SetManagerOptions(DataStruct str, string sourceFolder)
        {
            Manager = new DBManager();
            var filePath = Path.Combine(sourceFolder, str.SourceFile);

            Manager.SourcePath.Add(str.Name, filePath);
            Manager.Items.Add(str.Name, new List<object>());
            Manager.StructReference = str;

            if (!File.Exists(filePath))
                File.WriteAllText(filePath, "");
            else
            {
                var results = File.ReadAllText(filePath);
                Manager.Items[str.Name] = JsonConvert.DeserializeObject<List<object>>(results);
            }
        }

        public bool Delete()
        {
            var name = GetType().Name;

            var itemIndex = Manager.Items[name].FindIndex((obj) => ((DBObject)obj).ID == ID);
            if (itemIndex == -1)
                return false;

            Manager.Items[name].RemoveAt(itemIndex);
            var content = JsonConvert.SerializeObject(Manager.Items);
            File.WriteAllText(Manager.SourcePath[name], content);

            return true;
        }

        public void Insert()
        {
            var name = GetType().Name;

            Manager.Items[name].Add(this);
            var content = JsonConvert.SerializeObject(Manager.Items[name]);
            File.WriteAllText(Manager.SourcePath[name], content);
        }

        public void Update()
        {
            var name = GetType().Name;

            var itemIndex = Manager.Items[name].FindIndex((obj) => ((DBObject)obj).ID == ID);

            Manager.Items[name].RemoveAt(itemIndex);
            Manager.Items[name].Add(this);

            var content = JsonConvert.SerializeObject(Manager.Items);
            File.WriteAllText(Manager.SourcePath[name], content);
        }
    }
}
