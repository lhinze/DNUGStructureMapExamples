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
            var nestedContainer = _Container.GetNestedContainer();
            request.RegisterForDispose(nestedContainer);
            return nestedContainer.GetInstance(controllerType) as IHttpController;
        }
    }
}