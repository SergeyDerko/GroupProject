using System;
using CommonLogger;
using TestWCFCommon;

namespace TestWCFLib
{
    public class Calc : ICalc
    {
        public int Sum(int a, int b)
        {
            const string method = "Sum";
            Logger.Enter(method);
            var sum = a + b;
            var value = $"{sum}={a}+{b}";
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
        }

        public int Sub(int a, int b)
        {
            var sub = a - b;
            Console.WriteLine($"{a} - {b} = {sub}");
            return sub;
        }

        public int Mult(int a, int b)
        {
            var mult = a * b;
            Console.WriteLine($"{a} * {b} = {mult}");
            return mult;
        }

        public double Div(int a, int b)
        {
            var div = a / b;
            if(b == 0)
                Console.WriteLine("Деление на ноль!");
            Console.WriteLine($"{a} / {b} = {div}");
            return div;
        }
    }
}
