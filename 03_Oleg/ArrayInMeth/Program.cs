using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArrayInMeth.File;

namespace ArrayInMeth
{
    class Program
    {
        // В C# все массивы реализованы как объекты!
        // Приложение принимает значение и находит все множители введеного числа
        static void Main(string[] args)
        {
            int commonNumberOfclass, hands;                             // переменная в которой будет хранится значение 
            bool ans;                                                   // переменые типа bool 
            int[] arrays;                                               // объявление массива, элементы массива будут типа integer
            do                                                          // в теле цикла пердлагается пользователю ввести значение -
            {                                                           // - данное значение проверяет на корректность ввода и выводтсяя результат проверки
                Exam chose = new Exam();                                // цикл будет выполнятся пока пользователь - 
                Console.WriteLine("Enter any number of 4 to 1000 ");    // - не введет числовое значение от 4 д 1000
                ans = chose.TryThis(Console.ReadLine(), out hands);     // Проверка значения будет произведена в классе Exam 
            } while (!ans || (hands < 4) || (hands > 1000));            // условие цикла: цикл будет повторно выполнятся пока одно из условий будет true 
            ObjectArrayInMeth ar = new ObjectArrayInMeth();             // Объект ar класса ObjectArrayInMeth в данном классе только один метод
            arrays = ar.ReturnArray(hands, out commonNumberOfclass);    // массив будет состоять из элементов (множителец) которые будут -
                                                                        // - определены в методе ReturnArray класса ObjectArrayInMeth
            Console.WriteLine("Множители числа {0}: ", hands);          // вывод значения котрое ввел пользователь
            for (int i = 0; i < commonNumberOfclass; i++)               // цикл для вывода всех элементов массива
            {
                Console.Write("{0} ", arrays[i]);                       
            }
            if (commonNumberOfclass == 0)                               // если таких элементов (множителей) нет, выполнится условие (commonNumberOfclass == 0)
            {                                                           // Получит сообщение, что данное значение целочисленых множителей не содержит 
                Console.WriteLine("The number {0} does not have factor!", hands); 
            }                                                           
            Console.ReadLine();
        }
    }
}
