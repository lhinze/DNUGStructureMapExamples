using System.Collections.Generic;
using System.Linq;

namespace Example11
{
    public class Repository<T> : IRepository<T> where T : IDomain, new()
    {
        private readonly IList<T> _InMemoryRepository;

        public Repository()
        {
            _InMemoryRepository = new List<T>();
        }

        public T Get(int ID)
        {
            return _InMemoryRepository.FirstOrDefault(x => x.ID == ID);
        }

        public void Add(T entity)
        {
            _InMemoryRepository.Add(entity);
        }
    }
}
