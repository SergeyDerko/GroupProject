using System;
using System.Text;

namespace _10_Calculation_ScanDirectory.modal
{
    internal class Separator
    {
        private string _exampleInFile;

        public void StartSeparator(string x)
        {
            _exampleInFile = x;
            Console.WriteLine(" Сначала выполняем по порядку(слева направо) умножение и деление:\n");
            while (MultiplicationFinder(_exampleInFile) != DivisionFinder(_exampleInFile))
            {
                if (MultiplicationFinder(_exampleInFile) < DivisionFinder(_exampleInFile))
                {
                    var index = MultiplicationFinder(_exampleInFile);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, _exampleInFile, "*");
                }
                else
                {
                    var index = DivisionFinder(_exampleInFile);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, _exampleInFile, "/");
                }
            }
            Console.WriteLine("\n Выполняем по порядку(слева направо) сложение и вычитание:\n");
            while (AdditionFinder(_exampleInFile) != SubtractionFinder(_exampleInFile))
            {
                if (AdditionFinder(_exampleInFile) < SubtractionFinder(_exampleInFile))
                {
                    var index = AdditionFinder(_exampleInFile);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, _exampleInFile, "+");
                }
                else
                {
                    var index = SubtractionFinder(_exampleInFile);
                    //Число слева от знака
                    var leftNumber = LeftNumber(index);
                    //Число справа от знака
                    var rightNumber = RightNumber(index);
                    //Считаем результат операции
                    ToCalculation(leftNumber, rightNumber, _exampleInFile, "-");
                }
            }
            Console.Write("\n Результат: ");
            Scan.Green($"{_exampleInFile}");
        }

        private int RightNumber(int index)
        {
            var indexRight = index + 1;
            for (var i = indexRight; i < _exampleInFile.Length; i++)
            {
                if (char.IsDigit(_exampleInFile[i]))
                {
                    indexRight = i;
                }
                else
                {
                    indexRight = i - 1;
                    break;
                }
            }
            var rightNumber = int.Parse(_exampleInFile.Substring(index + 1, indexRight - index));
            return rightNumber;
        }

        private int LeftNumber(int index)
        {
            var indexLeft = index - 1;
            for (var i = indexLeft; i >= 0; i--)
            {
                if (char.IsDigit(_exampleInFile[i]))
                {
                    indexLeft = i;
                }
                else
                {
                    indexLeft = i + 1;
                    break;
                }
            }
            var leftNumber = int.Parse(_exampleInFile.Substring(indexLeft, index - indexLeft));
            return leftNumber;
        }

        private void ToCalculation(int leftNumber, int rightNumber, string x, string operation)
        {
            _exampleInFile = x;
            var result = new Calculation(leftNumber, rightNumber, operation);
            //Заменяем 
            var newstr = new StringBuilder(_exampleInFile);
            newstr.Replace(leftNumber + operation + rightNumber, result.Result.ToString());
            _exampleInFile = newstr.ToString();
            Console.WriteLine($" {leftNumber}{operation}{rightNumber}={result.Result} --> {_exampleInFile}");

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

        public string WriteOut()
        {
            return $"{_exampleInFile}";
        }
    }
}
