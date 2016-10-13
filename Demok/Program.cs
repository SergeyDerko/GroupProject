using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demok
{
    class Program
    {
        static void Main(string[] args)
        {
            int line, colum;
            bool step = true;
            while (step)
            {
                Console.Write("Enter length colum: ");
                var resultLi = Int32.TryParse(Console.ReadLine(), out colum);
                Console.Write("\nEnter length line (max number 35):");
                var resultCo = Int32.TryParse(Console.ReadLine(), out line);
                if (resultLi && resultCo)
                {
                    for (int i = 1; i <= colum; i++)
                    {
                        if ((i % 2) == 0)
                        {
                            for (int n = 1; n <= line; n++)
                            {
                                if ((n % 2) == 0)
                                {
                                    Console.Write("##");
                                }
                                else
                                {
                                    Console.Write("  ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            for (int n = 1; n <= line; n++)
                            {
                                if ((n % 2) == 0)
                                {
                                    Console.Write("  ");
                                }
                                else
                                {
                                    Console.Write("##");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    step = false;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }
            Console.ReadLine();
        }
    }
}
