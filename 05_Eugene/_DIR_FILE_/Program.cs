using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DIR_FILE_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтение директории, запись файлов .avi в отдельный файл");
            string path =@"c:\download";
            File.WriteAllText(@"c:\download\list.txt","");
            string[] myFile =Directory.GetFiles(path,"*.avi");
            //foreach (string dir in myFile)
            //{
            //    Console.WriteLine(dir);
            //}
            for (int i = 0; i < myFile.Length; i++)
            {
                var s = myFile[i].Substring((path.Length+1), myFile[i].Length -(path.Length+1)) + Environment.NewLine;
                File.AppendAllText(@"c:\download\list.txt", s);
            }
            

            Console.ReadKey();
        }
    }
}
