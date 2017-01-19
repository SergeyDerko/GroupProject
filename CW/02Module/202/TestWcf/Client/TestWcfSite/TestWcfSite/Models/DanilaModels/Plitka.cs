using PlitkaClientLib.PlitkaServiceReference;

namespace TestWcfSite.Models.DanilaModels
{
    public  class Plitka
    {
        public Plitka()
        {var client =new PlitkaClient();
            client.Close();
            
        }
        public double heightWall { get; set; }
        public double widthWall { get; set; }
        public double heightTile { get; set; }
        public double widthTile { get; set; }

        public double Result()
        {
            string res = "";
            {
                double sqrWall;
                sqrWall = (heightWall * widthWall);
                double sqrTile;
                sqrTile = (heightTile * widthTile);
                double result;
                result = (sqrWall / sqrTile);
                {

                    return result;
                }
            }
        }
    }
}



