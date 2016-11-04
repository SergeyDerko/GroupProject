using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _503_Factorial2
{
    class Program
    {
        //Рекурсивний метод
        static int factorial(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = factorial(i - 1) * i;
            return result;
        }


        static void Main(string[] args)
        {
            label1:
            Console.WriteLine("Введіть число: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}! = {1}", i , factorial(i));
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректне число");
                goto label1;
            }

            Console.ReadLine();
        }
    }
}

