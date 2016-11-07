using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DIR_FILE_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтение директории, запись файлов .avi в отдельный файл");
            string path = @"c:\download";
            File.WriteAllText(@"c:\download\list.txt", "");
            string[] myFile = Directory.GetFiles(path, "*.avi");
            //foreach (string dir in myFile)
            //{
            //    Console.WriteLine(dir);
            //}
            foreach (string t in myFile)
            {
                var s = t.Substring((path.Length + 1), t.Length - (path.Length + 1)) + Environment.NewLine;
                File.AppendAllText(@"c:\download\list.txt", s);
            }
            File.WriteAllText(@"c:\download\listMain.txt", File.ReadAllText(@"c:\download\list.txt"));
            while (true)
            {
                System.Threading.Thread.Sleep(500);
                string[] myFileTmp = Directory.GetFiles(path, "*.avi");
                if (myFileTmp != myFile)
                {
                    File.WriteAllText(@"c:\download\list.txt", "");
                    foreach (string t in myFile)
                    {
                        var s = t.Substring((path.Length + 1), t.Length - (path.Length + 1)) + Environment.NewLine;
                        File.AppendAllText(@"c:\download\list.txt", s);
                    }

                }

                Console.ReadKey();
            }
        }
    }
}
