using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefOut.File
{
    class ValueSwapDemo
    {
        public void Swap(ref int a, ref int b)
        { // пример использования модификатора ref в методе Swap
            int t;
            t = a;
            a = b;
            b = t;
        }
    }
}
