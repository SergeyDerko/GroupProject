using System.ServiceModel;

namespace TestWcfCommon
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);
        [OperationContract]
        int Sub(int a, int b);
        [OperationContract]
        int Mul(int a, int b);
        [OperationContract]
        int Div(int a, int b);
        
    }
}
