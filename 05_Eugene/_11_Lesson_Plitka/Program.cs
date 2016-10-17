using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Lesson_Plitka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ПЛИТКА");
            Console.WriteLine("Введите высоту стены в см");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину стены в см");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту плитки в см");
            double plh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину плитки в см");
            double pll = Convert.ToDouble(Console.ReadLine());
            double sqwall = h*l;
            double sqpl = plh*pll;
            double result = sqwall/sqpl;
            Console.WriteLine(result);
            Console.ReadLine();






        }
    }
}
