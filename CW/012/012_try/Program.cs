using System;

namespace _012_try
{
    public class Program
    {
        static void Main()
        {
            UncheckedPrg();
            var user = new User
            {
                Name = "John",
                SName = "Smit",
                Age = 25
            };

        }

        private static void UncheckedPrg()
        {
            while (true)
            {
                Console.WriteLine("Программа 11 занятия");
                try
                {
                    Console.Write("Введите a: ");
                    // Используем unchecked в одном выражении
                    var a = unchecked((byte) int.Parse(Console.ReadLine()));
                    Console.Write("Введите b: ");
                    var b = unchecked((byte) int.Parse(Console.ReadLine()));

                    // Используем checked для всего блока операторов
                    unchecked
                    {
                        var result = (byte) (a + b);
                        Console.WriteLine("a + b = " + result);
                        result = (byte) (a*b);
                        Console.WriteLine("a*b = " + result + "\n");
                    }

                    // Используем checked для всего блока операторов
                    checked
                    {
                        var result = (byte) (a + b);
                        Console.WriteLine("a + b = " + result);
                        result = (byte) (a*b);
                        Console.WriteLine("a*b = " + result + "\n");
                    }
                }
                catch (OverflowException)
                {
                    Console.Write("Переполнение\n\n");
                }
                Console.WriteLine("Для выхода нажмите Escape");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}