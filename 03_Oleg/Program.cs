using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "n";
            do
            {
                int i, n, k, m;
                Console.WriteLine("Please enter any firs number of 2 to 100");
                i = Convert.ToInt32(Console.ReadLine());
                while (i < 2 || i > 100)
                {
                    Console.WriteLine("Try again!");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Please enter any second number of 2 to 100");
                n = Convert.ToInt32(Console.ReadLine());
                while (n < 2 || n > 100)
                {
                    Console.WriteLine("Try again!");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                k = i;
                m = n;
                if (i < n)
                {
                    Console.Write("All even numbers: ");
                    for (; i <= n; i++)
                    {
                        if ((i % 2) == 0)
                        {
                            Console.Write("{0} ", i);
                        }
                    }
                    Console.Write("\nAll odd numbers: ");
                    for (; k <= n; k++)
                    {
                        if ((k % 2) != 0)
                        {
                            Console.Write("{0} ", k);
                        }
                    }
                }
                else
                {
                    Console.Write("All even numbers: ");
                    for (; n <= i; n++)
                    {
                        if ((n % 2) == 0)
                        {
                            Console.Write("{0} ", n);
                        }
                    }
                    Console.WriteLine("All odd numbers: ");
                    for (; m <= i; m++)
                    {
                        if ((m % 2) != 0)
                        {
                            Console.Write("{0} ", m);
                        }
                    }
                }
                Console.WriteLine("Contine in promgam? world 'y' - contine");
                yesNo = Console.ReadLine();
            } while (yesNo == "y");
            Console.ReadLine();
        }
    }
}
