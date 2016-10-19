using System;

namespace _11_Plitka
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа Плиточник");
            Console.WriteLine("-------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Задайте высоту cтены в (мм):");
            int H;
            H = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Задайте ширину cтены в (мм):");
            int L;
            L = Convert.ToInt32(Console.ReadLine());
            int S = H*L;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Задайте ширину плитки в (мм):");
            int l;
            l = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Задайте высоту плитки в (мм):");
            int h;
            h = Convert.ToInt32(Console.ReadLine());
            int s = h*l;
            int n = S/s;
            Console.WriteLine("==========================");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Необходимое кол-во плитки:"+n);
          Console.Write("Стоймость одной плитки в (грн) тько целое число :");
            int c = Convert.ToInt32(Console.ReadLine());
            int cash = n*c;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Вам понадобится:"+cash+"грн");
            Console.ReadKey();
        }
        
    }

}
