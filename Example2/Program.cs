﻿using System;
using StructureMap;

namespace Example2
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
        private readonly IBar _Bar;

        public Foo(IBar bar)
        {
            _Bar = bar;
        }

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
