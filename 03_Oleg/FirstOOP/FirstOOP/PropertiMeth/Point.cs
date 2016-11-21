using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOP.PropertiMeth
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Start()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
