using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filey
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C: \Users\OLEG\Desktop\new\WriteText.txt");

            System.Console.WriteLine(" \t \n{0}", text);
            var s = new StringBuilder();
            var n = new StringBuilder();
            var w = new StringBuilder();
            foreach (var m in text)
            {
                if (char.IsSymbol(m))
                {
                    s.Append(m);
                }
                else if (char.IsNumber(m))
                {
                    n.Append(m);
                }
                else if (char.IsLetter(m))
                {
                    w.Append(m);
                }
            }
            Console.WriteLine(s.ToString() + n + w);
            File.WriteAllText(@"C: \Users\OLEG\Desktop\new\WriteText.txt", s.ToString() + n + w);

            Console.ReadLine();
        }
    }
}
