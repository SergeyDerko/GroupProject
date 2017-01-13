using System.Collections.Generic;
using System.ServiceModel;

namespace CurrencyConvertLib
{
    

    [ServiceContract]
    public interface ICurrencyConvert
    {
        [OperationContract]
        string ChangeCurrency(string fromCurrency, string toCurrency,int count);
        
        /* [OperationContract]
         decimal UsdToEuro(int count);
                 
         [OperationContract]
         decimal UsdToUah(int count);
         
         [OperationContract]
         decimal EuroToUsd(int count);
 
         [OperationContract]
         decimal EuroToUah(int count);
         
         [OperationContract]
         decimal UahToUsd(int count);
         
         [OperationContract]
         decimal UahToEuro(int count);*/
    }
}
