using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacker.Model
{
    class Stack
    {
        // Эти члены класса являются закрытыми для соблюдения принцыпа 'последним пришел - первым вышел' 
        char[] stck; // поумолчанию закрытый массив 
        int tos;     // индекс вершины индекса

        // Построить пустой класс Stack для реализации стека заданного размера.
        public Stack(int size) // Конструктор класса Stack
        { // Конструктору передается требуемый размер (аргумент size) стека  
            stck = new char[size]; // распределяет память для стека
            tos = 0 ; // нулевое значение переменной tos указывает на то, что стек пуст
        }

        // Посметить символы в стек 
        public void Push(char ch) // Открытый (Public) меод Push помещает конректный элемент в стек 
        {
            if (tos == stck.Length) // проверка на наличие своболдного места в массиве stck
            {
                Console.WriteLine(" - стек заполнен."); // если массив заполнен 
                return;
            }
            stck[tos] = ch; /* массив не заполнен, то элемент сохраняется по индексу tos + 1 
            то есть чледующий элемнт массива stck */
            tos++; // аналог tos + 1 "инкремент"
        }

        // Извлечь символ из стека.
        public char Pop() 
        {
            if (tos == 0) 
            {
                Console.WriteLine(" - стек пуст.");
                return (char)0;
            }
            tos--; // аналог tos - 1 "декремент"
            return stck[tos]; /* после декрементирования переменной tos данное значение 
             указывается как индекс элемнта массива для извлечения контректого элемента*/ 
        }

        // возратить значение true, если стек заполнен иначе false.
        public bool IsFull()
        {
            return tos == stck.Length; 
        }

        // возратить значение true, если стек пуст иначе false.
        public bool IsEmpty()
        {
            return tos == 0;
        }

        // Возращать общию емкость стека в настоящий момент
        public int Capacity()
        {
            return stck.Length;
        }

        // Возращает количесвто объектов, находящихся в данный момент в стеке.
        public int GetNum()
        {
            return tos;
        }
    }
}
