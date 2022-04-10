using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using StoryDev.DBO.Scripting;

namespace StoryDev.DBO
{
    public class ItemConstructor
    {

        private static Dictionary<string, Type> resolvedTypes;
        public static IDictionary<string, Type> ResolvedTypes
        {
            get => resolvedTypes;
        }

        public static void Init()
        {
            resolvedTypes = new Dictionary<string, Type>();
        }

        public static Type CreateType(DataStruct str, Type parentType)
        {
            var an = new AssemblyName(str.Name);
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(an, AssemblyBuilderAccess.Run);
            ModuleBuilder mb = assemblyBuilder.DefineDynamicModule("Scripts");
            TypeBuilder tb = mb.DefineType(str.Name,
                TypeAttributes.Public |
                TypeAttributes.Class |
                TypeAttributes.AutoClass |
                TypeAttributes.AnsiClass |
                TypeAttributes.BeforeFieldInit |
                TypeAttributes.AutoLayout, parentType);

            tb.DefineDefaultConstructor(MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);

            foreach (var field in str.Fields)
            {
                AddField(tb, field);
            }

            var resolved = tb.CreateType();
            resolvedTypes.Add(str.Name, resolved);
            return resolved;
        }

        private static void AddField(TypeBuilder tb, DataField field)
        {
            var rlField = tb.DefineField(field.Name, GetTypeFromField(field), FieldAttributes.Public | FieldAttributes.HasDefault);
            // @TODO: Do something with rlField once we have more options
        }

        private static Type GetTypeFromField(DataField field)
        {
            if (field.Type == DataFieldType.BOOLEAN)
                return typeof(bool);
            else if (field.Type == DataFieldType.DATETIME)
                return typeof(DateTime);
            else if (field.Type == DataFieldType.FLOAT)
                return typeof(float);
            else if (field.Type == DataFieldType.INTEGER)
                return typeof(int);
            else if (field.Type == DataFieldType.STRING)
                return typeof(string);
            else if (field.Type == DataFieldType.OFARRAY)
            {
                if (field.ArrayType == DataFieldType.BOOLEAN)
                    return typeof(bool[]);
                else if (field.ArrayType == DataFieldType.DATETIME)
                    return typeof(DateTime[]);
                else if (field.ArrayType == DataFieldType.FLOAT)
                    return typeof(float[]);
                else if (field.ArrayType == DataFieldType.INTEGER)
                    return typeof(int[]);
                else if (field.ArrayType == DataFieldType.STRING)
                    return typeof(string[]);
            }

            return null;
        }

    }
}
