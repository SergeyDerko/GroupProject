using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Model
{
    public class Customer
    {
        // Определить поля, которые используются в базе данных
        [Key]
        public int IdCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        //public virtual List<Order> Orders { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }

        // Ссылка на покупателя
        //public Customer Customer { get; set; }
    }
}