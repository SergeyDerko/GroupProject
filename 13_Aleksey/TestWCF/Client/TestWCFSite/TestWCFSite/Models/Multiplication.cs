using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWcfSite.Models
{
    public static class Multiplication
    {
        public static int X { get; set; }
        public static int Y { get; set; }

        public static int MultExpr()
        {
            return X * Y;
        }

        public static int MultExpr(int x, int y)
        {
            return x * y;
        }
    }
}