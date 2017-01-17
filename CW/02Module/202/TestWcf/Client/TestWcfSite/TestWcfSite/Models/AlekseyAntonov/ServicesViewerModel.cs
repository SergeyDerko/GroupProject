using ServicesViewerClientLib.ServicesViewerServiceReference;
using System.Collections.Generic;

namespace TestWcfSite.Models.AlekseyAntonov
{
    public class ServicesViewerModel 
    {

        public  string BehaviorName { get; set; }
        public string ServiceBehaviorConfiguration { get; set; }
        public string ServiceName { get; set; }
        public  string EndpointBinding { get; set; }
        public  string EndpointContract { get; set; }
        public string BaseAddress { get; set; }
        public int CountModels { get; set; }
        public ServicesViewerModel(int num)
        {
          //  new Service();
            var serviceView = new ServicesViewerClient();
            this.CountModels = serviceView.ServicesSearcher().Length;
            OneService temp = serviceView.ServicesSearcher()[num];
            this.BehaviorName = temp.BehaviorName;
            this.BaseAddress = temp.BaseAddress;
            this.EndpointBinding = temp.EndpointBinding;
            this.EndpointContract = temp.EndpointContract;
            this.ServiceBehaviorConfiguration = temp.ServiceBehaviorConfiguration;
            this.ServiceName = temp.ServiceName;
            serviceView.Close();
        }
    }
}