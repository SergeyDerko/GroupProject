using System.ServiceModel;

namespace TestWCFCommon
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);
    }
}
