using PatikaHomework.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PatikaHomework.Services
{
    public interface ICustomerService
    {
        void Update(CustomerDto customerDto);
        Task<CustomerDto> InsertAsync(CustomerDto customerDto);
        void Delete(int id);
        CustomerDtoResponse GetById(int id);
        IEnumerable<CustomerDtoResponse> GetAll();
        List<CustomerDtoResponse> SearchName(string name);
    }
}
