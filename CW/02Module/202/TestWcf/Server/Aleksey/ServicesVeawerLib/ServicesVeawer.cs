using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ComponentModel;

namespace ServicesVeawerLib
{
    public class ServicesVeawer : IServicesVeawer
    {
        public List<string> ServicesSearcher()
        {
            string g;
           
            List<string> servicesList = new List<string>();
            var keyCollections = ConfigurationSettings.AppSettings.Keys;
            foreach (var key in keyCollections)
            {
                servicesList.Add(ConfigurationSettings.AppSettings["name"]);
            }
            int keyCount = ConfigurationSettings.AppSettings.Count;

            for (int i = keyCount / 2; i < keyCount; i++)
            {
                servicesList.Add(ConfigurationSettings.AppSettings. .GetKey("name"));
            }
            return servicesList;
        }
    }

}
