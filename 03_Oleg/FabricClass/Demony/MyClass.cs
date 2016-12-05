using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FabricClass.Demony
{
    class MyClass
    {
        int a, b; // перменные класса по умолчанию закрытие

        public MyClass Factory (int i, int j)
        {                               // конструктор вызываемый по умолчанию. В фарбрике класса Factory(), создаем объект -
            MyClass obj = new MyClass();// - obj в котором задаются значения переменных a и b
                                        // так как переменные закрытие, значения могут быть заданы только с помощью фабрики -  
            obj.a = i;                  // - класса Factory()
            obj.b = j;

            return obj;                 // вернет объект с значения переменных a и b
        }
        public void Show()              // метод выводит значения полей (перменных)  a и b
        {
            Console.WriteLine("a и b: {0} {1}", a, b);
        }
    }
}
