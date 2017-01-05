using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesServiceLib
{
    [ServiceContract]
    interface IExchangeRates
    {
        decimal Usd { get; set; }
        decimal Eur { get; set; }
        [OperationContract]
        string Value();
    }
}
