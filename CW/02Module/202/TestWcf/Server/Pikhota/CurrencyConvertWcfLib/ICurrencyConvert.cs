using System.ServiceModel;

namespace CurrencyConvertLib
{
    [ServiceContract]
    public interface ICurrencyConvert
    {
        [OperationContract]
        string ChangeCurrency();
        //decimal ChangeCurrency(string fromCurrency, string toCurrency);
    }
}
