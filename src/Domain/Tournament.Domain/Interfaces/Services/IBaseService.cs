using System;
using System.Collections.Generic;

namespace Tournament.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        void Add(T obj);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}