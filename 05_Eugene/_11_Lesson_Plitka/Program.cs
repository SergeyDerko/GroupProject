using System;

namespace _11_Lesson_Plitka
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ПЛИТКА");
            Console.Write("Введите высоту стены в см:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину стены в см:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту плитки в см:");
            double hp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину плитки в см:");
            double lp = Convert.ToDouble(Console.ReadLine());
            double result = (h * l) / (hp * lp);
            Console.WriteLine("Нужно"+" "+result+" "+"плиток");
            Console.ReadLine();
        }
    }
  }  
   