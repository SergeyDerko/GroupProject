using System.Collections.Generic;
using System.ServiceModel;

namespace SergeyDerkoLibrary
{
    [ServiceContract]
    public interface IScanPc
    {
        [OperationContract]
        Dictionary<string, string> Info();

    }
}
