using System.Web.Http;

namespace ExampleWebAPI
{
    public partial class Startup
    {
        public static void ConfigureWebApi(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller = "Default", id = RouteParameter.Optional }
            );
        }
    }
}
