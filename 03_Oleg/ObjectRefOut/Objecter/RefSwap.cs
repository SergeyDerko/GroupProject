using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectRefOut.Objecter
{
    class RefSwap
    {
        int a, b; // поля       

        public RefSwap(int i, int j) // конструктор
        {
            a = i;
            b = j;
        }
        public void Show() // метод вывода
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }
        // Метод изменяет свои аргументы
        public void Swap(ref RefSwap ob1, ref RefSwap ob2) // метод, RefSwap нужен так как аргумент у нас объект
        { // Выполняется смена объектов, на которые ссылаются два аргумента -
            RefSwap t; // - аргумент x ссылается на объект, содержащий значениея 1 и 2 -
            // - аргумент y ссылается на объект, содержащий значениея 3 и 4 соответствено -
            t = ob1; // - в методе Swap аргумент x будет ссылатся на объетк с значениями 3 и 4 -
            ob1 = ob2; // - в методе Swap аргумент y будет ссылатся на объетк с значениями 1 и 2 
            ob2 = t; // и да это объект t тоже содержит значения a и b  
        }
    }
}
