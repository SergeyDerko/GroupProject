using System;
using _503_EntityFramework.Model;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace _503_EntityFramework
{
    public class SampleContext : Context, IDisposable
    {
        public ISet<Customer> Customers { get; set; }
        public ISet<Order> Orders { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    
}