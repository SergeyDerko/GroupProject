using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FabricClass.Demony;

namespace FabricClass
{
    class Program
    {
        // Пример использования фабрики класса, предназначен для построения объектов его же класса 
        static void Main(string[] args)
        { // в методе Main() получется экземпляр объекта класса MyClass 
            MyClass ob = new MyClass(); // наш объект 
            int i, j; // перменные для цикла

            // Сформировать объекты, используя фабрику класса.
            for (i =0, j =10; i <10; i++, j--) 
            { // фабричный метод Factory() используется в цикле for для создания десяти других объектов 
                MyClass NewObj = ob.Factory(i, j); // создать объект в котором задаются значения
                NewObj.Show(); // выводим значения на консоль
            }
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
