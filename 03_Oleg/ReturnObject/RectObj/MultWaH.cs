using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReturnObject.RectObj
{
    // Возратить объект из метода
    class MultWaH
    {
        int windth; // поля нам нужны для хранения значений класса
        int heigth; // в классе имеем два поля типа integer (целочисленые) 

        public MultWaH(int w, int h) // конструктор где w и h входящие аргументы
        {
            windth = w; // поля примут значения от входящих аргументов w и h
            heigth = h; 
        }

        public int Area() // полученые значения переумножим 
        { // что даст нам площадь прямоугольника(
            return windth * heigth;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1}", windth, heigth);
        }
        // Метод возращает значения (размер) прямоугольника со стороннами, пропорционально -
        // - увеличенными на указанный коэфициент по сравнению с вызывающим -
        // - объектом прямоугольника.
        public MultWaH Nobel (int factor) // вот такой не обычный метод
        { // вообще очень интирестный код у нас тут вроде как конструктор, но еще - 
            return new MultWaH(windth * factor, heigth * factor); // - метод Nobel -
        } // который менят все красоту нашего класса на новые значения полей класса MultWaH
    }
}
