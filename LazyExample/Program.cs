using System;
using StructureMap;

namespace LazyExample
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
                });

            var foo = container.GetInstance<IFoo>();

            Console.WriteLine("Press ENTER to DoSomething with Foo");
            Console.ReadLine();

            foo.DoSomething();

            Console.ReadKey();
        }
    }

    public interface IFoo
    {
        void DoSomething();
    }

    public class Foo : IFoo
    {
        private readonly Lazy<IBar> _LazyBar;

        public Foo(Lazy<IBar> lazyBar)
        {
            _LazyBar = lazyBar;
        }

        public void DoSomething()
        {
            _LazyBar.Value.Test();
        }
    }

    public interface IBar
    {
        string Test();
    }

    public class Bar : IBar
    {
        public Bar()
        {
            Console.WriteLine("Bar has been constructed.");
        }

        public string Test()
        {
            return string.Empty;
        }
    }
}
