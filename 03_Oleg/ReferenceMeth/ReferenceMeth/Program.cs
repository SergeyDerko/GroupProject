using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReferenceMeth.NewClass;

namespace ReferenceMeth
{
    // простая программа сравнивает значие двух объкетов, потом один из объектов -
    // скопирует значения друго и снова сравниваем их значения!
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob1 = new MyClass(4, 5); // 4 - alpha, 5 - beta
            MyClass ob2 = new MyClass(6, 7); // 6 - alpha, 7 - beta

            Console.Write("ob1: "); // вывод значений объекта ob1:
            ob1.Show(); // используя метод Show() класса MyClass

            Console.Write("ob2: "); // вывод значений объекта ob2:
            ob2.Show(); // используя метод Show() класса MyClass

            // В методе SameAs сравниваются переменные во вызывающем объекте с -
            if (ob2.SameAs(ob1)) // значениями другого объекта передаваемом - 
            {  // - посредством параметра ob
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

            // И снова сравним объект 
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
