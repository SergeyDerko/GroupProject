using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    class Separator
    {
        private readonly string str;
        public Separator(string x)
        {
            str = x;
            while (OperatorFainder(str) != -1)//Поиск арифметического знака
            {
                var index = OperatorFainder(str);
                var indexRight = index + 1;
                var indexLeft = index - 1;
                //Число слева от знака
                var leftNumber = LeftNumber(index, ref indexLeft);
                //Число справа от знака
                var rightNumber = RightNumber(index, ref indexRight);
                //Считаем результат операции
                var multiplication = new Calculation(leftNumber, rightNumber, '*');
                //Заменяем 
                var newstr = new StringBuilder(str);
                newstr.Replace(leftNumber + "*" + rightNumber, multiplication.Result.ToString());
                str = newstr.ToString();

            }

        }

        private int RightNumber(int index, ref int indexRight)
        {
            for (var i = indexRight; i < str.Length; i++)
            {
                if (char.IsDigit(str[i])) continue;
                else indexRight = i - 1; break;
            }
            var rightNumber = int.Parse(str.Substring(index + 1, indexRight - index));
            return rightNumber;
        }

        private int LeftNumber(int index, ref int indexLeft)
        {
            for (var i = indexLeft; i > 0; i--)
            {
                if (char.IsDigit(str[i])) continue;
                else indexLeft = i + 1; break;
            }
            var leftNumber = int.Parse(str.Substring(indexLeft, index - indexLeft));
            return leftNumber;
        }

        public void ShowSeparate()
        {
            Console.WriteLine($"Промежуточный результат: {str}");
        }
        public string WriteOutSeparator()
        {
            return $"Промежуточный результат: {str}";
        }



        private static int OperatorFainder(string str)
        {
            var index = str.IndexOf("*", StringComparison.Ordinal);
            return index;
        }



    }
}
