using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Tournament.Domain.Interfaces.Repositories;
using Tournament.Infrasctructure.Data;

namespace Tournament.Infrastructure.Repository.Repositories
{
    public abstract class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private readonly TournamentContext _context;
        public BaseRepository(TournamentContext context)
        {
            _context = context;
        }
        
        public virtual void Add(T obj)
        {
            try
            {
                _context.Set<T>().Add(obj);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Remove(T obj)
        {
            try
            {
                _context.Set<T>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }
        
    }
}