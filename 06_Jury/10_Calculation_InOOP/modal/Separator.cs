using System;
using System.Text;

namespace _10_Calculation_InOOP.modal
{
    internal class Separator
    {
        private string ExapmleInFile { get; set; }
        public Separator(string x)
        {
            ExapmleInFile = x;
            Console.WriteLine(new string('-', 30) + "\n Сначала выполняем по порядку(слева направо) умножение и деление:\n");
            while (OperationFinder(ExapmleInFile, "*") != OperationFinder(ExapmleInFile, "/"))
            {
                if (OperationFinder(ExapmleInFile, "*") < OperationFinder(ExapmleInFile, "/"))
                {
                    var index = OperationFinder(ExapmleInFile, "*");
                    ToCalculation(ExapmleInFile, index, "*");
                }
                else
                {
                    var index = OperationFinder(ExapmleInFile, "/");
                    ToCalculation(ExapmleInFile, index, "/");
                }
            }
            Console.WriteLine("\n Выполняем по порядку(слева направо) сложение и вычитание:\n");
            while (OperationFinder(ExapmleInFile, "+") != OperationFinder(ExapmleInFile, "-"))
                {
                    if (OperationFinder(ExapmleInFile, "+") < OperationFinder(ExapmleInFile, "-"))
                    {
                        var index = OperationFinder(ExapmleInFile, "+");
                        ToCalculation(ExapmleInFile, index, "+");
                    }
                    else
                    {
                        var index = OperationFinder(ExapmleInFile, "-");
                        ToCalculation(ExapmleInFile, index, "-");
                    }
                }
        }
        private void ToCalculation (string x, int index, string operation)
        {
            ExapmleInFile = x;
            var leftNumber = LeftNumber(index);
            var rightNumber = RightNumber(index);
            var resultoperation = new Calculation(leftNumber, rightNumber, operation);
            var newstr = new StringBuilder(ExapmleInFile);
            newstr.Replace(leftNumber + operation + rightNumber, resultoperation.Result.ToString());
            ExapmleInFile = newstr.ToString();
            Console.WriteLine($" {leftNumber}{operation}{rightNumber}={resultoperation.Result} --> {ExapmleInFile}");
        }
        private int RightNumber(int index)
        {
            var indexRight = index + 1;
            for (var i = indexRight; i < ExapmleInFile.Length; i++)
            {
                if (char.IsDigit(ExapmleInFile[i]))
                {
                    indexRight = i;
                }
                else
                {
                    indexRight = i - 1; break;
                }
            }
            var rightNumber = int.Parse(ExapmleInFile.Substring(index + 1, indexRight - index));
            return rightNumber;
        }
        private int LeftNumber(int index)
        {
            var indexLeft = index - 1;
            for (var i = indexLeft; i >= 0; i--)
            {
                if (char.IsDigit(ExapmleInFile[i])) 
                {
                    indexLeft = i;
                }
                else
                {
                    indexLeft = i + 1; break;
                }
            }
            var leftNumber = int.Parse(ExapmleInFile.Substring(indexLeft, index - indexLeft));
            return leftNumber;
        }
        private static int OperationFinder(string x, string operation)
        {
            switch (operation)
            {
                case "*":
                {
                    var index = x.IndexOf("*", StringComparison.Ordinal);
                    return Verifyindex(x, index);
                }
                case "/":
                {
                    var index = x.IndexOf("/", StringComparison.Ordinal);
                    return Verifyindex(x, index);
                }
                case "+":
                    {
                        var index = x.IndexOf("+", StringComparison.Ordinal);
                        return Verifyindex(x, index);
                    }
                case "-":
                    {
                        var index = x.IndexOf("-", StringComparison.Ordinal);
                        return Verifyindex(x, index);
                    }
                default:
                {
                    return 0;
                }
                    
            }
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
            return $"{ExapmleInFile}";
        }

    }
}
