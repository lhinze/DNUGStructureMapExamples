namespace Example7
{
    public class Bar : IBar
    {
        private readonly string _UserName;

        public Bar(string userName)
        {
            _UserName = userName;
        }

        public string User
        {
            get
            {
                return _UserName;
            }
        }
    }
}
