using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueRef.Test
{
    class CallByRef
    {
        public int a, b;

        public CallByRef(int i, int j) // конструктор
        {
            a = i;
            b = j;
        }
        /* Передать объект. Теперь переменные oc.a и oc.b из объекта, 
         * используемого в вызове метода, будут изменены. */
        public void Change (CallByRef oc)
        {
            oc.a = oc.a + oc.b;
            oc.b = -oc.b;
        }
    }
}
