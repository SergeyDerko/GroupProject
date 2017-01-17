﻿using ServicesViewerClientLib.ServicesViewerServiceReference;
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

        // public static ServicesViewerClient ServicesView { get; set; }

        public ServicesViewerModel(){}

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
        public int AmountService()
        {
            var servicesView = new ServicesViewerClient();
            int amount = servicesView.ServicesSearcher().Length;
            servicesView.Close();
            return amount;
        }
    }
}