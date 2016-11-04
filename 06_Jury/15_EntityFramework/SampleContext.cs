using System.Data.Entity;
using _503_EntityFramework.Model;

namespace _503_EntityFramework
{
    public class SampleContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        
    }
    
}