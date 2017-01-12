using System.ServiceModel;
using PlitkaClientLib.PlitkaServiceReference;

namespace TestWcfSite.Models.DanilaModels
{
    public class Plitka
    {
        public Plitka()
        {
            try
            {

                var client = new PlitkaClient();
                client.GetCountTiles();
                client.Close();
            }
            catch (EndpointNotFoundException)
            {
                Error = "СЕРВИС НЕ ЗАПУЩЕН!";
            }
        }

        public string Error { get; set; }
    }
}