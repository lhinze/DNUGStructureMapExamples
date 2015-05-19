using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleWebForms.Startup))]
namespace ExampleWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
