using System;
using System.IO;
using System.Text.RegularExpressions;
using _10_Calc_Modul.Interfaces;

namespace _10_Calc_Modul
{
    internal class ScanDirectory : Calculator, IScanDirectory
    {
        public string PathDir { get; set; }

        #region Constructor
        //конструктор по умолчанию
        internal ScanDirectory()
        {
            PathDir = @"../../Test"; // путь к директории по умолчанию
        }
        //конструктор по желанию:)
        internal ScanDirectory(string pathDir)
        {
            PathDir = pathDir; // путь к директории который можно указать в конструкторе при инстанцировании класса
        }
        #endregion

        #region MethodScan
        //Сканирует директорию
        public void Scan(string pathDirectory)
        {
            var input = @"../../input.txt"; // путь к файлу куда, в будущем:), будут записываться результаты
            var files = Directory.GetFiles(pathDirectory); // считываем все файлы с указанной директории
            foreach (var fileName in files) //проходим по каждому файлу отдельно
            {
                /*if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) == -1)
                {
                    File.Delete(pathDirectory + fileName);
                }*/ //это будущая проверка на корректное название файла, реализую чуть позже
                var str = File.ReadAllText(fileName); // считываем данные с файла
                var result = GetResult(str); //обрабатаваем данные в методе GetResult(str)
                File.WriteAllText(input, str); //записываем обработанные данные
            }
        }
        #endregion

        public string GetResult(string str)
        {
            var pattern = "";
            var tempStr = str.ToCharArray();
            foreach (var x in tempStr)
            {
                if (!Regex.IsMatch(x.ToString(), @"\d") && !Regex.IsMatch(x.ToString(), @"\s") &&
                    !Regex.IsMatch(x.ToString(), @"[*/+-=]")) break;
                str += x.ToString();
                if (Regex.IsMatch(x.ToString(), @"(\d+)"))
                {
                    if (pattern.Contains(@"\d+") || !pattern.Contains(@"([*/+-])"))
                    {
                        pattern = @"(\d+)";
                    }
                    if (pattern.Contains(@"(\d+)\s+([*/+-])\s") && Regex.IsMatch(x.ToString(), @"(\d+)"))
                    {
                        pattern = @"(\d+)\s+([*/+-])\s+(\d+)";
                    }
                    else
                    {
                        pattern += @"(\d+)";
                    }
                }
                if (Regex.IsMatch(str, @"(\d+)\s+([*/+-])\s+(\d+)"))
                {
                    var res = GetResult(pattern, str);
                    str = res.ToString();
                    pattern = @"(\d+)";
                }
                else if (Regex.IsMatch(x.ToString(), @"([*/+-])"))
                {
                    pattern += @"([*/+-])";
                }
                else if (Regex.IsMatch(x.ToString(), @"[=]"))
                {
                    pattern = " ";
                }
            }
            return str;
        }
    }
}