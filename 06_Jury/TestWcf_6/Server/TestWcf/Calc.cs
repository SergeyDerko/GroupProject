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

        public int Sub(int a, int b)
        {
            var sub = a - b;
            Console.WriteLine($"Method Sub was used --> {a} - {b} = {sub}");
            Logger.Write(Level.Info, $"Method Sub was used --> {a} - {b} = {sub}");
            return sub;
        }

        public int Mul(int a, int b)
        {
            var mul = a * b;
            Console.WriteLine($"Method Mul was used --> {a} * {b} = {mul}");
            Logger.Write(Level.Info, $"Method Mul was used --> {a} + {b} = {mul}");
            return mul;
        }

        public int Div(int a, int b)
        {
            var div = a / b;
            Console.WriteLine($"Method Div was used --> {a} / {b} = {div}");
            Logger.Write(Level.Info, $"Method Div was used --> {a} / {b} = {div}");
            return div;
        }
    }
}
