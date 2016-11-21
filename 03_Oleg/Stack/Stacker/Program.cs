using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stacker.Model; // не забываем добавить папку с классом (для работы с ним)

namespace Stacker
{
    // Приложение где создается класс Stack и реализуется функционал стека 
    // как область памяти ПК
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk1 = new Stack(10); // Объект stk1 принимает значение 10 размер массива
            Stack stk2 = new Stack(10); // Объект stk2 принимает значение 10 размер массива
            Stack stk3 = new Stack(10); // Объект stk3 принимает значение 10 размер массива
            char ch;
            int i;

            Console.WriteLine("Поместить символы A-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
            {
                stk1.Push((char)('A' + i));
            }
            if (stk1.IsFull())
            {
                Console.WriteLine("Стек stk1 заполнен.");
            }

            //Вывести содержимое стека stkl.
            Console.Write("Содержимое стека stk1: ");
            while ( !stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }

            Console.WriteLine();

            if (stk1.IsEmpty())
            {
                Console.WriteLine("Стек stk1 пуст.\n");
            }
            // Поместить дополнительные символы в стек stk1.
            Console.WriteLine("Вновь поместить символы A-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
            {
                stk1.Push((char)('A' + i));
            }
            // А теперь извлечь элементы из стека stk1 и поместить их в стек stk2.
            // В итоге элементы сохраняются в стеке stk2 в обратном порядке.
            Console.WriteLine("А теперь извлечь символы из стека stk1\n" + 
                               "и помесить их в стек stk2.");
            while ( !stk1.IsEmpty())
            {
                ch = stk1.Pop();
                stk2.Push(ch);
            }
            Console.Write("Содержимое стека stk2: ");
            while( !stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }

            Console.WriteLine("\n");

            // Поместить 5 символов в стек.
            Console.WriteLine("Поместить 5 символов в стек stk3.");
            for (i = 0; i < 5 ; i++)
                stk3.Push((char) ('A' + i));
            Console.WriteLine("Емкость стека stk3: " + stk3.Capacity());
            Console.WriteLine("Количество объектов в стетке str3: " + stk3.GetNum());

            Console.ReadKey();
        }
    }
}
