using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Example6
{
    public class ExampleRegistry : Registry
    {
        public ExampleRegistry()
        {
            Scan(s =>
                {
                    s.TheCallingAssembly();
                    //s.WithDefaultConventions();
                    s.Convention<CustomConvention>();
                });
        }
    }
}
