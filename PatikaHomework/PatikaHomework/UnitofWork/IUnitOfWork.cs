using PatikaHomework.DataModel;
using PatikaHomework.Repository;
using System.Threading.Tasks;

namespace PatikaHomework.UnitofWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Customer> CustomerRepository { get; }
        void Save();
        Task SaveAsync();
    }
}
