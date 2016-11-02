using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_BuildWalls
{
    class Tile
    {
        private double Height { get; set; }
        private double Width { get; set; }
        public Tile(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double GetSqrTile(double height, double width)
        {
            var result = height * width;
            return result;
        }
    }
}
