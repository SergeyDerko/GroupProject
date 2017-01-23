using System;
using TestWcfCommon;
namespace TimeOfDayConvertWcfLib
{
    public class TimeOfDayConvert: ITimeOfDayConverter
    {
        public string ConvertDateToTimeOfDay(DateTime currentDate)
        {
            Logger.Enter("Enter to ConvertDateToTimeOfDay");
            string value = CurrentStateOfTimeOfDay(currentDate);
            Logger.Info(String.Format("Return value:{0}", value));
            Logger.Leave("Leave from ConvertDateToTimeOfDay");
            return value;
        }

        private string CurrentStateOfTimeOfDay(DateTime currentDate)
        {
            if (currentDate.Hour >= 4 && currentDate.Hour < 12)
                return "Good morning!";
            else if (currentDate.Hour >= 12 && currentDate.Hour < 18)
                return "Good day!";
            else if (currentDate.Hour >= 18 && currentDate.Hour < 24)
                return "Good evening!";
            else return "Good night!";
        }
    }
}
