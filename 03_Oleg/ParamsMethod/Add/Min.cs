using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParamsMethod.Add
{
    class Min
    {
        public int MinVal (params int [] nums) //принимает значения из main метода и -
        { // - указываем его как элемнт массива (аргументы должны иметь тип массива
            int m; 
            if (nums.Length == 0) // проверка на наличие аргумента
            {
                Console.WriteLine("Error: null arguments."); // вывод сообщения если аргумент пуст
                return 0;
            }
            m = nums[0]; // первый елемнт массива будет присвоено переменной 'm'
            for (int i = 1; i < nums.Length; i++) // цикл нуже для прохода по всем элементам массива
            {
                if (nums[i] < m) // если элемент меньше предыдущего то -
                { // - будет выполнено тело: присвоение нового значения переменной m
                    m = nums[i]; // операция присвоение
                }
            }
            return m; // метод вернет значение m 
        }
    }
}
