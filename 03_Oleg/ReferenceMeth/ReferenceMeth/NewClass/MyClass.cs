using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferenceMeth.NewClass
{
    class MyClass
    {
        // В классе методы SameAs() и Copy()
        int alpha, beta;

        public MyClass (int i, int j)
        {
            alpha = i;
            beta = j;
        }
        // Возратить значение  true, если параметр ob
        // имеет те же значения, что и вызывающий объект.
        public bool SameAs(MyClass ob) // обращение в методу имеет вид: ob2.SameAs(ob1) 
        { // Сравнивает 
            if ((ob.alpha == alpha) & (ob.beta == beta)) // в ob.alpha и ob.beta -
            { // - храяится значения объекта ob1, a в переменных alpha и beta  -
                return true; // - хранятся значения объекта ob2 соотвественно
            } // Почему так? Все очень просто в метод принимает входяший аргумент аргумент -
            else // - в данном случае это поля объекта ob1 так как ob2.SameAs(ob1)
            {
                return false;
            }
        }

        // Сделать копию объекта ob.
        public void Copy(MyClass ob) // обращение в методу имеет вид: ob1.Copy(ob2)
        {
            alpha = ob.alpha; // так как в данном методе ob.alpha и ob.beta хранят значения -
            beta = ob.beta; // объекта ob2, а alpha и beta хранят значения объетка -
        } // - ob1, то получим путем присваения новые значения объекта ob1

        public void Show() // данный метод просто вывод значения 
        {
            Console.WriteLine("alpha: {0}, beta: {1}", alpha, beta);
        }
    }
}
