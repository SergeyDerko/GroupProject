using System.ServiceModel;

namespace TestWsf_11_Common
{
    [ServiceContract]
    public interface ICalc
    {
        [OperationContract]
        double Sum(double a, double b); // Сложение
        [OperationContract]
        double Sub(double a, double b); // Вычитание
        [OperationContract]
        double Mult(double a, double b); //Умножение
        [OperationContract]
        double Div(double a, double b); // деление
    }
}
