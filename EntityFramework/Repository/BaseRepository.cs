using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;

namespace EntityFramework.Repository
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _Context;
        public BaseRepository(ApplicationDbContext context)
        {
            _Context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
           await _Context.Set<T>().AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
             _Context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _Context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _Context.Set<T>().FindAsync(id);
        }

        public  T Update(T entity)
        {
            _Context.Update(entity);
            return entity;
        }
    }
}
