using System.ServiceModel;

namespace TestWcfLib
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);

        [OperationContract]
        decimal Execute(Expression expression);

        [OperationContract]
        decimal Execute(decimal a, decimal b, MathAction mathAction);
    }
}