using System.ServiceModel;

namespace TestWCFCommon
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);

        [OperationContract]
        int Sub(int a, int b);

        [OperationContract]
        double Div(double a, double b);

        [OperationContract]
        int Mult(int a, int b);
    }
}
