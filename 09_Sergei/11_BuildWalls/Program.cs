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



            var sqrTile = heightTile * widthTile;
            var sqrWall = heightWall * widthWall;
            var result = sqrWall / sqrTile;
            Console.WriteLine("Нужно"+ result+"плиток.");
            //   Console.Write(GeTCountTills(heightWall, heightTile, widthWall, widthTile););

            /*var wall = new Wall(heightWall, widthWall);  
            var tile = new Tile(heightTile, widthTile);  
            
            wall.
            */

        }

        

        

        public static double GetCountTiles(double heightWall, double heightTile, double widthWall, double widthTile)
        {
            var sqrTile = heightTile*widthTile;
            var sqrWall = heightWall*widthWall;        
            var result = sqrWall/sqrTile;
            return result;
        }
    }
}
