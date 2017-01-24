using System.ServiceModel;

namespace TemperatureServiceLib
{
    [ServiceContract]
    public interface ITemperature
    {
        [OperationContract]
        string Temp();
    }
}