using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWcfSite.Models.DanilaModels
{
    public static class ExpressionD
    {
        public static int A { get; set; }
        public static int B { get; set; }
       
        public static int Result()
        {
            return 2 * 2;
        }
    }
}