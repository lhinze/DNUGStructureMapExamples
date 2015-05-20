using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(ExampleWebAPI.Startup))]

namespace ExampleWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            ConfigureContainer(config);
            ConfigureWebApi(config);

            app.UseWebApi(config);
        }
    }
}
