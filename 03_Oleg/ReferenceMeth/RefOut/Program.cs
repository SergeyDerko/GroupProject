using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RefOut.File;

namespace RefOut
{
    class Program
    {
        // Использование модификаторов ref. 
        // Модификатор параметра ref принудительно организует вызов по ссылке 
        // ref надо указывать в методе и при вызове метода
        static void Main(string[] args)
        {
            RefTest bb = new RefTest(); // объявление объекта bb типа RefTest (класс)
            ValueSwapDemo bd = new ValueSwapDemo(); // объявление объекта bd -
            // - типа ValueSwapDemo (класс)
            int test = 10; // инициализация переменной test типа int
            Console.WriteLine("keyword 'test' before call method Sqr: {0}", test);
            // Используем модификарот ref при вызове метода 'Sqr'
            bb.Sqr(ref test); // ref указывается паред аргументом при вызове метода
            // объект bb имеет метод Sqr который получит ввыде вхоядящего аргумента -
            // - значение перменной test.
            Console.WriteLine("keyword 'test' after call method Sqr: {0}\n", test);
            int x = 10, y = 20; // инициализация переменных x и y типа int.
            Console.WriteLine("x and y before call method Swap: {0} {1}", x, y);
            bd.Swap(ref x, ref y);
            Console.WriteLine("x and y after call metjod Swap: {0} {1}", x, y);
            // Аргументу передаваемому по сслыке должно быть присвоено значение до -
            // вызова метода.
            Console.ReadLine();
        }
    }
}
