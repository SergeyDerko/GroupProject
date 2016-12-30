using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Domain.Abstract;
using Site.Domain.Entities;

namespace Site.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}

