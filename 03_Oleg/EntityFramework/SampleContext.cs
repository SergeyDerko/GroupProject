using System.Data.Entity;
using EntityFramework.Model;

namespace EntityFramework
{
    public class SampleContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}