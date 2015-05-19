using System;
using StructureMap;

namespace Example3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new Container(
                x =>
                {
                    x.For<IFoo>().Use<Foo>();
                    x.For<IBar>().Use<Bar>();
                    x.Policies.SetAllProperties(p => p.OfType<IBar>());
                });

            var localFoo = container.GetInstance<IFoo>();

            Console.WriteLine(localFoo.Message);

            Console.ReadLine();
        }
    }

    public interface IFoo
    {
        string Message { get; }
    }

    public interface IBar
    {
        string User { get; }
    }

    public class Foo : IFoo
    {
        public IBar _Bar { get; set; }

        public string Message
        {
            get
            {
                return string.Format("Message from {0}!", _Bar.User);
            }
        }
    }

    public class Bar : IBar
    {
        public string User
        {
            get
            {
                return "User 1";
            }
        }
    }
}
