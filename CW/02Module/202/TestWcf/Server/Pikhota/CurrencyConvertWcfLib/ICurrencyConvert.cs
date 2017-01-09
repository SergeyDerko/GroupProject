using System.ServiceModel;

namespace CurrencyConvertLib
{
    [ServiceContract]
    public interface ICurrencyConvert
    {
        [OperationContract]
        decimal ChangeCurrency(string fromCurrency, string toCurrency);
    }
}
