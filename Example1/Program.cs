using System;
using StructureMap;

namespace Example1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container(x => x.For<IFoo>().Use<Foo>());

            var localFoo = container.GetInstance<IFoo>();

            Console.WriteLine(localFoo.Message);

            Console.ReadLine();
        }
    }

    public interface IFoo
    {
        string Message { get; }
    }

    public class Foo : IFoo
    {
        public string Message
        {
            get
            {
                return "Message from Foo!";
            }
        }
    }
}
