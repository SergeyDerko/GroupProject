using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartsWithOut.Store
{
    class Decompose
    {
        // Разделить числовое значение с плавающей точкой на целую и дробную части.
        public int GetParts (double n, out double frac)
        {
            int whole;
            whole = (int)n;
            frac = n - whole; // передать дробную часть числа через параметр frac
            return whole;     // возвратить целую часть числа
        }
    }
}
