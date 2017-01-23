using TestWcfCommon;

namespace PlitkaLib
{
    public class Plitka : IPlitka
        {
        public int GetCountTiles(int heightWall, int widthWall, int heightTile, int widthTile)
      {
            Logger.Enter();
            Logger.Write(Level.Debug, "Иницаилизация переменных...");
            Logger.Write(Level.Info, "Инициализация прошла успешно!");
            var sqrTile = heightTile * widthTile;
                var sqrWall = heightWall * widthWall;
                var result = sqrWall / sqrTile;
            var value = $"{sqrWall} / {sqrTile} = {result}";
            Logger.Write(Level.Info, "Посчитали)");
            Logger.Info(value);
                return Logger.Leave(result);
            }
        }
}
