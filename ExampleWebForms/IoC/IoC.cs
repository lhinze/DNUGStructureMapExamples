using StructureMap;
using System;

namespace ExampleWebForms.IoC
{
    public static class IoC
    {
        private static object _Lock = new Object();

        private static IContainer _Container;

        public static IContainer GetInstance()
        {
            if (_Container == null)
            {
                lock (_Lock)
                {
                    if (_Container == null)
                    {
                        _Container = new Container();
                    }
                }
            }

            return _Container;
        }
    }
}