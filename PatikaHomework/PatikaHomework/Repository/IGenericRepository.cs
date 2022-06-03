using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PatikaHomework.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Update(T entity);
        Task InsertAsync(T entity);
        void Delete(T entity);
        T GetById(int Id);
        IEnumerable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
    }
}
