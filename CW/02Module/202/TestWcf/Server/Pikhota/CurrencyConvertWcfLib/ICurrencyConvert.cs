using System.ServiceModel;

namespace CurrencyConvertLib
{
    [ServiceContract]
    public interface ICurrencyConvert
    {
        decimal Usd { get; set; }

        decimal Uah { get; set; }

        decimal Euro { get; set; }

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
