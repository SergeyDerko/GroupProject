﻿using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Common;
using GeneratorOfMathExpression;

namespace Service_Calculation.Modal
{
    public class Separator
    {
        public  string PathDir { get; set; }
        public  string PathResult { get; set; }

        #region Constructor
        //конструктор по умолчанию
        internal Separator()
        {
            PathDir = @"D:\Gitprojects\GroupProject\09_Sergei\Service_Calculation\Files"; // путь к директории по умолчанию
            PathResult = @"D:\Gitprojects\GroupProject\09_Sergei\Service_Calculation\result.txt"; // путь к файлу куда, будут записываться результаты
        }
        //конструктор по желанию №1:)
        internal Separator(string pathDir)
        {
            PathDir = pathDir; // путь к директории который указывается при инстанцировании обьекта класса, которую будет сканировать программа
            PathResult = @"D:\Gitprojects\GroupProject\09_Sergei\Service_Calculation\result.txt"; // путь к файлу по умолчанию, куда будут записываться результаты вычеслений
        }
        //конструктор по желанию №2
        internal Separator(string pathDir, string pathResult)
        {
            PathDir = pathDir; // путь к директории который указывается при инстанцировании обьекта класса, которую будет сканировать программа
            PathResult = pathResult; // путь к файлу который указывается при инстанцировании обьекта класса, куда будут записываться результаты вычеслений
        }
        #endregion

        #region Сканирования директории

        public void GenerateFTasks()
        {
            var str = Generator.ExpressionGenerator();
            Generator.FileGenerator(PathDir,str);
        }

        //Сканирует директорию
        public void Scan(string pathDirectory)
        {
            var files = Directory.GetFiles(pathDirectory); // считываем все файлы с указанной директории
            foreach (var fileName in files) //проходим по каждому файлу отдельно
            {
                Logger.Write(Level.Info, $"Файл {fileName}");
                var str = File.ReadAllText(fileName); // считываем данные с файла
                var result = DataProcessing(str); //обрабатаваем данные в методе DataProcessing(str)
                var strResult = result.Replace("=", string.Empty);
                Logger.Write(Level.Info, $"Результат: {strResult}.");
                File.WriteAllText(PathResult, $"Результаты посчитаных выражений: {str} = {strResult} \r\n");
                File.Delete(fileName);
            }
        }
        #endregion
        #region Парсинг данных с файла.
        //Обработка полученных данных и возвращение результата обработки
        public string DataProcessing(string str)
        {
            while (true)
            {
                const string pattern = @"(\d+)([*/+-])(\d+)"; //pattern - переменная которая хранит модель регулярного выражения математических операций.
                var reStr = str.Replace(" ", string.Empty); //удаляем все пробелы в строке что бы не мешали:)
                var expression = GetExpression(reStr); //находим в строке приоритетное простое выражение совпадающее с паттерном выражений и записываем его в переменную _expression 
                if (!Regex.IsMatch(expression, pattern))
                    return str; 
                var expressionResult = Calculator.Calculation(pattern, expression).ToString(CultureInfo.InvariantCulture);
                var newStr = reStr.Replace(expression, expressionResult);
                str = newStr;
            }
        }
        
        #endregion
        #region Получаем из строки выражение
        //Метод получения выражения
        internal string GetExpression(string str)
        {

            var exp = new StringBuilder();//создаем переменную в которую будем записывать свое выражение


            //Блок кода связка ветвлений, которая определяет приоритетность операторов
            if (str.Contains("*"))//есть строка содержит знак умножения
            {
                var indexM = str.IndexOf("*", StringComparison.Ordinal);//определяем индекс
                var valueLeft = GetLeftValue(str, indexM);//получаем значение/операнд слева от оператора
                var valueRight = GetRightValue(str, indexM);//получаем значение/операнд справа от оператора
                exp = new StringBuilder($"{valueLeft}*{valueRight}");//сохраняем выражение
            }
            //если предыдущий не нашли, то ищем остальные по аналогии
            else if (str.Contains("/"))
            {
                var indexPm = str.IndexOf("/", StringComparison.Ordinal);
                var valueLeft = GetLeftValue(str, indexPm);
                var valueRight = GetRightValue(str, indexPm);
                exp = new StringBuilder($"{valueLeft}/{valueRight}");
            }
            else if (str.Contains("+"))
            {
                var indexPm = str.IndexOf("+", StringComparison.Ordinal);
                var valueLeft = GetLeftValue(str, indexPm);
                var valueRight = GetRightValue(str, indexPm);
                exp = new StringBuilder($"{valueLeft}+{valueRight}");
            }
            else if (str.Contains("-"))
            {
                var indexPm = str.IndexOf("-", StringComparison.Ordinal);
                var valueLeft = GetLeftValue(str, indexPm);
                var valueRight = GetRightValue(str, indexPm);
                exp = new StringBuilder($"{valueLeft}-{valueRight}");
            }
            return exp.ToString();//возвращаем  выражение
        }
        #endregion
        #region Получение левого значения от найденого оператора
        //метод получения левого значения/операнда от оператора
        internal string GetLeftValue(string str, int index)
        {
            var indexLeft = index - 1;//индекс с которого будем начинать идти по циклу
            //for(начинаем идти по циклу с указоного индекса; идем до тех пор пока индекс больше/равен нулю, после каждой итерации индекс уменьшается на единицу)
            for (var i = indexLeft; i >= 0; i--)
            {
                //делаем проверку (являеться ли елемент цифрой)
                if (char.IsDigit(str[i]))
                {
                    indexLeft = i;//если правда присваеваем елементу этого значения/операнда индекс равный итерации 
                }
                else
                {
                    indexLeft = i + 1; break;//если ложь (это не цифра), то присваеваем индексу значение данная итерация плюс один 
                }
            }
            //получаем значение со строки методом подстроки с стартовым индексом _indexLeft(до которого мы дошли) и длинной равняющейся _indexLeft минус индекс оператора от которого считали.
            var valueLeft = str.Substring(indexLeft, index - indexLeft);
            return valueLeft;
        }
        #endregion
        #region Получение правого значения от найденого оператора
        //метод получения правого значения от оператора
        internal string GetRightValue(string str, int index)
        {
            var valueRight = new StringBuilder();//сострока в которую запишем 
            //for(начинаем идти по циклу с индекса знака + 1; идем до тех пор пока индекс меньше длины строки, после каждой итерации индекс увеличивается на единицу)
            for (var i = index + 1; i < str.Length; i++)
            {
                //делаем проверку (являеться ли елемент цифрой)
                if (char.IsDigit(str[i]))
                {
                    valueRight.Append(str[i]);//если является, довляем елемент в строку, таким образом формируем правое значение/операнд от оператора.
                }
                else
                    break;//если елемент не является цифрой, выходим из цикла
            }
            return valueRight.ToString();//возвращаем правое значение/операнд
        }
        #endregion
    }
}
