using System.ServiceModel;
using System.Collections.Generic;

namespace ServicesViewerLib
{
    [ServiceContract]
    public interface IServicesViewer
    {
        [OperationContract]
        List<OneService> ServicesSearcher();
    }
}