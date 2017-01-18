using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IO;

namespace ServicesViewerLib
{
    public class ServicesViewer : IServicesViewer
    {
        public static string path;
        public List<OneService> ServicesSearcher()
        {
            List<OneService> services = new List<OneService>();
           
            string executableFileName = System.IO.Path.GetFileName(path);
            if (File.Exists(executableFileName))
            {
                XDocument xdoc = XDocument.Load(executableFileName + ".config");
                int num = 0;

                foreach (XElement serviceElement in xdoc.Element("configuration").Element("system.serviceModel").Elements("services").Elements("service"))
                {
                    OneService temp = new OneService();
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
                        OneService temp = new OneService();
                        temp = services[num];
                        temp.BehaviorName = nameAttribute.Value;
                        services[num] = temp;
                    }
                    num++;
                }
            }
            return services;
        }
    }
}
