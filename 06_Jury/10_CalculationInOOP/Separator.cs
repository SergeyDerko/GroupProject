using System;
using System.Text;


namespace lesson11
{
    internal class Separator
    {
        private readonly string _str;
        public Separator(string x)
        {
            _str = x;
            while (OperatorFainder(_str) != -1)//Поиск арифметического знака
            {
                var index = OperatorFainder(_str);
                //Число слева от знака
                var leftNumber = LeftNumber(index);
                //Число справа от знака
                var rightNumber = RightNumber(index);
                //Считаем результат операции
                var multiplication = new Calculation(leftNumber, rightNumber, "*");
                //Заменяем 
                var newstr = new StringBuilder(_str);
                newstr.Replace(leftNumber + "*" + rightNumber, multiplication.Result.ToString());
                _str = newstr.ToString();
                Console.WriteLine(_str);
            }
           


            while (OperatorFainder2(_str) != -1)//Поиск арифметического знака
            {
                var index = OperatorFainder2(_str);
                //Число слева от знака
                var leftNumber = LeftNumber(index);
                //Число справа от знака
                var rightNumber = RightNumber(index);
                //Считаем результат операции
                var multiplication = new Calculation(leftNumber, rightNumber, "+");
                //Заменяем 
                var newstr = new StringBuilder(_str);
                newstr.Replace(leftNumber + "+" + rightNumber, multiplication.Result.ToString());
                _str = newstr.ToString();
                Console.WriteLine(_str);
            }

           
        }

        private int RightNumber(int index)
        {
            var indexRight = index + 1;
            for (var i = indexRight; i < _str.Length; i++)
            {
                if (char.IsDigit(_str[i]))
                {
                    indexRight = i;
                }
                else
                {
                    indexRight = i - 1; break;
                }
            }
            var rightNumber = int.Parse(_str.Substring(index + 1, indexRight - index));
            return rightNumber;
        }

        private int LeftNumber(int index)
        {
            var indexLeft = index - 1;
            for (var i = indexLeft; i >= 0; i--)
            {
                if (char.IsDigit(_str[i]))
                {
                    indexLeft = i;
                }
                else
                {
                    indexLeft = i + 1; break;
                }
            }
            var leftNumber = int.Parse(_str.Substring(indexLeft, index - indexLeft));
            return leftNumber;
        }

        public void ShowSeparate()
        {
            Console.WriteLine($"Промежуточный результат: {_str}");
        }
        public string WriteOutSeparator()
        {
            return $"{_str}";
        }

        private static int OperatorFainder(string str)
        {
            var index = str.IndexOf("*", StringComparison.Ordinal);
            return index;
        }
        private static int OperatorFainder2(string str)
        {
            var index = str.IndexOf("+", StringComparison.Ordinal);
            return index;
        }
        

    }
}
