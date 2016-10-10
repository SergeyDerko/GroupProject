using System;

namespace _07_SortArrays
{
    internal class Program
    {
        private static void Main()
        {
            Title("Sorting array.");
            var rand = new Random();
            //Creating variable type bool, which will be a determinant criteria of finish a program.
            var finished = false;
            while (!finished)
            {
                try
                {
                    //Entering value of length for array
                    Console.Write("Enter number: ");
                    var num = int.Parse(Console.ReadLine());

                    var array = new int[num];
                    for (var i = 0; i < num; i++)
                    {
                        array[i] = rand.Next(100);
                        Console.Write(" " + array[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine(
                        "--------------------------------------------------------------------------------------------------------");
                    //Sorting
                    for (var i = 0; i < num; i++)
                    {
                        for (var j = 0; j < num - 1; j++)
                        {
                            if (array[j] > array[j + 1])
                            {
                                var temp = array[j + 1];
                                array[j + 1] = array[j];
                                array[j] = temp;
                            }
                            
                        }
                    }
                    for (int i = 0; i < num; i++)
                    {
                        Console.Write(" " + array[i]);
                    }
                    Console.WriteLine();
                    finished = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something wrong! Please, enter a numeric value.");
                }
            }
            Console.ReadKey();
        }
        private static void Title(string title)
        {
            Console.Write("                                       " + title);
            Console.WriteLine();
        }
    }
}


