using System;
using System.IO;

namespace Rectangle_06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string path = @"D:\Test\file.txt";
            if (args.Length == 0 )
            {
                Console.WriteLine("Please enter a numeric arguments.");
            }
            args[0] = "Высота: ";
            args[2] = "Ширина: ";
            var height = int.Parse(args[1]);
            var width = int.Parse(args[3]);
            for (var i = 1; i < height; i++)
            {
                Console.WriteLine();
                for (var j = 0; j < width; j++)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllLines(path,args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }            
        }
    }
}
