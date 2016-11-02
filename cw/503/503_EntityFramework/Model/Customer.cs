using System;
using System.ComponentModel.DataAnnotations;

namespace _503_EntityFramework.Model
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
    }
}