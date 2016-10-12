using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Model;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass {Name = "Dan"};
            myClass.Age = "12";
            myClass.SName = "Ako";
            Console.WriteLine(myClass.Show());
            Console.WriteLine();
            myClass.Age = "45";
            myClass.SName = "Ky";
            myClass.Name = "Fedor";     
            myClass.Show();
            Console.WriteLine(myClass.Show());
            Console.ReadLine();
        }
        }
} 

