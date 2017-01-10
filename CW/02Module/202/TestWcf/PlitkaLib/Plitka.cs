namespace PlitkaLib
{
    public class Plitka : IPlitka


    {
        public int GetCountTiles(int heightWall, int widthWall, int heightTile, int widthTile)
        {

            {
                var sqrTile = heightTile * widthTile;
                var sqrWall = heightWall * widthWall;
                var result = sqrWall / sqrTile;
                return result;
            }


        }
    }
}
