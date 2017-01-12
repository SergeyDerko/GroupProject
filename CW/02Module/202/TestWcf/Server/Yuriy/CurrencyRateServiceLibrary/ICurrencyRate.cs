using System.Collections.Generic;
using System.ServiceModel;

namespace CurrencyRateServiceLibrary
{
    [ServiceContract]
    public interface ICurrencyRate
    {
        [OperationContract]
        List<Currency> CurrentRate();
    }
}
