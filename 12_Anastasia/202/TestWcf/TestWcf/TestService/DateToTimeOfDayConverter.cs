using System;
using System.Diagnostics;
using Common;

namespace TestService
{
    public class DateToTimeOfDayConverter : ITimeOfDayConverter
    {
        public string ConvertDateToTimeOfDay(DateTime date)
        {
            if (date.Hour >= 4 && date.Hour < 12)
                return "Good morning!";
            else if (date.Hour >= 12 && date.Hour < 18)
                return "Good day!";
            else if (date.Hour >= 18 && date.Hour < 24)
                return "Good evening!";
            else return "Good night!";

        }
    }
}