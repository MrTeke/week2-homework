using PatikaHomework.Context;
using PatikaHomework.DataModel;
using PatikaHomework.Repository;
using System.Threading.Tasks;

namespace PatikaHomework.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepository<Customer> CustomerRepository{ get; }
        private readonly PatikaDbContext _context;

        public UnitOfWork(IGenericRepository<Customer> customerRepository, PatikaDbContext context)
        {
            CustomerRepository = customerRepository;
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
