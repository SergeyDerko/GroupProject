using System.ServiceModel;

namespace TestWcfCommon
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);
        [OperationContract]
        int Division(int a, int b);
        [OperationContract]
        int Substraction(int a, int b);
        [OperationContract]
        int Multiplication(int a, int b);
    }
}