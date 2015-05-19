using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.TypeRules;
using System;
using System.Linq;

namespace Example5
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
            var interfaceName = "E" + concreateType.Name;
            return concreateType.GetInterfaces().FirstOrDefault(t => t.Name == interfaceName);
        }
    }
}
