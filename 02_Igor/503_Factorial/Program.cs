using System;

namespace _503_Factorial
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var n = 10; // кількість циклів у факторіалі
            var factorial = 1; // значення факторіалу
            for (var i = 2; i <= n; i++) // цикл починаем з 2 
            {
                factorial = factorial * i;
            }
                
            Console.WriteLine("Factorial iz " + n + " = " + factorial);
            Console.Read();
        }
    }
}