using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0611_prg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Виводимо назву програми
            Console.WriteLine("\n Назва програми 'Прямокутник'");
            //просимо ввести користувача ширину та висоту
            Console.WriteLine("\n Введiть ширину: ");
            var lenght = Console.ReadLine();
            Console.WriteLine("\n Введiть довжину: ");
            var height = Console.ReadLine();

            Console.ReadKey();

            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("*");
                }
            } while (i <= 4);
        }
    }
}