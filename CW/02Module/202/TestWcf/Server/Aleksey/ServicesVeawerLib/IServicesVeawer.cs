using System.ServiceModel;
using System.Collections.Generic;

namespace ServicesVeawerLib
{
    [ServiceContract]
    public interface IServicesVeawer
    {
        [OperationContract]
        List<Service> ServicesSearcher();
    }
}