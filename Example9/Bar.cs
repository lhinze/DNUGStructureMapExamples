namespace Example9
{
    public class Bar : IBar
    {
        private readonly IRepository<User> _UserRepository;

        public Bar(IRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }

        public string User
        {
            get
            {
                return _UserRepository.Get(1).Name;
            }
        }
    }
}
