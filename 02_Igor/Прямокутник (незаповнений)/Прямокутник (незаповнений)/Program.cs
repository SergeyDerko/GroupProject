using System;

namespace Прямокутник__незаповнений_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Вводимо назву програми
            Console.WriteLine("Навза програми Прямокутник(незаповнений)");
            //Просимо ввести користувача ширину та висоту
            Console.WriteLine("Введіть ширину");
            var x = 4; //int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть довжину");
            var y = 10; //int.Parse(Console.ReadLine());
            var str = "*";

            //виводжу верхню лінію прямокутника
            for (var i = y - 1; i >= 0; i--)
                Console.Write("str");
            Console.WriteLine();

            
            for (var i = 0; i < y; i++)
                Console.Write(str);
            Console.WriteLine();

            //виводжу бокові стінки прямокутника
            for (var i = 0; i < x; i++)
            {
                Console.Write("*");
                for (var j = 0; j < y - 1; j++)
                    Console.Write(str);
                Console.Write("*");
                Console.WriteLine();
            }
            //виводжу нижню лінію прямокутника
            for (var i = 0; i < y; i++)
                Console.Write(str);
            Console.WriteLine();
        }
        
    }
}