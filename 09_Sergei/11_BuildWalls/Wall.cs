using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11_BuildWalls
{
    class Wall
    {
        private double Height { get; set; }
        private double Width { get; set; }
        public Wall(double height,double width)
        {
            Height = height;
            Width = width;
        }
        public double GetSqrWall(double height, double width)
        {
            var result = height * width;
            return result;
        }
    }
}
