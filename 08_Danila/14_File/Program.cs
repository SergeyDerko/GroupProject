using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _14_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "fdfdf";
            for (int i = 0,y=1; i < 10;y++ ,i++)
            {
                File.WriteAllText(@"C:\Users\Daniel\Desktop\ggg" + y + ".txt", text);
            }
            Console.ReadLine();
        }
    }
}
    
