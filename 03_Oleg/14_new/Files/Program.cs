using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            string n;
            string fileName = "file_";
            string path = @"C: \Users\OLEG\Desktop\new";
            for (int i = 1, k = 1; i < count;i++, k++)
            {
                System.Threading.Thread.Sleep(1000);
                n = string.Format("text-{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
                var pathFile = Path.Combine(path, fileName) + i;
                File.WriteAllText(pathFile + n + ".txt", fileName + i);
            }
            /*
            var directoryinfo = new DirectoryInfo(path);
            foreach(FileInfo fileInfo in directoryinfo.GetFiles())
            {

            }
            
            int count = 10;
            string n;
            string pathDir = @"C: \Users\OLEG\Desktop\new";
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }

            string fileName = "file_";

            for (int i = 0; i < count; i++)
            {                
                System.Threading.Thread.Sleep(1000);
                n = string.Format("text-{0:yyyy-MM-dd_hh-mm-ss}", DateTime.Now);
                var pathFile = Path.Combine(pathDir, fileName) + i;
                File.WriteAllText(pathFile + ".txt", fileName + i + n);
            }

            var directoryInfo = new DirectoryInfo(pathDir);
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                var creationTime = fileInfo.CreationTime;
            }*/
            Console.ReadLine();
        }
    }
}
