using System;
using TestWcfCommon;

namespace TestWcfLib
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