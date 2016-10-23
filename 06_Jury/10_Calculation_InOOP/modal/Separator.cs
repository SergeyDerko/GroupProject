using System;
using System.Text;

namespace _10_Calculation_InOOP.modal
{
    internal class Separator
    {
        private string Str { get; set; }
        public Separator(string x)
        {
            Str = x;
            Console.WriteLine(new string('-', 30) + "\n Сначала выполняем по порядку(слева направо) умножение и деление:\n");
            while (MultiplicationFinder(Str) != DivisionFinder(Str))
            {
                if (MultiplicationFinder(Str) < DivisionFinder(Str))
                {
                    var index = MultiplicationFinder(Str);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, Str, "*");

                }
                else
                {
                    var index = DivisionFinder(Str);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, Str, "/");
                }
            }
            Console.WriteLine("\n Выполняем по порядку(слева направо) сложение и вычитание:\n");
            while (AdditionFinder(Str) != SubtractionFinder(Str))
            {
                if (AdditionFinder(Str) < SubtractionFinder(Str))
                {
                    var index = AdditionFinder(Str);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, Str, "+");
                }
                else
                {
                    var index = SubtractionFinder(Str);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, Str, "-");
                }
            }

        }

        

        private int RightNumber(int index)
        {
            var indexRight = index + 1;
            for (var i = indexRight; i < Str.Length; i++)
            {
                if (char.IsDigit(Str[i]))
                {
                    indexRight = i;
                }
                else
                {
                    indexRight = i - 1; break;
                }
            }
            var rightNumber = int.Parse(Str.Substring(index + 1, indexRight - index));
            return rightNumber;
        }

        private int LeftNumber(int index)
        {
            var indexLeft = index - 1;
            for (var i = indexLeft; i >= 0; i--)
            {
                if (char.IsDigit(Str[i]))
                {
                    indexLeft = i;
                }
                else
                {
                    indexLeft = i + 1; break;
                }
            }
            var leftNumber = int.Parse(Str.Substring(indexLeft, index - indexLeft));
            return leftNumber;
        }
        private void ToCalculation(int leftNumber, int rightNumber, string x, string operation)
        {
            Str = x;
            var result = new Calculation(leftNumber, rightNumber, operation);
            //Заменяем 
            var newstr = new StringBuilder(Str);
            newstr.Replace(leftNumber + operation + rightNumber, result.Result.ToString());
            Str = newstr.ToString();
            Console.WriteLine($" {leftNumber}{operation}{rightNumber}={result.Result} --> {Str}");
        }
        private static int MultiplicationFinder(string x)
        {
            var index = x.IndexOf("*", StringComparison.Ordinal);
            return Verifyindex(x, index);
        }
        private static int DivisionFinder(string x)
        {
            var index = x.IndexOf("/", StringComparison.Ordinal);
            return Verifyindex(x, index);
        }
        private static int AdditionFinder(string x)
        {
            var index = x.IndexOf("+", StringComparison.Ordinal);
            return Verifyindex(x, index);
        }
        private static int SubtractionFinder(string x)
        {
            var index = x.IndexOf("-", StringComparison.Ordinal);
            return Verifyindex(x, index);
        }
        private static int Verifyindex(string x, int index)
        {
            if (index == -1 || index == 0)
            {
                return x.Length + 1;
            }
            return index;
        }
        public string WriteOutSeparator()
        {
            return $"{Str}";
        }

    }
}
