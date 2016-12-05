using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayInMeth.File
{
    class Exam
    {
        // Проверка что ж такого вели
        // Хитрый метод принимает значение после чего возращает значение + ответ (правда/лож) на вопрос -
        // - можно ли преобразовать в целочисленное значение наше число
        public bool TryThis (string experimental, out int NewNumber)
        { 
            bool res = Int32.TryParse(experimental, out NewNumber);
            if (res)
            {
                return res;
            }
            else
            {
                return !res;
            }
        }
    }
}
