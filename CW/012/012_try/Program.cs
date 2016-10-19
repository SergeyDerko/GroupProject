using System;
using System.IO;
using System.Text;

namespace _012_try
{
    public class Program
    {
        static void Main()
        {
            GroupPrg();
            UncheckedPrg();
            StructPrg();
            // Создадим делегат
            DelegatePrg();
        }

        private static void GroupPrg()
        {
            var text = File.ReadAllText(@"in.txt");
            var symbol = new StringBuilder();
            var number = new StringBuilder();
            var letter = new StringBuilder();
            foreach (var s in text)
            {
                if (char.IsSymbol(s))
                {
                    symbol.Append(s);
                }
                else if (char.IsNumber(s))
                {
                    number.Append(s);
                }
                else if (char.IsLetter(s))
                {
                    letter.Append(s);
                }
            }
            File.WriteAllText(@"out.txt", symbol.ToString() + number + letter);
        }

        private static void DelegatePrg()
        {
            var calc = new Calc(Operation.Sum);
            var calculation = calc.Calculation(2, 3);
        }

        private int Test(int a, int b)
        {
            return a + b;
        }

        private static void StructPrg()
        {
            UserInfo user1 = new UserInfo("Alexandr", 26);
            Console.Write("user1: ");
            user1.WriteUserInfo();
            UserInfo user2 = new UserInfo("Elena", 22);
            Console.Write("user2: ");
            user2.WriteUserInfo();

            // Показать главное отличие структур от классов
            user1 = user2;
            user2.Name = "Natalya";
            user2.Age = 25;
            Console.Write("\nuser1: ");
            user1.WriteUserInfo();
            Console.Write("user2: ");
            user2.WriteUserInfo();

            Console.ReadLine();
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