using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleMVC.Services
{
    public class ContectMessageService : IContactMessageService
    {
        public string GetMessage()
        {
            return "Message from service.";
        }
    }
}