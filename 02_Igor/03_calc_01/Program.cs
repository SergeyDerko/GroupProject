using System;

namespace _03_calc_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 число:");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите операнд:");
            string c = Console.ReadLine();
            if (c.Equals("+"))
            {
                Console.WriteLine(a + b);
            }
            if (c.Equals("*"))
            {
                Console.WriteLine(a * b);
            }
            if (c.Equals("-"))
            {
                Console.WriteLine(a - b);
            }
            if (c.Equals("/"))
            {
                Console.WriteLine(a / b);
            }
            Console.Read();
        }
    }
}
