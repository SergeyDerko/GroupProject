using System.ServiceModel;

namespace TestWcfCommon
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);
    }
}
