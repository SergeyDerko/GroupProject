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

            //const string method = "Sum";
            //Logger.Enter(method);
            //var sum = a + b;
            //var value = $"{a} + {b} = {sum}";
            //Logger.Info(method, value);
            //Console.WriteLine(value);
            //return Logger.Leave(method, sum);

        }
    }
}