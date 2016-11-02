using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number;
            var value = Console.ReadLine();
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                int truueer = number;
                for (int i = 1; i < truueer; i++)
                {

                    number = number * i;
                }
            }
            else
            {
                Console.WriteLine("failed");
            }
            Console.WriteLine("Factorial {0} is {1}", value, number);
            Console.ReadLine();
        }
    }
}
