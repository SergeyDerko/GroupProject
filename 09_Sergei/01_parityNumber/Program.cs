using System;

namespace _01_parityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;
            while (!finish)
                try
                {
                    Console.WriteLine("Entering number for check: ");

                    var number = Console.ReadLine();


                    if (!string.IsNullOrEmpty(number) && isNum(number))
                    {
                        var result = Int32.Parse(number) % 2 == 0 ? "is even" : "is odd";
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

        public static bool isNum(string number)
        {
            char[] anyString = number.ToCharArray();
            for (var i = 0; i <= anyString.Length - 1; i++)
            {
                if (Char.IsDigit(anyString[i]))
                {
                    continue;
                }
                else if (anyString[i] == anyString.Length - 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

