using System;
using StructureMap;

namespace Example9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container();
            container.Configure(x => x.AddRegistry<ExampleRegistry>());

            var localFoo = container.GetInstance<IFoo>();

            Console.WriteLine(localFoo.Message);

            Console.ReadLine();
        }
    }
}
