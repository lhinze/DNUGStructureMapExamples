namespace Example10
{
    public class Foo : IFoo
    {
        private readonly IRepository<User> _UserRepository;

        public Foo(IRepository<User> userRepository)
        {
            _UserRepository = userRepository;
        }

        public string GetMessageForUser(int ID)
        {
            return string.Format("Message from {0}!", _UserRepository.Get(ID).Name);
        }
    }
}
