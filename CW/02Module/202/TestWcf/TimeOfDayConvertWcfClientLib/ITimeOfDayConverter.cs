using System;

namespace TimeOfDayConvertWcfClientLib
{
    interface ITimeOfDayConverter
    {
        string ConvertDateToTimeOfDay(DateTime currentDate);
    }
}
