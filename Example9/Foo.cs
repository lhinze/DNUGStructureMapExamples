namespace Example9
{
    public class Foo : IFoo
    {
        private readonly IBar _Bar;

        public Foo(IBar bar)
        {
            _Bar = bar;
        }

        public string Message
        {
            get
            {
                return string.Format("Message from {0}!", _Bar.User);
            }
        }
    }
}
