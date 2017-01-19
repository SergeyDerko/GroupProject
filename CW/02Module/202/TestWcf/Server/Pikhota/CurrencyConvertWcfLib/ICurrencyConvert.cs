using System;
using System.ServiceModel;

namespace CurrencyConvertLib
{
    [ServiceContract]
    public interface ICurrencyConvert
    {
        [OperationContract]
        string ChangeCurrency(string fromCurrency, string toCurrency,int count,string action);
    }
}
