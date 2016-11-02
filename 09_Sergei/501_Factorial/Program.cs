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
            for(decimal i = 1; i<=value;i++)
            {
                f *= i;
                Console.WriteLine(i+": "+f);
            }
            //переделать не рекурсию
        }
        //рукурсия
        public static decimal  GetFactorial(decimal value)
        {
            if (value == 1) return 1;
            return GetFactorial(value - 1) * value;
        } 
    }
}
