using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квадрат_4х4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Виводимо назву програми
            Console.WriteLine("Елемент шахматної дошки 2х2");
            //просимо ввести користувача ширину та висоту
            Console.WriteLine("Введiть ширину");
            var x = 4; //int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть довжину");
            var y = 4; //int.Parse(Console.ReadLine());
            var str = "*";
            
            for (var i = 0; i < x; i++)
                Console.Write(str);
            Console.WriteLine();

            }
    }
}
