using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SergeyDerkoLibrary
{
    [ServiceContract]
    public interface IScanPc
    {
        [OperationContract]
        List<StringBuilder> Info();

    }
}
