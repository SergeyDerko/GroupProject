using System;

namespace _07_SortArrays
{
    internal class Program
    {
        private static void Main()
        {
            var rand = new Random();
            //Creating variable type bool, which will be a determinant criteria of finish a program.
            var finished = false;
            while (!finished)
            {
                //Entering value of length for array
                Console.WriteLine("Enter number: ");
                var num = Console.ReadLine();
                if (IsNum(num))
                {   
                    var array = new int[num.Length];
                    for (var i = 0; i < array.Length; i++)
                    {

                        array[i] = rand.Next(100);
                        Console.Write(" " + array[i]);
                    }
                    Console.WriteLine(
                        "--------------------------------------------------------------------------------------------------------");
                    for (var i = 0; i < array.Length; i++)
                    {
                        for (var j = 0; j < array.Length - 1; j++)
                        {
                            if (array[j] > array[j + 1])
                            {
                                var temp = array[j + 1];
                                array[j] = array[j + 1];
                                array[j + 1] = temp;
                            }
                        }
                    }

                    for (var i = 0; i < array.Length; i++)
                    {
                        Console.Write("{0}\t" + array[i]);
                    }
                    finished = true;
                }
                else
                {
                    Console.WriteLine("Enter a numeric value, please!");
                }
            }
            
        }
        //Checking string on the numeric value.
        public static bool IsNum(string number)
        {
            var anyString = number.ToCharArray();
            for (var i = 0; i <= anyString.Length - 1; i++)
            {
                if (char.IsDigit(anyString[i]))
                {
                    continue;
                }
                return anyString[i] == anyString.Length - 1;
            }
            return true;
        }
    }
}
