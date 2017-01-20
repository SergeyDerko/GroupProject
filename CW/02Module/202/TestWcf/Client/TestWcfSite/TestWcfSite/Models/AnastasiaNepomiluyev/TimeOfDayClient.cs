using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using TimeOfDayConvertLib.TimeOfDayServiceReference;

namespace TestWcfSite.Models.AnastasiaNepomiluyev
{
    public class TimeOfDayClient
    {
        public virtual string TimeOfDay { get; set; }

        public void SetTimeOfDay()
        {
            try
            {
                TimeOfDayConverterClient client = new TimeOfDayConverterClient();
                TimeOfDay = client.ConvertDateToTimeOfDay(DateTime.Now);
                client.Close();
            }
            catch (EndpointNotFoundException e)
            {
                TimeOfDay = "Попытка обращения к сервису закончилась неудачно :(";
            }
            
        }
    }
}