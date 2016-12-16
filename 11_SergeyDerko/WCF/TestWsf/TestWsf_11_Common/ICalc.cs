using System.ServiceModel;

namespace TestWsf_11_Common
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);
    }
}
