using System;

namespace _12_Factorial
{
    class Program
    {
        static void Main()
        {
            Console.Write("\n\t\tУзнай факториал числа");
            ConsoleKeyInfo key;
            do
            {
                Console.Write("\n Введите число: ");
                var number = Console.ReadLine();
                int verify;
                Console.WriteLine(int.TryParse(number, out verify)
                        ? $" Результат: {number}! = {Factorial_x(int.Parse(number))}"
                        : " Введите положительное число");

                Console.WriteLine(" Нажмите Escape для выхода или любую клавишу для продолжения...");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);


        }


        private static int Factorial_x(int x)
        {
            if (x == 1 || x == 0) return 1;
            var result = Factorial_x(x - 1)*x;
            return result;
        }
    }
}
