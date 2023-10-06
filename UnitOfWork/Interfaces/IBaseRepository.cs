using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        // GetAll
        public Task <IEnumerable<T>> GetAllAsync();
        // GetById
        public  Task<T> GetByIdAsync(int id);
        // Add
        public Task<T> AddAsync(T entity);
        // Update
        public T Update(T entity);
        // Delete
        public void Delete(T entity);

    }
}
