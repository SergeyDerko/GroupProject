using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11
{
    public class FileInOut
    {
        private readonly string _file;
        private readonly string _result;
        //Чтение с файла и передача в поле
        public FileInOut(string x)
        {
            _file = x;
            var strInfile = new StringBuilder();
            foreach (var i in File.ReadLines(_file))
            {
                strInfile.Append(i);
            }
            _file = strInfile.ToString();
        }
        //вывод в консоль считаных с файла данных
        public void Show()
        {
            Console.WriteLine($"Выражение считанное с файла: {_file}");
        }
        //Запись в файл принятого от сепаратора результата
        public FileInOut(string x, string y)
        {
            _result = y;
            File.WriteAllText(x, y);
        }
        //Вывод в консоль резутат выражения
        public void ShowResult()
        {
            Console.WriteLine($"Результат: {_result}");
        }
        //Отправка в сеператор для решения
        public string WriteToSeparator()
        {
            return $"{_file}";
        }
    }
}
