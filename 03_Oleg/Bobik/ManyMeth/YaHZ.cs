using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bobik.ManyMeth
{
    class YaHZ
    {
        // Метод проверяет 
        public bool Trenner (string inner, out int number)
        {
            bool result = Int32.TryParse(inner, out number);
            if (result)
            {
                return result;
            }
            else
            {
                return !result;
            }
        }
    }
}
