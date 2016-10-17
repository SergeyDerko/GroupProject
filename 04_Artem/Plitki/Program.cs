using System;

namespace Plitki
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ширину доски:");
            var L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту доски:");
            var H = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину одной плиточки:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту одной плиточки:");
            var b = Convert.ToInt32(Console.ReadLine());

            var s = L*H;
            var s1 = a*b;
            var res = s/s1;

            Console.Write ("На доске шириной " + L);
            Console.Write (" и высотой " + H);
            Console.Write(" можно разместить " + res);
            Console.Write(" плиток размерами " + a);
            Console.Write(" на " + b);
            Console.ReadKey();
        }
    }
}
