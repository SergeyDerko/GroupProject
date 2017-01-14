using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ServicesVeawerLib
{
    public class ServicesVeawer : IServicesVeawer
    {
        public List<Service> ServicesSearcher()
        {
            List<Service> servicesList=new List<Service>();
            Service temp = new Service();
            XDocument xdoc = XDocument.Load("ReadFromAppConfig.exe.config");
            int num = 0;

            foreach (XElement serviceElement in xdoc.Element("configuration").Element("system.serviceModel").Elements("services").Elements("service"))
            {
                XAttribute behaviorConfigAttribute = serviceElement.Attribute("behaviorConfiguration");
                XAttribute nameAttribute = serviceElement.Attribute("name");
                XAttribute endpointBindingAttribute = serviceElement.Element("endpoint").Attribute("binding");
                XAttribute endpointContractAttribute = serviceElement.Element("endpoint").Attribute("contract");
                XAttribute baseAddressAttribute = serviceElement.Element("host").Element("baseAddresses").Element("add").Attribute("baseAddress");

                if (behaviorConfigAttribute != null && nameAttribute != null && endpointBindingAttribute != null && endpointContractAttribute != null && baseAddressAttribute != null)
                {
                    temp.ServiceBehaviorConfiguration = behaviorConfigAttribute.Value;
                    temp.ServiceName = nameAttribute.Value;
                    temp.EndpointBinding = endpointBindingAttribute.Value;
                    temp.EndpointContract = endpointContractAttribute.Value;
                    temp.BaseAddress = baseAddressAttribute.Value;
                    servicesList.Add(temp);
                    num++;
                }

            }

            num = 0;
            foreach (XElement phoneElement in xdoc.Element("configuration").Element("system.serviceModel").Elements("behaviors").Elements("serviceBehaviors").Elements("behavior"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");

                if (nameAttribute != null)
                {
                    temp = servicesList[num];
                    temp.BehaviorName = nameAttribute.Value;
                    servicesList[num] = temp;
                }
                num++;
            }
            return servicesList;
        }
    }

}
