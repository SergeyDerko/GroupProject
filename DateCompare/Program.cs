using System;

namespace DateCompare
{
    class Program
    {
        static void Main()
        {
            var dateTime1 = new DateTime();
            var dateTime2 = DateTime.MinValue;
            var dateTime3 = DateTime.MaxValue;
            var dateTime4 = DateTime.Now;
            var dateTime5 = dateTime4.AddMonths(-1).AddDays(-1).AddDays(4);
            if (dateTime1 < dateTime2)
            {

            }
            else if (dateTime1 == dateTime2)
            {

            }
            if (dateTime1.Equals(dateTime2))
            {

            }
        }
    }
}
