using System;

namespace _02_parnost
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число для проверки на парность=>");
            int k =int.Parse(Console.ReadLine());
            Console.WriteLine(k%2 == 1 ? "Число непарное" : "Число парное");
            Console.ReadKey();
        }
    }
}
