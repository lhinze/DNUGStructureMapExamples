using ExampleMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactMessageService _ContactMessageService;

        public HomeController(IContactMessageService contactMessageService)
        {
            _ContactMessageService = contactMessageService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = _ContactMessageService.GetMessage();

            return View();
        }
    }
}