using System.ServiceModel;
using System.Collections.Generic;

namespace ServicesViewerLib
{
    [ServiceContract]
    public interface IServicesViewer
    {
        [OperationContract]
        [FaultContract(typeof(ValidationFault))]
        [FaultContract(typeof(FileFound))]
        List<OneService> ServicesSearcher();
        
    }
}