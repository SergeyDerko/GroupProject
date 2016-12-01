using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bobik.ManyMeth;

namespace Bobik
{
    class Program
    {
    // Приложение принимает от пользователя значения считает полощадь и объем параллелепипеда
        static void Main(string[] args)
        {
            int valueHeight, valueWidth, valueDepth, valueFour; // в переменных будут хранится значения - разметы сторон фигуры и коэффициент 
            bool choseOne, choseTwo, choseTree, choseFour; // будут хранится ответы на проверку корректность вводимых значений
            Console.WriteLine("Hello the human!\n" + // Вывод на консоль привествия приложения
            "This program calculat area of parallelepiped. Good luck"); // продолжение сообщения
            do // Это тока проверка на кривость рук пользователя 
            { // в цикле пользователь вводит значения. если хоть один из воодимых значений будет не правльным, цикл повторит проход 
                Console.WriteLine("Enter height number of 1 to 100: "); // спрашиваем у пользователя размер (высоту) фигуры
                YaHZ height = new YaHZ(); // предварительно мы создали класс YaHZ, объявим объект height типа YaHZ для дальнейшего использования     
                choseOne = height.Trenner(Console.ReadLine(), out valueHeight); // пользователь вводит значение если значение целочисленное на -
                // - выходе будет переменная choseOne = true и valueHeight типа int примет преобразованное значение котое было типа string 
                Console.WriteLine("Enter width number of 1 to 100: "); // спрашиваем у пользователя размер (ширину) фигуры
                YaHZ width = new YaHZ(); // объявим объект width типа YaHZ для дальнейшего использования
                choseTwo = width.Trenner(Console.ReadLine(), out valueWidth); // преобразовали ширину фигуры из типа string в тип integer
                Console.WriteLine("Enter depth number of 1 to 100: "); // спрашиваем у пользователя размер (глубину) фигуры
                YaHZ depth = new YaHZ(); // объявим объект depth типа YaHZ для дальнейшего использования
                choseTree = depth.Trenner(Console.ReadLine(), out valueDepth); // преобразовали глубину фигуры из типа string в тип integer 
            } // условиие цикла, если пользователь ввел не корректное одно из значений фигуры цикл повторится  
            while (!choseOne || (valueHeight < 1) || (valueHeight > 100) || !choseTwo || // условие цикла
                 (valueWidth < 1) || (valueWidth > 100) || !choseTree || (valueDepth < 1) || (valueDepth > 100));
            // И только после проверки будет написа код расчета нашего кубика 
            Calc obj = new Calc(valueHeight, valueWidth, valueDepth); // теперь все значения (размеры) фигуры отправим в класс Calc  
            obj.Show(); // после можно вывести расчет площади и объема фигуры
            do // что б жизнь скучно не казалась введем еще один подсчет 
            { // увеличивает нашу фигуру на коэффициент 
                Console.WriteLine("Now we can enter factor to uplift size cube!"); 
                Console.WriteLine("Enter factor of 2 to 10: "); // Сообщаем что надо ввести еще одно значение 
                YaHZ factor = new YaHZ(); // проверим введеное значение от пользователя "правильность"
                choseFour = factor.Trenner(Console.ReadLine(), out valueFour); // успешно посылаем значение на проверку, если все ок -
            }  // - будет у нас целочисленное значение 
            while (!choseFour || (valueFour < 1) || (valueFour > 10)); // еще одна проверка на кривость рук пользователя
            Calc NewSize = obj.More(valueFour); // объект NewSize типа Calc, объект примет значения объекта obj -
            Console.Write("You enter factor: {0}\t", valueFour); // - после чего метод More позвидет изминения значения, у фигуры будет новый размер
            NewSize.Show(); // вывод новой фигуры
            Console.ReadLine(); // пауза
        }
    }
}
