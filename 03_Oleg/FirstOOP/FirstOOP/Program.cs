using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstOOP.PropertiMeth;

namespace FirstOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstS = new Point();
            firstS.x = 12;
            firstS.y = 10;
            firstS.sym = '#';
            firstS.Start();

            Point secondS = new Point();
            secondS.x = 5;
            secondS.y = 9;
            secondS.sym = '@';
            secondS.Start();

            Console.ReadLine();
        }
    }
}
