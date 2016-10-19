using System;
using System.Text;

namespace _11_srting_file
{
    class Program
    {
        static void Main()
        {
            //var text = File.ReadAllText(@"in.txt");
            var text = "df31232asda64sdad++++//**//";
            var symbol = new StringBuilder();
            var number= new StringBuilder();
            var letter=new StringBuilder();

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
            }
            Console.WriteLine(symbol.ToString() + number + letter);
            //File.WriteAllText(@"out.txt", symbol.ToString() + number + letter);


        }
    }
}
