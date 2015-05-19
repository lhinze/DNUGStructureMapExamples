using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    public class Repository<T> : IRepository<T> where T : IDomain, new()
    {
        public T Get(int ID)
        {
            return new T { ID = ID, Name = "Generic Repository" };
        }
    }
}
