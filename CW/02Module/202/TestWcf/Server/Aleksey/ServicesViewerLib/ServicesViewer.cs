using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace ServicesViewerLib
{
    public class ServicesViewer : IServicesViewer
    {
        public List<OneService> ServicesSearcher()
        {
            List<OneService> services = new List<OneService>();
            OneService temp = new OneService();
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            string executableFileName = System.IO.Path.GetFileName(path);
            XDocument xdoc = XDocument.Load(executableFileName + ".config");
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
                    services.Add(temp);
                    num++;
                }

            }

            num = 0;
            foreach (XElement phoneElement in xdoc.Element("configuration").Element("system.serviceModel").Elements("behaviors").Elements("serviceBehaviors").Elements("behavior"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");

                if (nameAttribute != null)
                {
                    temp = services[num];
                    temp.BehaviorName = nameAttribute.Value;
                    services[num] = temp;
                }
                num++;
            }
            return services;
        }
    }
}
