using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWcf4Common;

namespace TestWcf4Lib
{
    public class Calc : ICalc
    {
       public int Sum(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
            return sum;
        }

        public int Sub(int a, int b)
        {
            var sub = a - b;
            Console.WriteLine($"{a} - {b} = {sub}");
            return sub;
        }

        public int Mul(int a, int b)
        {
            var mul = a * b;
            Console.WriteLine($"{a} * {b} = {mul}");
            return mul;
        }
        public int Div(int a, int b)
        {
            var div = a / b;
            Console.WriteLine($"{a} / {b} = {div}");
            return div;
        }
    }
}
