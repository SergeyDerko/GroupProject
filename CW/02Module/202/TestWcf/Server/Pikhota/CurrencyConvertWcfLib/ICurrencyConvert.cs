using System.Collections.Generic;
using System.ServiceModel;

namespace CurrencyConvertLib
{
    [ServiceContract]
    public interface ICurrencyConvert
    {

        List<string> Li { get; set; }
        int Count { get; set; }

        [OperationContract]
        decimal UsdToEuro();
                
        [OperationContract]
        decimal UsdToUah();
        
        [OperationContract]
        decimal EuroToUsd();

        [OperationContract]
        decimal EuroToUah();
        
        [OperationContract]
        decimal UahToUsd();
        
        [OperationContract]
        decimal UahToEuro();
    }
}
