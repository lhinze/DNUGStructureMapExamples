using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Example7
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

            For<IBar>().Use<Bar>().Ctor<string>("userName").Is("Registry User");
        }
    }
}
