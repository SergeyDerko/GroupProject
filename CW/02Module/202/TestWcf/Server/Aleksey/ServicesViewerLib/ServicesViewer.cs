using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.ServiceModel;
using TestWcfCommon;

namespace ServicesViewerLib
{
    public class ServicesViewer : IServicesViewer
    {
        public static string path;
        public List<OneService> ServicesSearcher()
        {
            Logger.Start();
            Logger.Info(path);
            List<OneService> services = new List<OneService>();

            string executableFileName;
            Logger.Info(executableFileName= System.IO.Path.GetFileName(path));
            try
            {
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
                            Logger.Info(temp.ServiceName = nameAttribute.Value);
                            Logger.Info(temp.EndpointBinding = endpointBindingAttribute.Value);
                            Logger.Info(temp.EndpointContract = endpointContractAttribute.Value);
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
                            Logger.Info(temp.BehaviorName = nameAttribute.Value);
                            services[num] = temp;
                        }
                        num++;
                    }
                }
            Logger.Leave("Завершение работы метода ServiceViewer.ServicesSearcher()");
            return services;
        }
            catch (FileNotFoundException e)
            {
                ValidationFault fault = new ValidationFault();

                fault.Result = false;
                fault.Message = e.Message;
                fault.Description = "File *exe.congig not found.";

                throw new FaultException<ValidationFault>(fault);
            }
            catch (FileLoadException e)
            {
                FileFound fault = new FileFound();

                fault.Result = false;
                fault.Message = e.Message;
                fault.Description = "Cannot divide by zero.";

                throw new FaultException<FileFound>(fault);
            }
        }
    }
}
