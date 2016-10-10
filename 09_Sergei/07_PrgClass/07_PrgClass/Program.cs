
using System;
using _07_PrgClass.Model;

namespace _07_PrgClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Name = "John";
            myClass.SName = "Smith";
            myClass.Age = 30;
            Console.WriteLine(myClass.Show());
            Console.ReadKey();

        }
    }
}
