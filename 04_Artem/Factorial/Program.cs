using System;       

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            var n = Convert.ToInt32(Console.ReadLine());
            var F = 1;
            for (int i = 1; i <= n; i++)
            {
                F = F * i;
            }
            Console.Write("The factorial of the number " +n);
            Console.Write(" equals " + F);
            Console.ReadKey();
        }
    }
}
