using System;
using System.ComponentModel.DataAnnotations;

namespace _503_EF.model
{
    class Order
    {
        [Key]
        public int IDOrder { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
