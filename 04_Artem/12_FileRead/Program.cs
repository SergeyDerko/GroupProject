using System;
using System.IO;
using System.Text;

namespace _12_FileRead
{
    class Program
    {
        static void Main()
        {

            var text = File.ReadAllText(@"in.txt");
            var symbol = new StringBuilder();
            var number = new StringBuilder();
            var letter = new StringBuilder();

            foreach (var s in text)
            {
                if (char.IsSymbol(s))
                {
                    symbol.Append(s);  
                }
                else if (char.IsNumber(s))
                {
                    number.Append(s);
                }
                else if (char.IsLetter(s))
                {
                    letter.Append(s);
                }
                File.WriteAllText(@"out.txt",symbol.ToString()+ number + letter);
            }
           
        }
    }
}
