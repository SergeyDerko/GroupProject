using System;

namespace _501_Faktorial
{
    class Program
    {
        static long Fact(uint x)//рекурсия
        {
                if (x< 1)
                    return 1;
                return x * Fact(x - 1);
            }
        
        static void Main()
        {
            Console.WriteLine("                  Программа 'факториал числа'");
            Console.WriteLine("            =====================================");
            Console.WriteLine(" ");
            Console.Write("Введите число x=");
            string x = (Console.ReadLine());
            var f = Fact(Convert.ToUInt32(x));
            Console.WriteLine("{0}!={1}", x, f);
            Console.ReadLine();
        }
    }
}