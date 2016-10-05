using System;
namespace _02_Sschoolchild
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вас приветствует пограмма 'Школьник 3000'V2.0");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White ;
            Console.WriteLine("Данная програма может определить:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("- Чётные числа");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("- Нечётные числа");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- Гласные буквы");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("- Согласные буквы");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("- Знаки");
            Console.WriteLine(" ");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Введите значение:");
                var anyNumber = Console.ReadLine();
                if (!string.IsNullOrEmpty(anyNumber) && char.IsDigit(char.Parse(anyNumber)))
                {
                    var result = int.Parse(s: anyNumber)%2 > 0 ? "Число нечётное" : "Число  чётное";
                    Console.WriteLine(result);
                }
               if (anyNumber == "а")
                {
                   Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "у")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "о")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "ы")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "э")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "я")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "ю")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "ё")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "и")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "е")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Буква ГЛАСНАЯ");
                }
                if (anyNumber == "б")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "в")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "г")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "д")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "ж")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "з")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "к")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "л")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "м")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "н")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "п")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "р")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "с")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "т")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "ф")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "х")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "ц")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "ч")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "ш")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "щ")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "й")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Буква СОГЛАСНАЯ");
                }
                if (anyNumber == "ь")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("ЗНАК");
                }
                if (anyNumber == "ъ")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("ЗНАК");
                }

                //   Console.ReadKey();
            }
            // ReSharper disable once FunctionNeverReturns
            }
  
    }
}
