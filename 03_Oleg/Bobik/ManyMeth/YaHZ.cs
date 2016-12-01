using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bobik.ManyMeth
{
    class YaHZ
    {
        // Метод проверяет что ж такого ввел пользователь
        public bool Trenner (string inner, out int number)
        {
            bool result = Int32.TryParse(inner, out number);
            if (result)
            {
                return result; // Если пользователь ввел целочисленное значение
            }                  // result = true
            else
            {
                return !result; // Если пользователь ввел не целочисленное значение
            }                   // result = false
        }
    }
}
