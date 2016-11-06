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
            string path =@"c:/download";
            string myFile;
            myFile=Directory.GetFiles(path, "*.avi").ToString();
            Console.WriteLine(myFile);
            Console.ReadKey();
        }
    }
}
