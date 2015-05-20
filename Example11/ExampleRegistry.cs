using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Example11
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

            For(typeof(IRepository<>)).Singleton().Use(typeof(Repository<>));

            For<IFoo>().DecorateAllWith<FooLogger>();
        }
    }
}
