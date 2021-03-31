using System;
using System.Collections.Generic;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Domain.Interfaces.Services;

namespace Tournament.Domain.Services
{
    public class ServiceBase<T> : IDisposable, IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public ServiceBase(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual void Add(T obj)
        {
            _repository.Add(obj);
        }

        public virtual T GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual void Update(T obj)
        {
            _repository.Update(obj);
        }

        public virtual void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }
    }
}