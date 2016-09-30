using System;

namespace _01_parityNumber
{
    internal class Program
    {
        public static void Main()
        {
            var finish = false;
            while (!finish)
                try
                {
                    Console.WriteLine("Введите число для проверки: ");
                    var number = Console.ReadLine();
                    if (!string.IsNullOrEmpty(number) && IsNum(number))
                    {
                        var result = int.Parse(number) % 2 == 0 ? "Четное!" : "Не четное!";
                        Console.WriteLine("Число "+number+'-'+result);
                        finish = true;
                    }
                    else
                    {
                        Console.WriteLine("Нужно вводить только цифры! Попробуйте еще раз!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            Console.ReadKey();
        }

        public static bool IsNum(string number)
        {
            var anyString = number.ToCharArray();
            for (var i = 0; i <= anyString.Length - 1; i++)
            {
                if (char.IsDigit(anyString[i]))
                {
                    continue;
                }
                return anyString[i] == anyString.Length - 1;
            }
            return true;
        }
    }
}

