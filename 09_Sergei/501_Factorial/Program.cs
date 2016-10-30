using System;
using System.Text;

namespace _501_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пока что считает только до факториала числа 20.";
            Console.CursorVisible = false;
            Console.Write("For get factorial enter a numeric value, please: \n");
            var value = Console.ReadLine();
            Console.WriteLine("Factorial of a number " + value + " is " + GetFactorial(value));
            ulong f = 1;
            for(ulong i = 1; i<=20;i++)
            {
                f *= i;
                Console.WriteLine(i+": "+f);
            }
             
        }
        internal static string GetFactorial(string value)
        {
            var r = "1";
            ulong factorial = 1;
            for (ulong i = 1; i <= ulong.Parse(value); i++)
            {
               r = (factorial * i).ToString();
               factorial = ulong.Parse(r);
            }
            return r.ToString();
        }
    }
}
