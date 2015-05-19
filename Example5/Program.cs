using StructureMap;
using System;

namespace Example5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container();
            container.Configure(x => x.AddRegistry<ExampleRegistry>());

            var localFoo = container.GetInstance<EFoo>();

            Console.WriteLine(localFoo.Message);

            Console.ReadLine();
        }
    }
}
