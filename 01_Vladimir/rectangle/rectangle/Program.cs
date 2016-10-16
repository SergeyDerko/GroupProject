using System;
using System.Globalization;
using static System.Console;

namespace rectangle
{
    class Program  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прямокутник");
            Console.WriteLine("Висота прямокутника:\t\'h'");
            Console.WriteLine("Довжина прямокутника:\t\'l'");
            int l = int.Parse(ReadLine());
            int h = int.Parse(ReadLine());
            var str =new string('*', l);
            Console.WriteLine(str);
            int j = 0;
            while (j++< h)
            {
                Console.WriteLine(str);
                j++;
                ReadKey();
            }

            /* Console.Write(str);
             Console.Write(str);
             Console.Write(str);
             Console.Write(str); 
             Console.Write(str);
             Console.WriteLine();
             Console.Write(str);
             Console.Write(str);
             Console.Write(str);
             Console.Write(str);
             Console.Write(str);
             Console.WriteLine();
             Console.Write(str);
             Console.Write(str);
             Console.Write(str);
             Console.Write(str);
             Console.Write(str);
             Console.WriteLine(); */
        }
    }
}
