using ExampleWebForms.Services;
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
            var container = IoC.IoC.GetInstance();
            
            container.Configure(
                x =>
                {
                    x.For<ISiteHeaderService>().Use<SiteHeaderService>();
                    x.Policies.SetAllProperties(p => p.OfType<ISiteHeaderService>());
                });
            

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}