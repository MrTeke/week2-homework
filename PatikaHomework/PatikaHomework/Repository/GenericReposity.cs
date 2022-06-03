using Microsoft.EntityFrameworkCore;
using PatikaHomework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PatikaHomework.Repository
{
    public class GenericReposity<T> : IGenericRepository<T> where T : class
    {
        protected PatikaDbContext _context;
        public DbSet<T> DbSet;
        

        public GenericReposity(PatikaDbContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }


        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T GetById(int Id)
        {
            return DbSet.Find(Id);
        }

        public async Task InsertAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State= EntityState.Modified;
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
    }
}
