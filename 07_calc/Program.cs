using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol=new StringBuilder();
            var number = new StringBuilder();
            var letter = new StringBuilder();

            var text =File.ReadAllText(@"in.txt");
            foreach (var i in text)
            {
                if (char.IsSymbol(i))
                {
                    symbol.Append(i);
                }
                else if (char.IsNumber(i))
                {
                    number.Append(i);
                }
                else if (char.IsLetter(i))
                {
                    letter.Append(i);
                }
            }
            File.WriteAllText(@"out.txt",symbol.ToString()+number+letter);
        }
    }
}
