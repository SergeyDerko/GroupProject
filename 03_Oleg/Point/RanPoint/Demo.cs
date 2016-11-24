using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point.RanPoint
{
    class Demo
    {
        public int x; // поля
        public int y;
        public char sym;

        public Demo (int xN, int yN, char symN) // конструктор
        {
            x = xN;
            y = yN;
            sym = symN;
        }
        public void Show() // метод  
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
