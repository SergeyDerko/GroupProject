using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_parnost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки на парность=>");
            int k =int.Parse(Console.ReadLine());
            if (k%2 == 1)
            {
                Console.WriteLine("Число непарное");
            }
            else
            {
                Console.WriteLine("Число парное");
            }
            Console.ReadKey();
        }
    }
}
