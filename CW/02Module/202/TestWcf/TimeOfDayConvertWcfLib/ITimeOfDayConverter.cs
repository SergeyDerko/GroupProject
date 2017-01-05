using System;
using System.ServiceModel;

namespace TimeOfDayConvertWcfLib
{
    [ServiceContract]
    interface ITimeOfDayConverter
    {
        [OperationContract]
        string ConvertDateToTimeOfDay(DateTime currentDate);
    }
}
