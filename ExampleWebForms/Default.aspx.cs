using ExampleWebForms.Services;
using System;
using System.Web.UI;

namespace ExampleWebForms
{
    public partial class _Default : Page
    {
        public ISiteHeaderService _SiteHeaderService { get; set; }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            IoC.IoC.GetInstance().BuildUp(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ASPNET.InnerHtml = _SiteHeaderService.GetSiteHeader();
        }
    }
}