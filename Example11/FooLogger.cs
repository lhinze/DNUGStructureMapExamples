using System;

namespace Example11
{
    public class FooLogger : IFoo
    {
        private readonly IFoo _Target;

        public FooLogger(IFoo target)
        {
            _Target = target;
        }

        public string GetMessageForUser(int ID)
        {
            Console.WriteLine("Log: Fetching message for user {0}", ID);
            var result = _Target.GetMessageForUser(ID);
            Console.WriteLine("Log: Done fetching message for user {0}", ID);

            return result;
        }
    }
}
