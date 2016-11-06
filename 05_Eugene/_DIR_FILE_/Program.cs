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
            string path =@"c:\download";
            string [] myFile;
            File.WriteAllText(@"c:\download\list.txt","");
            myFile =Directory.GetFiles(path,"*.avi");
            //foreach (string dir in myFile)
            //{
            //    Console.WriteLine(dir);
            //}
            for (int i = 0; i < myFile.Length; i++)
            {
                var s = myFile[i].Substring((path.Length+1), myFile[i].Length -(path.Length+1)) + Environment.NewLine;
                File.AppendAllText(@"c:\download\list.txt", s);
            }
            //foreach (var s in myFile)
            //{
                //s.Substring(0, 11);
             //   File.AppendAllText(@"c:\download\list.txt", s+"\n");
                //File.AppendAllText(@"c:\download\list.txt","\n");
            //}

            Console.ReadKey();
        }
    }
}
