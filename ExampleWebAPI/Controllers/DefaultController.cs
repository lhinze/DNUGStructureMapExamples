using System.Dynamic;
using System.Web.Http;
using ExampleWebAPI.Services;

namespace ExampleWebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        private readonly IMessageService _MessageService;

        public DefaultController(IMessageService messageService)
        {
            _MessageService = messageService;
        }

        public IHttpActionResult Get()
        {
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.Message = _MessageService.GetMessage();
            return Ok(dynamicObject);
        }
    }
}
