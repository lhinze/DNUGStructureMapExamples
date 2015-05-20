using System.Web.Http.Dispatcher;
using ExampleWebAPI.IoC;
using ExampleWebAPI.Services;
using StructureMap;
using System.Web.Http;

namespace ExampleWebAPI
{
	public partial class Startup
	{
        private static IContainer RegisterServices()
        {
            var container = new Container();

			container.Configure(x => x.For<IMessageService>().Use<MessageService>());

            return container;
        }

	    public static void ConfigureContainer(HttpConfiguration config)
	    {
	        var container = RegisterServices();
            config.Services.Replace(typeof(IHttpControllerActivator), new StructureMapServiceActivator(container));
	    }
	}
}