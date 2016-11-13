using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceMeth.NewClass
{
    class MyClass
    {
        int alpha, beta;

        public MyClass (int i, int j)
        {
            alpha = i;
            beta = j;
        }
        // Возратить значение  true, если параметр ob
        // имеет те же значения, что и вызывающий объект.
        public bool SameAs(MyClass ob)
        {
            if ((ob.alpha == alpha) & (ob.beta == beta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Сделать копию объекта ob.
        public void Copy (MyClass ob)
        {
            alpha = ob.alpha;
            beta = ob.beta;
        }

        public void Show()
        {
            Console.WriteLine("alpha: {0}, beta: {1}", alpha, beta);
        }
    }
}
