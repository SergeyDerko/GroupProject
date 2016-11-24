﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stacker.Model; // не забываем добавить папку с классом (для работы с ним)

namespace Stacker
{
    // Мы имеем множиство методов в классе Stack для реализаций коректной работы 
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
            for (i = 0; !stk1.IsFull(); i++) // цикл нужен для заполнения стека stk в классе Stack
            { // В stk1.IsFull() будем выполнять просто проверку на заполнение stk1, как заполним получим true 
                stk1.Push((char)('A' + i)); // каждый новы елемент стека получит - 
            }  // - новое значение для этого нам поможет метод Push в классе Stack
            
            if (stk1.IsFull()) // когда цикл прекратит итерации, просто выведим на -
            { // - на консоль сообщение! 
                Console.WriteLine("Стек stk1 заполнен."); // собстрвено вот такое сообщнеие 
            }
            Console.WriteLine("Количество объектов в стетке str1: " + stk1.GetNum());

            // Вывести содержимое стека stkl.
            Console.Write("Содержимое стека stk1: ");
            while ( !stk1.IsEmpty()) // еще один цикл для проверки и вывода на -
            { // - консоль всех елементов стека 
                ch = stk1.Pop(); // данны  метод позволяет извлечь елемент из стека -
                Console.Write(ch); // - по индексу, а потом вывести его на консоль 
            }
            Console.WriteLine(); // смещение на строку вниз в консоли
            Console.WriteLine("Элементы выгружены! " + 
                "Количество объектов в стетке str1: " + stk1.GetNum());

            Console.WriteLine(); // смещение на строку вниз в консоли 
            // индекс последнего выведенного елемента стека будет равен нулю  
            if (stk1.IsEmpty()) // после чего приложение выведит сообщение 
            {
                Console.WriteLine("Стек stk1 пуст.\n"); // вывод сообщения
            }
            // Поместить дополнительные символы в стек stk1.
            Console.WriteLine("Вновь поместить символы A-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++) // происходя те же действия что и в первом цикле 
            {
                stk1.Push((char)('A' + i));
            }
            // А теперь извлечь элементы из стека stk1 и поместить их в стек stk2.
            // В итоге элементы сохраняются в стеке stk2 в обратном порядке.
            Console.WriteLine("А теперь извлечь символы из стека stk1\n" + 
                               "и помесить их в стек stk2.");
            while ( !stk1.IsEmpty()) // В предидущий раз мы использовали похожый - 
            { // - цикл для вывода все элементов стека, тут используем цикл для
                ch = stk1.Pop(); // переприсвоения элементов из stk1 в stk1
                stk2.Push(ch); // как буфер будем использовать переменную ch
            } // только наоборот последний элемнт в stk1 это будет первый в stk2
            Console.WriteLine("Количество объектов в стетке str2: " + stk2.GetNum());

            Console.Write("Содержимое стека stk2: "); // похожый цикл
            while( !stk2.IsEmpty())  // только тут будем уже выводить в 
            { // консоль элементы stk2
                ch = stk2.Pop(); // проход по элементам стека
                Console.Write(ch); // вывод на консоль
            }
            Console.WriteLine(); // смещение на строку вниз в консоли
            Console.WriteLine("Элементы выгружены! " +
                "Количество объектов в стетке str2: " + stk2.GetNum());
            Console.WriteLine(); // смещение на строку вниз в консоли
            if (stk2.IsEmpty()) // после чего приложение выведит сообщение 
            {
                Console.WriteLine("Стек stk2 пуст.\n"); // вывод сообщения
            }
             
            // Поместить 5 символов в стек.
            Console.WriteLine("Поместить 5 символов в стек stk3."); 
            for (i = 0; i < (stk3.Capacity())/2; i++) // помещять будем элементы -
                stk3.Push((char) ('A' + i)); // уже через цикл for, но не 10, а только 5
            Console.WriteLine("Емкость стека stk3: " + stk3.Capacity()); // из-за '/2'
            Console.WriteLine("Количество объектов в стетке str3: " + stk3.GetNum());

            Console.ReadKey();
            // вроде описал все, что мог
        }
    }
}