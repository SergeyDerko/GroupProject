using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SameNameMeth.Clone;

namespace SameNameMeth
{
    class Program
    {
        // Пример приложения, где в одном классе несколько методом с одинаковыми именами (перегружаемые методы)
        // где компилятор выбрает соответсвующий метод по типу и количеству параметров передаваемым аргументам 
        static void Main(string[] args)
        {
            SameOfSame obj = new SameOfSame();
            int resI;
            double resD;
            // Все варианты...
            resD = obj.OvlDemo(1.1, 2.33);
            Console.WriteLine("Результат візова метода obj.OvlDemo(1.1, 2.33): {0}", resD);

            obj.OvlDemo();
            Console.WriteLine();

            obj.OvlDemo(2);
            Console.WriteLine();

            resI = obj.OvlDemo(4, 6);
            Console.WriteLine("Результат вызова метода obj.OvlDemo(4, 6): {0}", resI);
            Console.ReadLine();
        }
    }
}
