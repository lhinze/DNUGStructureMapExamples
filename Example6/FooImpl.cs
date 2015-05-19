namespace Example6
{
    public class FooImpl : Foo
    {
        private readonly Bar _Bar;

        public FooImpl(Bar bar)
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
