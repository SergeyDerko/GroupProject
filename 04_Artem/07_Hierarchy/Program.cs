using System;
using _07_Hierarchy.Model;

namespace _07_Hierarchy
{
    class Program
    {
        static void Main()
        {
            var user = new Class();
 
             user.Name = "Basil";
             user.Surname = "Pupkin";
             user.Age = 20;
             Console.WriteLine(user.Show());
             Console.ReadKey();
            

        }
    }
}


 