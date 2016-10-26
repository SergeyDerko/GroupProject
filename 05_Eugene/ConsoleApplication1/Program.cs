using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            string text = "";
            for (int i = 0; i < 11;i++)
                {
                    text = Convert.ToString (Guid.NewGuid());
                    File.WriteAllText(path, text);
                };


        }
    }
}
