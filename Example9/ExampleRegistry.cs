using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Example9
{
    public class ExampleRegistry : Registry
    {
        public ExampleRegistry()
        {
            Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.WithDefaultConventions();
                });

            For(typeof(IRepository<>)).Use(typeof(Repository<>));
        }
    }
}
