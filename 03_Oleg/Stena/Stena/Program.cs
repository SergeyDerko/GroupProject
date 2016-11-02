using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stena.Schitalka;

namespace Stena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи ширину стены: ");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи высота стены: ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи ширину плитки: ");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введи высоту плитки: ");
            var d = int.Parse(Console.ReadLine());
            Umka Balbes = new Umka(a, b, c, d);
            Console.WriteLine("\tШирина стены: {0}\n" + "\tВысота стены: {1}\n" + "\tШирина плитки: {2}\n" + 
                             "\tВысота плитки: {3}\n" + "\tКоличество плитки {4}\n", Balbes.ShirinaStena, Balbes.VisotaStena, Balbes.ShirinaPlitka, Balbes.VisotaPlitka, Balbes.Kolichestvo());
            Console.ReadLine();
        }
    }
}
