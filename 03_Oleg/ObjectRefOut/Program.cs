using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectRefOut.Objecter;

namespace ObjectRefOut
{
    class Program
    {
        // Приложение где изменяем в методе объект, на который указывает ссылка.
        // Ссылочные параметры типа ref служат для смены объектов, на которые указывают ссылки
        // Не спрашивайте сам не пойму что написано! :( 
        static void Main(string[] args)
        {
            RefSwap x = new RefSwap(1, 2); // создали объект x c значениями 1, 2
            RefSwap y = new RefSwap(3, 4); // создали объект y c значениями 1, 2

            Console.Write("x before call: ");
            x.Show(); // вывели зачения объекта x

            Console.Write("y before call: ");
            y.Show(); // вывели зачения объекта y

            Console.WriteLine(); // отступ (переход на новую строку)

            // Смена объектов, на которые ссылаются аргументы x и y.
            x.Swap(ref x, ref y); 

            Console.Write("x after call method Swap in class RefSwap: ");
            x.Show();

            Console.Write("y after call method Swap in class RefSwap: ");
            y.Show();

            Console.ReadLine();
        }
    }
}
