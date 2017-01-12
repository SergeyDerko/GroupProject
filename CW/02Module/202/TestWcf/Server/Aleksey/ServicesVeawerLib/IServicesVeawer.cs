using System.ServiceModel;
using System.Collections.Generic;

namespace ServicesVeawerLib
{
    [ServiceContract]
    public interface IServicesVeawer
    {
        List<string> ServicesList { get; set; }

        [OperationContract]
        List<string> ServicesSearcher();
    }
}