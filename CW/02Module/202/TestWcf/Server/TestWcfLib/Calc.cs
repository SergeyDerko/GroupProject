using System;

namespace TestWcfLib
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public static void Main()
        {
            var calc = new Calc();
            var a = 2;
            var b = 3;

            Console.WriteLine($"{a} + {b} = {calc.Sum(2, 3)}");
            Console.ReadKey();
        }
    }
}