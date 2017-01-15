using ServicesVeawerClientLib.ServicesVeawerServiceReference;
using System.Collections.Generic;

namespace TestWcfSite.Models.AlekseyAntonov
{
    public class ServicesVeawerModel
    {
        //readonly static ServicesVeawerClient ServiceView = new ServicesVeawerClient();
        public List<Service> ServicesList { get; set; }// = ServiceView.ServicesSearcher();
      //  new List<Service>();
        public ServicesVeawerModel()
        {
            var serviceView = new ServicesVeawerClient();
            ServicesList = new List<Service>(serviceView.ServicesSearcher());
            serviceView.Close();
        }
    }
}