using System.Collections.Generic;
using Site.Domain.Entities;


namespace Site.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}