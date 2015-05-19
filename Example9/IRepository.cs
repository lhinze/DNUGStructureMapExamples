namespace Example9
{
    public interface IRepository<T> where T : IDomain
    {
        T Get(int ID);
    }
}
