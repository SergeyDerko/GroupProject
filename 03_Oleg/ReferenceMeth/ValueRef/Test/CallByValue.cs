using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueRef.Test
{
    class CallByValue
    {
        /* Этот метод не оказывает никакого влияния на
         * аргумент, используемые для его вызова */
        public void NoChange (int i, int j)
        {
            i = i + j;
            j = -j;
        }
    }
}
