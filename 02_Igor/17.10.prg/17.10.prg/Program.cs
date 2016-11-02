using System;

namespace _17._10.prg
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Потрібно визначити к-сть плиток на стіні");
            Console.WriteLine("Введіть висоту стіни");
            var a = 50; //int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть ширину стіни");
            var b = 100; //int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть висоту плитки");
            var a1 = 5; //int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть ширину плитки");
            var b1 = 5; //int.Parse(Console.ReadLine());
            //знаходимо площу стіни
            var s = a*b;
            var s1 = a1*b1;
            var num = s/s1;

            Console.WriteLine("num" + num);
            Console.ReadLine();
        }
    }
}