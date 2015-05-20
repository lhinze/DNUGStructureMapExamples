﻿namespace Example11
{
    public interface IRepository<T> where T : IDomain
    {
        T Get(int ID);

        void Add(T entity);
    }
}
