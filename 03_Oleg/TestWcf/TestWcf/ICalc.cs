using System.ServiceModel;

namespace Common
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);
    }
}