using StructureMap;
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

namespace ExampleWebAPI.IoC
{
    public class StructureMapServiceActivator : IHttpControllerActivator
    {
        private readonly IContainer _Container;

        public StructureMapServiceActivator(IContainer container)
        {
            _Container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            return _Container.GetInstance(controllerType) as IHttpController;
        }
    }
}