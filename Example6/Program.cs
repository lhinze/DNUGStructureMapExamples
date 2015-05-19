using System;
using StructureMap;

namespace Example6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container();
            container.Configure(x => x.AddRegistry<ExampleRegistry>());

            var localFoo = container.GetInstance<Foo>();

            Console.WriteLine(localFoo.Message);

            Console.ReadLine();
        }
    }
}
