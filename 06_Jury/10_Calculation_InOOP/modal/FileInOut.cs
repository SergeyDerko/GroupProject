using System;
using System.IO;
using System.Text;

namespace _10_Calculation_InOOP.modal
{
    public class FileInOut
    {
        private string Document { get; }
        private string Result { get; }
        //Чтение с файла и передача в свойство
        public FileInOut(string x)
        {
            Document = x;
            var strInfile = new StringBuilder();
            foreach (var i in File.ReadLines(Document))
            {
                strInfile.Append(i);
            }
            Document = strInfile.ToString();
        }
        //вывод в консоль считаных с файла данных
        public void Show()
        {
            Console.WriteLine($"\n Выражение считанное с файла: {Document}");
        }
        //Запись в файл принятого от сепаратора результата
        public FileInOut(string x, string y)
        {
            Result = y;
            File.WriteAllText(x, y);
        }
        //Вывод в консоль резутат выражения
        public void ShowResult()
        {
            Console.WriteLine($"Результат: {Result}");
        }
        //Отправка в сеператор для решения
        public string WriteToSeparator()
        {
            return $"{Document}";
        }
    }
}
