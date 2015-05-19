
namespace ExampleWebForms.Services
{
    public class SiteHeaderService : ISiteHeaderService
    {
        public string GetSiteHeader()
        {
            return "ASP.NET DNUG from service.";
        }
    }
}