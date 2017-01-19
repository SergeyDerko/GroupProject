using System;
using System.ServiceModel;

namespace MeteoTempServiceLib
{
    [ServiceContract]
    public interface IMeteoTemp
    {
        [OperationContract]
        string CurrentMeteoTemp();
    }
}
