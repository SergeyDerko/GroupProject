using System;
using ParamsMethod.Add;

namespace ParamsMethod
{
    class Program
    {
        // Пример использования переменного числа аргументов в методе
        // приложение в котором метод MinVal возращает наименьшее значение среди -
        // - всего ряда аргументов  
        static void Main(string[] args)
        {
            Min obj = new Min();
            int min;
            int a = 10, b = 20;

            // Вызов метод с двумя значениями.
            min = obj.MinVal(a, b);
            Console.WriteLine("Найменьшее значение равно {0}", min);

            // Вызвать метод с тремя значениями.
            min = obj.MinVal(a, b, -1);
            Console.WriteLine("Найменьшее значение равно {0}", min);

            // Вызвать метод с пятью значениями.
            min = obj.MinVal(18, 23, 3, 14, 25);
            Console.WriteLine("Найменьшее значение равно {0}", min);

            // Вызвать метод с массивом целых значений.
            int[] argS = { 45, 67, 34, 9, 112, 8 };
            min = obj.MinVal(argS);
            Console.WriteLine("Найменьшее значение равно {0}", min);

            Console.ReadLine();
        }
    }
}
