using TestWcfCommon;

namespace PlitkaLib
{
    public class Plitka : IPlitka


    {
        public int GetCountTiles(int heightWall, int widthWall, int heightTile, int widthTile)
      {
            Logger.Enter();
                var sqrTile = heightTile * widthTile;
                var sqrWall = heightWall * widthWall;
                var result = sqrWall / sqrTile;
            var value = $"{sqrWall} / {sqrTile} = {result}";
        Logger.Info(value);
                return Logger.Leave(result);
            }
        }
}
