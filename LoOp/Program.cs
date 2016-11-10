using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoOp
{
    class Program
    {
        static void Main(string[] args)
        {
            // прога которая рисует пустой прямоугольник 0_0 - наконец, без цикла for
            int numberLeght, numberHeight; // переменые для проверки что у нас в ReadLine
            bool resultLeght = false, resultHeight = false, chose = false; // используем для TryParse и условия для цикла do/while   
            do // долгожданный цикл, один раз он точно выполнится, а дальше все зависит от переменной chose
            {
                Console.Write("Enter height  (max number 50): "); // вывод, скорее для красоты и понимания что тут вообще делаем 
                resultHeight = Int32.TryParse(Console.ReadLine(), out numberLeght); // проверка на ровность рук пользователя и задания длины прямоугольника
                Console.Write("Enter lenght (max number 30): "); // еще раз спросим, у великого пользователя, но уже высоту
                resultLeght = Int32.TryParse(Console.ReadLine(), out numberHeight); // хай воодит уже высоту прямоуголника
                if (!(resultHeight && resultLeght) || !((numberHeight <= 50) && (numberLeght <= 30))) // не пробуйте понять самому страшно (глаза боятся руки строчат) 
                {
                    chose = true; // у нашего пользователя руки крюки :(
                }
                else // ура вроде все пока норм прога должна работать!!!
                { 
                    int i = 0; // так как у нас все не через Ж ой не for будет создавать отдельно переменную для цикла
                    Console.WriteLine("\t"); // просто для четабельности в консоли вывода
                    while (i <= numberHeight) // вот и цикл для количества сток не длины, а именно количества
                    {
                        int k = 0; // еще раз: "я у мамы инжЕнеР"
                        while (k <= numberLeght + 1) // цикл для длины строк. Каждой а их у нас аж numberLeght
                        {
                            if (i == 0 || i == numberHeight) // условие
                            {
                                if (k == 0 || k == numberLeght + 1)
                                {
                                    Console.Write("I");
                                }
                                else
                                {
                                    Console.Write("=");
                                }
                            }
                            else
                            {
                                if (k == 0 || k == numberLeght + 1)
                                {
                                    Console.Write("I");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            } k++;
                        } i++;
                        Console.WriteLine();
                     }        
                }
            } while (chose);
            Console.ReadLine();
        }
    }
}
