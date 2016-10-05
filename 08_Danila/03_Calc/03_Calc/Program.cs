using System;

namespace _03_Calc
{
    class Program
    {
        static void Main()
        {

            Console.ForegroundColor = ConsoleColor.White;
            {
                Console.Write("Вас приветствует");
                var str = " 'ПРОСТОЙ КАЛЬКУЛЯТОР'";
                int strLen = str.Length;
                for (int i = 0; i < strLen; i++)
                {
                    Console.ForegroundColor = (ConsoleColor) (i%15 + 1);
                    Console.Out.Write(str[i]);
                }
                Console.Write(" V1.0");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Выберите следующую функцию и нажмите (Enter)");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("- Сложение (Введите + )");
                Console.WriteLine("");
                Console.WriteLine("- Вычитание (Введите - ) ");
                Console.WriteLine("");
                Console.WriteLine("- Умножение (Введите * ) ");
                Console.WriteLine("");
                Console.WriteLine("- Деление (Введите / )");
                Console.WriteLine("");
                Console.WriteLine("- Возведение в сетень (Введите ^ )");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Gray;
                while (true)
                {
                    Console.Write("Выберите действие : ");
                    string y = Console.ReadLine();
                    //float a, b;
                    double a, b;
                    Console.Write("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Введите первое значение и нажмите (Enter) ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    a = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Введите второе значение и нажмите (Enter) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (y == "+")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Результат сложения {0}+{1}={2}", a, b, a + b);
                    }
                    if (y == "-")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Результат вычитание {0}-{1}={2}", a, b, a - b);
                    }
                    if (y == "*")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Результат умножение {0}*{1}={2}", a, b, a*b);
                    }
                    if (y == "/")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Результат деление {0}/{1}={2}", a, b, a/b);
                    }
                    if (y == "^")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Результат деление {0}^{1}={2}", a, b, Math.Pow(a, b));
                    }
                    Console.ReadKey();
                }

            }
        }
}
}
