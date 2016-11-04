using System.Data.Entity;
using EntityFramework.Model;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace EntityFramework
{
    public class SampleContext : Context
    {
        public DbSet<Customer> Customers { get; set; }

        public ISet<Order> Orders { get; set; }
    }
}