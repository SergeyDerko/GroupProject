using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Plitochnik.Stena;

namespace Plitochnik
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps = 10;
            //var ps = 
            var pv = 10;
            var ss = 100;
            var sv = 100;
            Stena stroyka = new Stena(ps, pv, ss, sv);
            Console.WriteLine("\tШирина плитки: {0}\n" + "\tВысота плитки: {1}\n" + "\tШирина стены: {2}\n" + "\tВысота стены: {3}\n" +
                              "\tКоличество плитки: {4}", stroyka.Pshirina, stroyka.Pvisota, stroyka.Sshirina, stroyka.Svisota, stroyka.Kolplit());
            Console.ReadLine();
        }
    }
}
