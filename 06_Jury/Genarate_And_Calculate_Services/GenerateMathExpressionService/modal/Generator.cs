using System;
using System.IO;
using System.Text;
using Common;

namespace GenerateMathExpressionService.modal
{
    internal static class Generator
    {
        private static readonly string FolderForFiles =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\files\";

        private static readonly Random Random = new Random();

        public static void Generate()
        {
            var example = new StringBuilder();
            var operations = new[] { "*", "/", "+", "-" };
            for (var j = 0; j <= Random.Next(5); j++) // рандомное количество примеров в файле
            {
                for (var i = 0; i <= Random.Next(3, 20); i++) // рандомное количество елементов выражения
                {
                    if (i == 0)
                        example.Append(Random.Next(1, 100));
                    example.Append(operations[Random.Next(4)]);  // рандомный знак 
                    example.Append(Random.Next(1, 100));
                }
                example.AppendLine(); // перенос на новую строку
            }
            Directory.CreateDirectory(FolderForFiles);  // создание директории, если не существует
            var fileName = GetRandomFileName(); // рандомное имя файла
            File.WriteAllText(FolderForFiles + fileName, example.ToString()); // запись в файл
            Logger.Write(Level.Info, $"Сгенерирован файл {fileName}"); // запись логгера
        }

        private static string GetRandomFileName() 
        {
            var path = Path.GetRandomFileName(); // рандомное имя, убираем точку (метод генерит файл, с рандомным расширением)
            path = path.Replace(".", "");
            return $"file_{path}.txt";
        }

        
    }
}
