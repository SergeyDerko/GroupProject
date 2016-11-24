using System;
using System.Threading;
using Point.RanPoint;

namespace Point
{
    class Program
    {
        // Приложение выводит на экран в случайном месте консоли символ
        static void Main(string[] args)
        {
            int number; // в переменной будет хранится количестов итераций 
            bool result; // проверка на правильность вводимых значений
            Random randX = new Random(); // случайное значение по осе Х (строка)
            Random randY = new Random(); // случайное значение по осе Y (столбец)
            do
            {
                Console.WriteLine("Enter count step (from 1 to 100): "); // вывод на консоль сообщения для пользователя 
                result = Int32.TryParse(Console.ReadLine(), out number); // получение значения от пользователя (количестов итераций) 
            } while (!result || (number>100) || (number<1)); // проверка на ввод значения для итераций 
            for (int i = 0; i <= number; i++) // цикл для выполнения итераций
            { // тело цикла, в конструкторе класса Demo 3 входящих аргумента
                Demo ob = new Demo(randX.Next(10), randY.Next(20), '*'); // объект ob
                ob.Show(); // в классе объекта есть метод Show
                Thread.Sleep(2000); // для нагялдность сделаем зарежку 
                Console.Clear(); // очистим консоль от уже выведенных точак
            }
                Console.ReadLine();
        }
    }
}
