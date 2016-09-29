using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
			//нет заголовка -1
            Console.WriteLine("введите первое число");// -1
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");// -1
			double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите оператор");// -1
            string i = Console.ReadLine();
            double xy = 0;//-0.5
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
                xy = x/y;
            }
            else
            {
                Console.WriteLine("что то пошло не так");
            }
            Console.WriteLine(value: xy);
			// нет задержки -0.5
            //Console.File
        }
    }

