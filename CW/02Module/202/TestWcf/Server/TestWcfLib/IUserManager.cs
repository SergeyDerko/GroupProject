using System.ServiceModel;

namespace TestWcfLib
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);
    }
}