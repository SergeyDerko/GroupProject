using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.File
{
    class Proverka
    {
        // Метод проверяет что ж такого ввел пользователь
        public bool Trenner(string inner, out double number)
        {
            bool result = Double.TryParse(inner, out number);
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
