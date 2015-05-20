
using System;
using System.Diagnostics;

namespace ExampleWebAPI.Services
{
    public class MessageService : IMessageService, IDisposable
    {
        public string GetMessage()
        {
            return "Message from service!";
        }

        public void Dispose()
        {
            Debug.WriteLine("Disposing of service");
        }
    }
}