using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOfDayConvertWcfClientLib
{
    public class TimeOfDayConvert: ITimeOfDayConverter
    {
        public string ConvertDateToTimeOfDay(DateTime currentDate)
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
