using System.ServiceModel;

namespace TestWcfLib
{
    [ServiceContract(Namespace = "CalcService")]
    //[ServiceKnownType(typeof(ExpressionPlus))]
    public interface ICalc
    {
        [OperationContract]
        int Sum(int a, int b);

        [OperationContract]
        //[ServiceKnownType(typeof(ExpressionPlus))]
        decimal Execute(Expression expression);

        [OperationContract(Name = "ExecuteParams")]
        decimal Execute(decimal a, decimal b, MathAction mathAction);
    }
}