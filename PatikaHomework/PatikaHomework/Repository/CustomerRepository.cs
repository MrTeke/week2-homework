using PatikaHomework.Context;
using PatikaHomework.DataModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PatikaHomework.Repository
{
    public class CustomerRepository : GenericReposity<Customer>, ICustomerRepository
    {

        public CustomerRepository(PatikaDbContext context) : base(context)
        {

        }

    }  
}
