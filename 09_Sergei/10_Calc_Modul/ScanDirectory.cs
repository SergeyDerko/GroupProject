using System;
using System.IO;
using System.Text.RegularExpressions;
using _10_Calc_Modul.Interfaces;

namespace _10_Calc_Modul
{
    internal class ScanDirectory : Calculator, IScanDirectory
    {
        public string PathDir { get; set; }
        public string Input { get; set; }
        #region Constructor
        //конструктор по умолчанию
        internal ScanDirectory()
        {
            PathDir = @"../../Test"; // путь к директории по умолчанию
            Input = @"../../input.txt"; // путь к файлу куда, в будущем:), будут записываться результаты
        }
        //конструктор по желанию:)
        internal ScanDirectory(string pathDir)
        {
            PathDir = pathDir; // путь к директории который можно указать в конструкторе при инстанцировании класса
            Input = @"../../input.txt"; // путь к файлу куда, в будущем:), будут записываться результаты
        }
        #endregion

        #region MethodScan
        //Сканирует директорию
        public void Scan(string pathDirectory)
        {
            
            var files = Directory.GetFiles(pathDirectory); // считываем все файлы с указанной директории
            foreach (var fileName in files) //проходим по каждому файлу отдельно
            {
                //здесь будет проверка на корректное расшерение файла, реализую чуть позже
                var str = File.ReadAllText(fileName); // считываем данные с файла
                var result = DataProcessing(str); //обрабатаваем данные в методе DataProcessing(str)
                 
            }
        }
        #endregion
        //Обработка полученных данных и возвращение результата обработки
        public string DataProcessing(string str)
        {
            var result = 0;
            var pattern = "";//pattern - переменная которая будет хранить в себе модель регулярных выражений, оно будет генерироваться по мере прохождения  цикла foreach
            var expression = "";//exppression - переменна которая будет хранить в себе матиматическое выражение, оно будет генерироваться по мере прохождения  цикла foreach 
            var tempStr = str.ToCharArray();//разбиваем полученную строку для того что бы можно было пройтись по каждому елементу.
            int i;//Итератор
            for (i = 0; i < tempStr.Length; i++)
            {
                if (!Regex.IsMatch(tempStr[i].ToString(), @"\d") && !Regex.IsMatch(tempStr[i].ToString(), @"[*/+-=]"))
                    continue; //работаем только с интересуещими нас елементами, числа и мат. операторы .
                if (!Regex.IsMatch(tempStr[0].ToString(), @"\d")) continue;
                expression += tempStr.ToString(); //после того как прошли проверки записываем елемент в наше выражение
                if (Regex.IsMatch(tempStr[i].ToString(), @"(\d+)")) //проверяем являеться ли елемент числом.
                {
                    pattern += @"(\d+)"; //если да добавляем в нашу модель регулярных выражения (\d) - число типа decimal
                }
                if (Regex.IsMatch(expression, pattern))//если наше выражение похоже на собранную модель регулярных выражений
                {
                    result = Calc(pattern, expression);//считаем и получаем результат
                    //tempStr[i] = result.ToString();//заменяем наше выражение на результат наш результат
                    pattern = @"(\d+)";
                }
                else if (Regex.IsMatch(tempStr[i].ToString(), @"([*/+-])"))
                {
                    pattern += @"([*/+-])";
                }
                else if (Regex.IsMatch(tempStr[i].ToString(), @"[=]"))
                {
                    pattern = " ";//Обнуляем модель регулярных выражений
                    File.WriteAllText(Input, result.ToString()); //записываем результаты посчитанного выражения которе нашли в файле.
                }
            }
            return expression;
        }
    }
}