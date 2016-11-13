using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReferenceMeth.NewClass;

namespace ReferenceMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(4, 5);
            MyClass ob2 = new MyClass(6, 7);

            Console.Write("ob: ");
            ob1.Show();

            Console.Write("ob: ");
            ob2.Show();

            if (ob1.SameAs(ob2))
            {
                Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
            }
            else
            {
                Console.WriteLine("ob1 и ob2 имеют разные значения.");
            }

            Console.WriteLine();

            // А теперь сделать объект ob1 копией объекта ob2.
            ob1.Copy(ob2);

            Console.Write("ob1 после копирования: ");
            ob1.Show();

            if(ob1.SameAs(ob2))
            {
                Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
            }
            else
            {
                Console.WriteLine("ob1 и ob2 имеют разные значения.");
            }
            Console.ReadLine();
        }
    }
}
