using System;

namespace Calc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("КАЛЬКУЛЯТОР"); //нет заголовка -1
            
            Console.Write("Введите первое число:");// -1
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");// -1
            double y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оператор:");// -1
            string i = Console.ReadLine();
            double result = 0;//-0.5
            if (i == "+")
            {
                result = x + y;
            }
            else if (i == "-")
            {
                result = x - y;
            }
            else if (i == "*")
            {
                result = x * y;
            }
            else if (i == "/")
            {
                result = x/y;
            }
            else
            {
                Console.WriteLine("что то пошло не так");
            }
            Console.WriteLine(value: result);
            Console.ReadKey();
            // нет задержки -0.5
            /*Console.
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * File*/

        }
        
    }
}

