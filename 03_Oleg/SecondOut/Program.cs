using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecondOut.Demo;

namespace SecondOut
{
    class Program
    { // Программа определяет общий множитель для двух челых чисел и  находит
      // найменьший и найбольгший множитель для этих двух чисел если такой есть
        static void Main(string[] args)
        {
            int fN, sN, lcf, gcf;
            bool firstNum, secondNum;
            do
            {
                Console.WriteLine("Введите любое значение от 1 до 100"); // выводим
                firstNum = Int32.TryParse(Console.ReadLine(), out fN); // получаем
                Console.WriteLine("Введите второе любое значение от 1 до 100"); // выводим
                secondNum = Int32.TryParse(Console.ReadLine(), out sN); // получаем
            } while ((!firstNum) || (!secondNum) || (fN > 100) || (fN < 1) ||
                (sN > 100) || (sN < 1)); // проверям на корявость данных
            Outers us = new Outers(); // если все ок объявляем объект us типа Outers
            if (us.HasComFactor(fN, sN, out lcf, out gcf)) // гоним все это в метод HasComFactor
            { // если все норм получим результат ввиде вдух строк: 
                Console.WriteLine("Найменьший общий множитель {0} " + 
                    "чисела {1} и {2}", lcf, fN, sN);
                Console.WriteLine("Найболшьший общий множитель {0} " +
                    "чисела {1} и {2}", gcf, fN, sN);
            }
            else // если соотвествий нет :( 
            {
                Console.WriteLine("Общего множителя нет! :(");
            }
            Console.ReadLine(); // пауза
        }
    }
}
