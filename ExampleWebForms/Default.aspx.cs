using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExampleWebForms.Services;

namespace ExampleWebForms
{
    public partial class _Default : Page
    {
        public ISiteHeaderService _SiteHeaderService { get; set; }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            IoC.IoC.BuildUp(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ASPNET.InnerHtml = _SiteHeaderService.GetSiteHeader();
        }
    }
}