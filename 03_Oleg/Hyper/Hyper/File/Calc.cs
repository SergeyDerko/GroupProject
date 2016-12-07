using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.File
{
    class Calc
    {
        double height, width, finish; // поля аж 3

        public Calc(double h, double w) // конструктор (не лего)
        {
            height = h;
            width = w;
        }
        public double Area()
        {
            return finish = Math.Sqrt(Math.Pow(height, 2) + (Math.Pow(width, 2)));
        }
    }
}
