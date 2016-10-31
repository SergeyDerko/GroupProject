using System;

namespace _501_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пока что считает только до факториала числа 27.";
            Console.CursorVisible = false;
            Console.Write("For get factorial enter a numeric value, please: \n");
            var value = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of a number " + value + " is " + GetFactorial(value));
            decimal f = 1;
            for(decimal i = 1; i<=27;i++)
            {
                f *= i;
                Console.WriteLine(i+": "+f);
            }
             
        }
        internal static decimal  GetFactorial(decimal value)
        {
            decimal factorial = 1;
            for (decimal i = 1; i <= value; i++)
            {
               factorial *= i;
            }
            return factorial;
        }
    }
}
