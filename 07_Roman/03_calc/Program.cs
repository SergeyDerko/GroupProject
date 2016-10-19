using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double per =Convert.ToDouble( args[0]);
            double dr =Convert.ToDouble( args[2]);
            string zn = args[1];
            double res=0;
            switch (zn)
            {
                case "+":
                    res = per + dr;
                    break;
                case "-":
                    res = per - dr;
                    break;
                case "*":
                    res = per*dr;
                    break;
                case "/":
                    res = per/dr;
                    break;
            }
            Console.WriteLine("{0}{1}{2}={3}",per,zn,dr,res);
        }
    }
}
