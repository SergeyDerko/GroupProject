using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFTest12
{
    internal class Calc : ICalc
    {
        public int Division(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiplication(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Substraction(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
