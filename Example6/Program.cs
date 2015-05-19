using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Example6
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
