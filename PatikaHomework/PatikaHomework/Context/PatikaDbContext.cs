using Microsoft.EntityFrameworkCore;
using PatikaHomework.DataModel;

namespace PatikaHomework.Context
{
    public class PatikaDbContext : DbContext
    {
        public PatikaDbContext(DbContextOptions<PatikaDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
