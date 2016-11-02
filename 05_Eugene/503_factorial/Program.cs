using System;

namespace _503_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ФАКТОРИАЛ");
            Console.Write("введите число:");
            int x=Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <=x; i++)
            {
                a *= i;
            }
            Console.WriteLine("Результат:"+a);
            Console.ReadKey();
        }
    }
}
