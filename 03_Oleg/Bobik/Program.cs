using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bobik.ManyMeth;

namespace Bobik
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueHeight, valueWidth, valueDepth;
            string stepOne, stepTwo, stepTree;
            bool choseOne, choseTwo, choseTree;
            Console.WriteLine("Hello the human!\n" +
            "This program calculat area of parallelepiped. Good luck");
            do // Это тока проверка на кривость рук пользователя 
            {
                Console.WriteLine("Enter height number of 1 to 100");
                YaHZ height = new YaHZ();                         
                stepOne = Console.ReadLine();
                choseOne = height.Trenner(stepOne, out valueHeight);
                YaHZ width = new YaHZ();
                Console.WriteLine("Enter width number of 1 to 100");
                stepTwo = Console.ReadLine();
                choseTwo = width.Trenner(stepTwo, out valueWidth);
                YaHZ depth = new YaHZ();
                Console.WriteLine("Enter depth number of 1 to 100");
                stepTree = Console.ReadLine();
                choseTree = depth.Trenner(stepTree, out valueDepth);
                Console.WriteLine("Now we have: height {0}, width {1}, depth {2}", valueHeight, valueWidth, valueDepth);
            }
            while (!choseOne || (valueHeight < 1) || (valueHeight > 100) || !choseTwo ||
                 (valueWidth < 1) || (valueWidth > 100) || !choseTree || (valueDepth < 1) || (valueDepth > 100));
            // И только после проверки будет написа код расчета нашего кубика 
            Calc obj = new Calc(valueHeight, valueWidth, valueDepth);
            // Площадь:
            Console.WriteLine("Area of cube: {0}", obj.Area());
            // Объем:
            Console.WriteLine("Capacity of cube: {0}", obj.Capacity());

            Console.ReadLine();
        }
    }
}
