using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWcfSite.Models.AnastasiaNepomiluyev
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public User()
        {
        }

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}