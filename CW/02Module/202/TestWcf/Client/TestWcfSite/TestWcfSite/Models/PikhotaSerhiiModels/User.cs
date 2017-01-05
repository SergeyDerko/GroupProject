using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    public class User
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User()
        {
            
        }

        public User(string surname, string name, int age)
        {
            Surname = surname;
            Name = name;
            Age = age;
        }
    }
}