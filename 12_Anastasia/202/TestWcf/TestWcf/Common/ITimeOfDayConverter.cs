using System;

namespace Common
{
    public interface ITimeOfDayConverter
    {
        string ConvertDateToTimeOfDay(DateTime date);
    }
}