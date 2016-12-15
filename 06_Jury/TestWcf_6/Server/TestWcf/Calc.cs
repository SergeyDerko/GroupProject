using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWcfCommon;

namespace TestWcf
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
