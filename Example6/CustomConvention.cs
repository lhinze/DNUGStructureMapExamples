using System;
using System.Linq;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.TypeRules;

namespace Example6
{
    public class CustomConvention : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            if (!type.IsConcrete()) return;

            var pluginType = FindPluginType(type);
            if (pluginType != null && type.HasConstructors())
            {
                registry.For(pluginType).Use(type);
            }
        }

        private Type FindPluginType(Type concreateType)
        {
            var implIndex = concreateType.Name.ToLower().IndexOf("impl");
            var interfaceName = implIndex == -1 ? string.Empty : concreateType.Name.Substring(0, implIndex);
            return concreateType.GetInterfaces().FirstOrDefault(t => t.Name == interfaceName);
        }
    }
}
