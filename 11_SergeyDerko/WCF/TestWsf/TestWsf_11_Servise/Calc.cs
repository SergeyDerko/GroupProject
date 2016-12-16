using System;
using TestWsf_11_Common;

namespace TestWsf_11_Servise
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
        }
    }
}