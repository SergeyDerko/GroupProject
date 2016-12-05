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
        // Приложение выводит объект с двумя значениями, с каждой итерации у объекта будут новые значения  
        static void Main(string[] args)
        {                                           // в методе Main() получется экземпляр объекта класса MyClass 
            MyClass ob = new MyClass();             // наш объект 
            int i, j;                               // перменные для цикла

            // Сформируем объекты, используя фабрику класса.
            for (i =0, j =10; i <10; i++, j--) 
            {                                       // "фабричный" метод Factory() используется в цикле for для создания десяти других объектов 
                MyClass NewObj = ob.Factory(i, j);  // создать объект которы ссылается на объект -
                NewObj.Show();                      // - формируемый фабрикой класса
            }                                       // На каждом шаге итерации цикла создается переменная ссылки на объект NewObj
            Console.ReadLine();
        }
    }
}
