using System;

namespace _11_BuildWalls
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите ширину стены: ");
            double widthWall = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту стены: ");
            double heightWall = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину плитки: ");
            double widthTile = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту плитки: ");
            double heightTile = Convert.ToDouble(Console.ReadLine());

            /*var wall = new Wall(heightWall, widthWall);  
            var tile = new Tile(heightTile, widthTile);  
            
            wall.
            */

        }

        

        

        public double GetCountTiles(double sqrWall, double sqrTile)
        {           
            var result = sqrWall/sqrTile;
            return result;
        }
    }
}
