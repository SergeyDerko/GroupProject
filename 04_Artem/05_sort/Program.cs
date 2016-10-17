using System;

namespace _06_sort
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the length:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            var y = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();

            var table = new int[x, y];
       
             
            for (int i = 0; i < x; i++)
            {
                int j;
                for (j = 0; j < y; j++)
                {
                    table[i, j] = rand.Next(0, 100);
                    // выводим рандомные элементы от 0 до 100 (например)
                    
                    //сортируем

                    int swap = 0;
                  if (table [i, j] > table[i+1, j+1])
                            {
                                swap = table[i, j];
                                table[i, j] = table[i, j+1];
                                table[i, j+1] = swap;
                            }

                            Console.Write("{0}\t", swap);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();


                    Console.ReadKey();
                }
            }
        }
    


