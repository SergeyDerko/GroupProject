using _503_EntityFramework.Model;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace _503_EntityFramework
{
    public class SampleContext : Context
    {
        public ISet<Customer> Customers { get; set; }
        public ISet<Order> Orders { get; set; }
        
    }
    
}