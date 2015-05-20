
namespace ExampleWebAPI.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Message from service!";
        }
    }
}