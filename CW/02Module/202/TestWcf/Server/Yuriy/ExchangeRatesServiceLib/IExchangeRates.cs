using System.ServiceModel;

namespace ExchangeRatesServiceLib
{
    [ServiceContract]
    public interface IExchangeRates
    {
        [OperationContract]
        string CurrentExchangeRates();
    }
}
