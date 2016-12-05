using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SameNameMeth.Clone
{
    // В классе продемонстрировать перегрузку методов
    class SameOfSame
    {
        public void OvlDemo ()
        {
            Console.WriteLine("Метод вообще без параметров, ВООБЩЕ 0_0");
        }
        // Метод с одним параметром (перегрузка метода)
        public void OvlDemo (int a)
        {
            Console.WriteLine("Метод принимает принимает АЖ один параметр {0}!!!", a);
        }
        // Метод с двумя целочисленными параметрами.
        public int OvlDemo (int a, int b)
        {
            Console.WriteLine("О боги целых два параметра: {0} и {1}", a, b);
            return a + b; // код Огонь!!!
        }
        // Метод тоже с двумя параметрами но другого типа 0_о
        public double OvlDemo (double a, double b)
        {
            Console.WriteLine("Два параметра типа double: {0} и {1}", a, b);
            return a * b; // повторение мать учения 
        }
    }
}
