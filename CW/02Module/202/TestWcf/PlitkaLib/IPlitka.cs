using System.ServiceModel;

namespace PlitkaLib
{
    [ServiceContract]
    public interface IPlitka
    {
        [OperationContract]
        int GetCountTiles(int heightWall, int widthWall, int heightTile,  int widthTile);
    }
}