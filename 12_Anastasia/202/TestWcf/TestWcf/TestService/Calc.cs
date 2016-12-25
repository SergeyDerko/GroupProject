using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    internal class Calc : Common.ICalc
    {
        public int Division(int a, int b)
        {
            if (b == 0)
                return -Int32.MaxValue;
            else
            {
                Console.WriteLine($"{a} / {b} = {a/b}");
                return a/b;
            }
        }

        public int Multiplication(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a*b}");
            return a*b;
        }

        public int Substraction(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a-b}");
            return a - b;
        }

        public int Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
            return a + b;
        }
    }
}
