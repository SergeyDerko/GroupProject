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
            Console.Write("Введите высоту стены в см:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину стены в см:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту плитки в см:");
            double plh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину плитки в см:");
            double pll = Convert.ToDouble(Console.ReadLine());
            double result = (h * l) / (plh * pll);
            Console.WriteLine(result);
            Console.ReadLine();
            

        }
    }
}
