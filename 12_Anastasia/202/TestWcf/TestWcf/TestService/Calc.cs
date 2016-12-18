using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    internal class Calc : TestWcfCommon.ICalc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
