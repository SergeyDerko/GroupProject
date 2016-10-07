using System;
using _09_NewClass.Helper;
using _09_NewClass.Model;

namespace _09_NewClass
{
    class Program
    {
        static void Main()
        {
            var myClass = new MyClass();
            myClass.Name = "Vasya";
            myClass.SName = "Pupkin";
            myClass.Age = "13";

            Console.WriteLine(BaseClass.Show());
            Console.ReadLine();
        }
    }
}
