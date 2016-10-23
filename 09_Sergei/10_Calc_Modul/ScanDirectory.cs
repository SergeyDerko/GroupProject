using System.IO;
using System.Text.RegularExpressions;
using _10_Calc_Modul.Interfaces;

namespace _10_Calc_Modul
{
    internal class ScanDirectory : Calculator, IScanDirectory
    {
        public string PathDir { get; set; }
        public string PathInput { get; set; }
        #region Constructor
        //конструктор по умолчанию
        internal ScanDirectory()
        {
            PathDir = @"../../Test"; // путь к директории по умолчанию
            PathInput = @"../../input.txt"; // путь к файлу куда, будут записываться результаты
        }
        //конструктор по желанию №1:)
        internal ScanDirectory(string pathDir)
        {
            PathDir = pathDir; // путь к директории который указывается при инстанцировании обьекта класса, которую будет сканировать программа
            PathInput = @"../../input.txt"; // путь к файлу по умолчанию, куда будут записываться результаты вычеслений
        }
        //конструктор по желанию №2
        internal ScanDirectory(string pathDir, string pathInput)
        {
            PathDir = pathDir; // путь к директории который указывается при инстанцировании обьекта класса, которую будет сканировать программа
            PathInput = pathInput; // путь к файлу который указывается при инстанцировании обьекта класса, куда будут записываться результаты вычеслений
        }
        #endregion

        #region MethodScan
        //Сканирует директорию
        public void Scan(string pathDirectory)
        {
            var files = Directory.GetFiles(pathDirectory); // считываем все файлы с указанной директории
            foreach (var fileName in files) //проходим по каждому файлу отдельно
            {
                var _str = File.ReadAllText(fileName); // считываем данные с файла
                File.AppendAllText(PathInput, '\n' + "математические выражения на входе" + _str +'\n');
                var _result = DataProcessing(_str); //обрабатаваем данные в методе DataProcessing(str)
                var _strResult = _result.Replace("=", string.Empty);
                //File.AppendAllText(PathInput,'\n'+"сверху промежуточные результаты" + '\n'+"Снизу общие результаты каждого посчитаного выражения"+'\n'+_strResult);
                File.Delete(fileName);
            }
            
        }
        #endregion
        //Обработка полученных данных и возвращение результата обработки
        public string DataProcessing(string _str)
        {
            //var result = 0;
            var _pattern = @"(\d+)([*/+-])(\d+)";//pattern - переменная которая хранит модель регулярного выражения математических операций.
            var _reStr = _str.Replace(" ", string.Empty);//удаляем все пробелы в строке что бы не мешали:)
            var _expression = GetExpression(_reStr);//находим в строке приоритетное простое выражение совпадающее с паттерном выражений и записываем его в переменную _expression
            if (Regex.IsMatch(_expression, _pattern))//проверяем корректность выражения
            {
                //если матиматическое выражение прошло проверку, начинаем считать его с помощью метода Calc из класса Calculator, после чего сохраняем результат в переменную _expressionResult
                var _expressionResult = Calc(_pattern, _expression).ToString();
                //заменяем уже посчитаное выражение в строке на его результат
                var _newStr = _reStr.Replace(_expression, _expressionResult.ToString());
                return DataProcessing(_newStr); //делаем рекурсию 
            }
            return _str;//когда все выражения в строке посчитаны,выводим ее из метода.
        }

        //Метод получения выражения
        internal string GetExpression(string _str)
        {
            
            var _exp = string.Empty;//сохдаем переменную в которую будем записывать свое выражение
           //Блок кода связка ветвлений, которая определяет приоритетность операторов
            #region  
            if (_str.Contains("*"))//есть строка содержит знак умножения
            {
                var _indexM = _str.IndexOf("*");//определяем индекс
                var _valueLeft = GetLeftValue(_str, _indexM);//получаем значения слева от оператора
                var _valueRight = GetRightValue(_str, _indexM);//получаем значения справа от оператора
                _exp = _valueLeft + "*" + _valueRight;//сохраняем выражение
            }
            //дальше по аналогии с другими операторами
            else if (_str.Contains("/"))
            {
                var _indexPM = _str.IndexOf("/");
                var _valueLeft = GetLeftValue(_str, _indexPM);
                var _valueRight = GetRightValue(_str, _indexPM);
                _exp = _valueLeft + "/" + _valueRight;
            }
            else if (_str.Contains("+"))
            {
                var _indexPM = _str.IndexOf("+");
                var _valueLeft = GetLeftValue(_str, _indexPM);
                var _valueRight = GetRightValue(_str, _indexPM);
                _exp = _valueLeft + "+" + _valueRight;
            }
            else if (_str.Contains("-"))
            {
                var _indexPM = _str.IndexOf("-");
                var _valueLeft = GetLeftValue(_str, _indexPM);
                var _valueRight = GetRightValue(_str, _indexPM);
                _exp = _valueLeft + "-" + _valueRight;
            }
            return _exp;//возвращаем считаное выражение
        }
        #endregion
        //метод получения левого значения от оператора
        internal string GetLeftValue(string _str, int _index)
        {

            var _valueLeft = "";
            var _indexLeft = _index - 1;
            for (var i = _indexLeft; i >= 0; i--)
            {
                if (char.IsDigit(_str[i]))
                {
                    _indexLeft = i;
                }
                else
                {
                    _indexLeft = i + 1; break;
                }
            }
            _valueLeft = _str.Substring(_indexLeft, _index - _indexLeft);
            return _valueLeft;
        }
        //метод получения правого значения от оператора
        internal string GetRightValue(string _str, int index)
        {
            var valueRight = "";
            for (int i = index + 1; i < _str.Length; i++)
            {
                if (char.IsDigit(_str[i]))
                {
                    valueRight += _str[i];
                }
                else
                    break;
            }
            return valueRight;
        }
    }
}