using StructureMap;
using System;

namespace ExampleWebForms.IoC
{
    public static class IoC
    {
        private static object _Lock = new Object();

        private static IContainer _Container;

        public static void Initialize(IContainer container)
        {
            if (_Container == null)
            {
                lock (_Lock)
                {
                    if (_Container == null)
                    {
                        _Container = container;
                    }
                }
            }
        }

        public static T GetInstance<T>()
        {
            if (_Container == null) throw new ArgumentException("Must call Initialize before fetching an instance.");
            return _Container.GetInstance<T>();
        }

        public static T GetInstance<T>(string name)
        {
            if (_Container == null) throw new ArgumentException("Must call Initialize before fetching an instance.");
            return _Container.GetInstance<T>(name);
        }

        public static object GetInstance(Type type)
        {
            if (_Container == null) throw new ArgumentException("Must call Initialize before fetching an instance.");
            return _Container.GetInstance(type);
        }

        public static object GetInstance(Type type, string name)
        {
            if (_Container == null) throw new ArgumentException("Must call Initialize before fetching an instance.");
            return _Container.GetInstance(type, name);
        }

        public static void BuildUp(object target)
        {
            if (_Container == null) throw new ArgumentException("Must call Initialize before building up an object.");
            _Container.BuildUp(target);
        }
    }
}