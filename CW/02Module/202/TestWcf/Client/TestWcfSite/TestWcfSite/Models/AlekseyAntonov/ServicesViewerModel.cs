using ServicesViewerClientLib.ServicesViewerServiceReference;
using System.Collections.Generic;

namespace TestWcfSite.Models.AlekseyAntonov
{
    public class ServicesViewerModel
    {
        public string BehaviorName { get; set; }
        public string ServiceBehaviorConfiguration { get; set; }
        public string ServiceName { get; set; }
        public string EndpointBinding { get; set; }
        public string EndpointContract { get; set; }
        public string BaseAddress { get; set; }

        public ServicesViewerModel() { }

        public ServicesViewerModel(int num)
        {
            var servicesView = new ServicesViewerClient();
            OneService temp = servicesView.ServicesSearcher()[num];
            BehaviorName = temp.BehaviorName;
            BaseAddress = temp.BaseAddress;
            EndpointBinding = temp.EndpointBinding;
            EndpointContract = temp.EndpointContract;
            ServiceBehaviorConfiguration = temp.ServiceBehaviorConfiguration;
            ServiceName = temp.ServiceName;
            servicesView.Close();
        }

        public List<OneService> ListServices()
        {
            var servicesView = new ServicesViewerClient();
            var services = new List<OneService>(servicesView.ServicesSearcher());
            //foreach(var t in service)
            //{ List<OneService> services = }
            servicesView.Close();
            return services;
        }
    }


    public class OneController
    {
        public string nameController { get; set; }
        public string nameAction { get; set; }

       public OneController(string controller, string action)
        {
            this.nameController = controller;
            this.nameAction = action;
        }
        

    }

    public class AllControllers
    {
        public List<OneController> controllerCollection;// = new List<Controllers>();
        public AllControllers()
        {
            controllerCollection = new List<OneController>();
        }
    }
}