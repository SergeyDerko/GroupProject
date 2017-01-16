using ServicesVeawerClientLib.ServicesVeawerServiceReference;
using System.Collections.Generic;

namespace TestWcfSite.Models.AlekseyAntonov
{
    public class ServicesVeawerModel
    {
        public  string BehaviorName { get; set; }
        public string ServiceBehaviorConfiguration { get; set; }
        public string ServiceName { get; set; }
        public  string EndpointBinding { get; set; }
        public  string EndpointContract { get; set; }
        public string BaseAddress { get; set; }
        public ServicesVeawerModel(int num)
        {
            var serviceView = new ServicesVeawerClient();
            Service temp = serviceView.ServicesSearcher()[num];
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