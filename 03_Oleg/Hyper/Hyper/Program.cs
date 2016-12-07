using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hyper.File;

namespace Hyper
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueHeight, valueWidth; 
            bool choseOne, choseTwo; 
            Console.WriteLine("Hello the human!\n" + 
            "This program calculat area of parallelepiped. Good luck"); // продолжение сообщения
            do // Это тока проверка на кривость рук пользователя 
            {
                // в цикле пользователь вводит значения. если хоть один из воодимых значений будет не правльным, цикл повторит проход 
                Console.WriteLine("Enter kat2 number of 1 to 100: ");
                    // спрашиваем у пользователя размер (высоту) фигуры
                Proverka height = new Proverka();
                choseOne = height.Trenner(Console.ReadLine(), out valueHeight);

                Console.WriteLine("Enter kat1 number of 1 to 100: ");
                Proverka width = new Proverka();
                choseTwo = width.Trenner(Console.ReadLine(), out valueWidth);

            } // условиие цикла, если пользователь ввел не корректное одно из значений фигуры цикл повторится  
            while (!choseOne || (valueHeight < 1) || (valueHeight > 100) || !choseTwo || (valueWidth < 1) ||
                   (valueWidth > 100));
            Calc obj = new Calc(valueHeight, valueWidth);
            Console.WriteLine(obj.Area());
            Console.ReadLine();
        }
    }
}
