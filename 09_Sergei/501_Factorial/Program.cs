using System;

namespace _501_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Write("For get factorial enter a numeric value, please: \n"); 
            var value = Int64.Parse(Console.ReadLine());
            
            Console.WriteLine("Factorial of a number " + value + " is " + GetFactorial(value));
            
            
        }
        internal static Int64 GetFactorial(Int64 value)
        {
            Int64 factorial = 1;
            for (Int64 i = 1; i <= value; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
