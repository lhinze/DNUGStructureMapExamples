using StructureMap;
using System;

namespace FuncExample
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

            var bar = foo.DoSomething(2);

            bar.PrintValue();

            Console.ReadLine();
        }

        public interface IFoo
        {
            IBar DoSomething(int value);
        }

        public class Foo : IFoo
        {
            private readonly Func<int, IBar> _FuncBar;

            public Foo(Func<int, IBar> funcBar)
            {
                _FuncBar = funcBar;
            }

            public IBar DoSomething(int value)
            {
                var bar = _FuncBar.Invoke(value);
                return bar;
            }
        }

        public interface IBar
        {
            void PrintValue();
        }

        public class Bar : IBar
        {
            private readonly int _Value;
            public Bar(int value)
            {
                _Value = value;
            }

            public void PrintValue()
            {
                Console.WriteLine("Value is: {0}", _Value);
            }
        }
    }
}
