using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PartsWithOut.Store;

namespace PartsWithOut
{
    class Program
    { // Пример применения модификатора параметра out
        static void Main(string[] args)
        { // Приложение разделяет значение с плавающей точкой на 
          // целую (int) и дробную (double) часть
            Decompose ab = new Decompose();
            int i;
            double f;

            i = ab.GetParts(10.125, out f); // значение с плавающей точкой: 10.125
            
            Console.WriteLine("Целая часть числа равна: {0}", i);
            Console.WriteLine("Дробная часть числа равна: {0}", f);

            Console.ReadLine();
        }
    }
}
