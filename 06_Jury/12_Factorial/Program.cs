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
                uint verify;
                Console.WriteLine(uint.TryParse(number, out verify)
                        ? $" Результат: {number}! = {Factorial(verify)}"//было лишние действие verify уже содержит значение
                        : " Введите положительное число");

                Console.WriteLine(" Нажмите Escape для выхода или любую клавишу для продолжения...");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);


        }


        private static uint Factorial(uint x)//Factorial_x что за именование метода?
        {
            if (x < 1) return 1;
            var result = Factorial(x - 1)*x;
            return result;
        }
    }
}
