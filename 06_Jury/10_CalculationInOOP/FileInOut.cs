using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    public class FileInOut
    {
        private readonly string file;

        public FileInOut(string x)
        {
            file = x;
            var strInfile = new StringBuilder();
            foreach (var i in File.ReadLines(file))
            {
                strInfile.Append(i);
            }
            file = strInfile.ToString();
        }

        public FileInOut(string x, string y)
        {
            File.WriteAllText(x,y);
        }
        public void Show()
        {
            Console.WriteLine($"Выражение считанное с файла: {file}");
        }

        public string WriteToSeparator()
        {
            return $"{file}";
        }
    }
}
