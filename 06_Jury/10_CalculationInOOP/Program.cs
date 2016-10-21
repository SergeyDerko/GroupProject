using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInOut(@"../../Input.txt");
            file.Show();
            var example = file.WriteToSeparator();
            var separator = new Separator(example);
            separator.ShowSeparate();
            var result = separator.WriteOutSeparator();
            var outfile = new FileInOut(@"../../Output.txt", result);

            
            Console.ReadKey();

        }
        
    }
}
