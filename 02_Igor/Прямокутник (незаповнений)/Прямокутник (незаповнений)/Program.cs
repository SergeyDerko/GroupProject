using System;

namespace Прямокутник__незаповнений_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Виводимо назву програми
            Console.WriteLine("Назва програми Прямокутник");
            //просимо ввести користувача ширину та висоту
            Console.WriteLine("Введiть ширину");
            var x = 4; //int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть довжину");
            var y = 10; //int.Parse(Console.ReadLine());
            var str = "*";
            var str2 = "*        *";


            for (var i = y - 1; i >= 0; i--)
            Console.Write(str);
            Console.WriteLine();

            Console.Write(str2);
            Console.WriteLine();

            Console.Write(str2);
            Console.WriteLine();

            for (var i = 0; i < y; i++)
                Console.Write(str);
            Console.WriteLine();

            //програма виводить прямокутник 4*10
        }
    }
}