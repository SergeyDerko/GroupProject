using ServicesVeawerClientLib.ServicesVeawerServiceReference;
using System.Collections.Generic;

namespace TestWcfSite.Models.AlekseyAntonov
{
    public class ServicesVeawerModel
    {
       public ServicesVeawerModel()
        {
            ServicesVeawerClient client = new ServicesVeawerClient();
            List<Service> servicesList = new List<Service>();
            var temp=client.ServicesSearcher();

            foreach (var t in temp)
            {
                servicesList.Add(t);
            }
            client.Close();
        } 
    }
}