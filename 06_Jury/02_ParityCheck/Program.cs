using System;

namespace _02_ParityCheck
{
	class Program
	{
		static void Main()
		{
			Console.Write("Введите число: ");
            var anyNumber = Console.ReadLine();
            int verify;
            if (!string.IsNullOrEmpty(anyNumber)&& int.TryParse(anyNumber, out verify))
		    {
                var result = int.Parse(anyNumber) % 2 == 0 ? "Число чётное" : "Число нечётное";
                Console.WriteLine($"\n{result}");
            } else
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы не ввели число или ввели буквы!\nPress any key to exit...");
            }
			Console.ReadKey();
		}
	}
}
