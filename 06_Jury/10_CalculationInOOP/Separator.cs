using System;
using System.Text;


namespace lesson11
{
    internal class Separator
    {
        private string Str { get; set; }
        public Separator(string x)
        {
            Str = x;
            Console.WriteLine(" Сначала выполняем по порядку(слева направо) умножение и деление: ");
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
                    var multiplication = new Calculation(leftNumber, rightNumber, "*");
                    //Заменяем 
                    var newstr = new StringBuilder(Str);
                    newstr.Replace(leftNumber + "*" + rightNumber, multiplication.Result.ToString());
                    Str = newstr.ToString();
                    Console.WriteLine(Str);
                }
                else
                {
                    var index = DivisionFinder(Str);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    var multiplication = new Calculation(leftNumber, rightNumber, "/");
                    //Заменяем 
                    var newstr = new StringBuilder(Str);
                    newstr.Replace(leftNumber + "/" + rightNumber, multiplication.Result.ToString());
                    Str = newstr.ToString();
                    Console.WriteLine(Str);
                }
            }
            Console.WriteLine(" Выполняем по порядку(слева направо) сложение и вычитание: ");
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
                    var multiplication = new Calculation(leftNumber, rightNumber, "+");
                    //Заменяем 
                    var newstr = new StringBuilder(Str);
                    newstr.Replace(leftNumber + "+" + rightNumber, multiplication.Result.ToString());
                    Str = newstr.ToString();
                    Console.WriteLine(Str);
                }
                else
                {
                    var index = SubtractionFinder(Str);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    var multiplication = new Calculation(leftNumber, rightNumber, "-");
                    //Заменяем 
                    var newstr = new StringBuilder(Str);
                    newstr.Replace(leftNumber + "-" + rightNumber, multiplication.Result.ToString());
                    Str = newstr.ToString();
                    Console.WriteLine(Str);
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

        public string WriteOutSeparator()
        {
            return $"{Str}";
        }

        private static int MultiplicationFinder(string x)
        {
            var index = x.IndexOf("*", StringComparison.Ordinal);
            return index == -1 ? 0 : index;
        }
        private static int DivisionFinder(string x)
        {
            var index = x.IndexOf("/", StringComparison.Ordinal);
            return index == -1 ? 0 : index;
        }
        private static int AdditionFinder(string str)
        {
            var index = str.IndexOf("+", StringComparison.Ordinal);
            return index == -1 ? 0 : index;
        }
        private static int SubtractionFinder(string str)
        {
            var index = str.IndexOf("-", StringComparison.Ordinal);
            return index == -1 ? 0 : index;
        }


    }
}
