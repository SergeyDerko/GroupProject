using System;
using Common;

namespace TestWcfNew
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            /*
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
            */

            var sum = a + b;
            Console.WriteLine($"Method Sum was used --> {a} + {b} = {sum}");
            Logger.Write(Level.Info, $"Method Sum was used --> {a} + {b} = {sum}");
            return sum;
        }
        public int Substraction(int a, int b)
        {

            var sub = a - b;
            Console.WriteLine($"Method Sum was used --> {a} - {b} = {sub}");
            Logger.Write(Level.Info, $"Method Sum was used --> {a} - {b} = {sub}");
            return sub;
        }
        public int Multiplication(int a, int b)
        {

            var mul = a * b;
            Console.WriteLine($"Method Sum was used --> {a} * {b} = {mul}");
            Logger.Write(Level.Info, $"Method Sum was used --> {a} * {b} = {mul}");
            return mul;
        }
        public int Division(int a, int b)
        {

            var div = a / b;
            Console.WriteLine($"Method Sum was used --> {a} / {b} = {div}");
            Logger.Write(Level.Info, $"Method Sum was used --> {a} / {b} = {div}");
            return div;
        }
    }
}
