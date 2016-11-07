using System;
using System.ComponentModel.DataAnnotations;

namespace _503_EF.model
{
    internal class Customer
    {
        [Key]
        public int IDCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
