using System;

namespace _01_parityNumber
{
    internal class Program
    {
        public static void Main()
        {
            bool finish = false;
            while (!finish)
                try
                {
                    Console.WriteLine("Entering number for check: ");
                    var number = Console.ReadLine();
                    if (!string.IsNullOrEmpty(number) && IsNum(number))
                    {
                        var result = int.Parse(number) % 2 == 0 ? "is even" : "is odd";
                        Console.WriteLine(result);
                        finish = true;
                    }
                    else
                    {
                        Console.WriteLine("Entering only number! Try again.");
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

