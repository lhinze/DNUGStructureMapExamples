using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Example8
{
    public class ExampleRegistry : Registry
    {
        public ExampleRegistry()
        {
            Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                    s.ConnectImplementationsToTypesClosing(typeof(IRepository<>));
                });
        }
    }
}
