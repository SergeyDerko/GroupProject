using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите оператор");
            string i = Console.ReadLine();
            double xy = 0;
            if (i == "+")
            {
                xy = x + y;
            }
            else if (i == "-")
            {
                xy = x - y;
            }
            else if (i == "*")
            {
                xy = x * y;
            }
            else if (i == "/")
            {
                xy = x / y;
            }
            else
            {
                Console.WriteLine("что то пошло не так");
            }
            Console.WriteLine(value: xy);


        }
    }

