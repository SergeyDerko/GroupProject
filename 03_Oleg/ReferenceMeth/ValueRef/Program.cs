using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ValueRef.Test;

namespace ValueRef
{
    // пример программы где передача аргументов обычных типов происходит по значению
    // и по ссылке
    class Program
    {
        static void Main(string[] args)
        {
            // Обращение к классу CallByValue передача аргумента по значению

            CallByValue ob = new CallByValue(); // Объявление объекта ob

            int a = 15, b = 20; // объявления двух переменных 

            Console.WriteLine("a and b before call: {0} {1}", a, b);

            ob.NoChange(a, b); // по значению в метод NoChange -
            // - передаем значения переменных a, b.
            Console.WriteLine("a and b after call method NoChange: {0} {1} - value!", a, b);
            Console.WriteLine("By value!");
            Console.ReadLine(); // наглядно показано что значения a, b
            // не изменились не смотря на использвание переменных в методе NoChange
            
            // Обращение к классу CallByRef передача аргумента по ссылке
            CallByRef oc = new CallByRef(a, b); // Объявляем объект oc, так как -
            // - у нас в классе есть конструктор можем сразу передавать значения
            Console.WriteLine("oc.a and oc.b before call: {0} {1}", oc.a, oc.b);

            oc.Change(oc); // по ссылке перeдаем значению в метод Change -
            // - передаем значения переменных a, b.

            Console.WriteLine("oc.a and oc.b after after call: {0} {1}", oc.a, oc.b);
            Console.WriteLine("By reference!");
            Console.ReadLine(); // наглядно показано что значения a, b
            // изменились после использования метода Change
        }
    }
}
