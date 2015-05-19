using ExampleWebForms.Services;
using StructureMap;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace ExampleWebForms
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var container = new Container(
                x =>
                {
                    x.For<ISiteHeaderService>().Use<SiteHeaderService>();
                    x.Policies.SetAllProperties(p => p.OfType<ISiteHeaderService>());
                });

            IoC.IoC.Initialize(container);

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}