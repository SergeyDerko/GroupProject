using System;
using Common;
using TestWcfCommon;

namespace TestWcf
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine($"Method Sum was used --> {a} + {b} = {sum}");
            Logger.Write(Level.Info, $"Method Sum was used --> {a} + {b} = {sum}");
            return sum;
        }
    }
}
