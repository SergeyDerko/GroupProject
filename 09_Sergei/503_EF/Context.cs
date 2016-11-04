using _503_EF.model;
using System.Data.Entity;

namespace _503_EF
{
    class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
