
namespace Example8
{
    public class UserRepository : IRepository<User>
    {
        public User Get(int ID)
        {
            return new User { ID = ID, Name = "Repository User"};
        }
    }
}
