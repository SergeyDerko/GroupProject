using System;

namespace prog_2x2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Виводимо назву програми
            Console.WriteLine("Назва програми Елемент шахмат. дошки 2х2");
            //просимо ввести користувача ширину та висоту
            Console.WriteLine("Введiть ширину");
            var x = 4; //int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть довжину");
            var y = 8; //int.Parse(Console.ReadLine());
            var str = "*";
            var str2 = "****   *";
            var str3 = "*   ****";

            for (var i = y - 1; i >= 0; i--)
                Console.Write(str);
            Console.WriteLine();

            Console.Write(str2);
            Console.ReadLine();

            Console.Write(str2);
            Console.ReadLine();

            for (var i = 0; i < y; i++)
                Console.Write(str);
            Console.WriteLine();

            Console.Write(str3);
            Console.ReadLine();

            Console.Write(str3);
            Console.ReadLine();

            for (var i = 0; i < y; i++)
                Console.Write(str);
            Console.WriteLine();
        }
    }
}