using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bobik.ManyMeth
{
    class Calc
    {
        int height, width, depth; // поля аж 3

        public Calc(int h, int w, int d) // конструктор (не лего)
        {
            height = h;
            width = w;
            depth = d;
        }
        public int Area()
        {
            return 2 * ((height * width) + (height * depth) + (width * depth));
        }
        public int Capacity()
        {
            return (width * depth) * height;
        }
        public Calc More (int factor)
        {
            return new Calc(height * factor, width * factor, depth * factor);
        }
        public void Show()
        {
            Console.WriteLine("Now we have: height {0}, width {1}, depth {2}", height, width, depth);
            // Площадь:
            Console.WriteLine("Area of cube: {0}", Area());
            // Объем:
            Console.WriteLine("Capacity of cube: {0}", Capacity());
        }
    }
}
