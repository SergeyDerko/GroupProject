using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWcfSite.Models.AnastasiaNepomiluyev
{
    public class TimeOfDayClient
    {
        public virtual string TimeOfDay { get; set; }

        public void SetTimeOfDay()
        {
            TimeOfDay = "Hello World!";
        }
    }
}