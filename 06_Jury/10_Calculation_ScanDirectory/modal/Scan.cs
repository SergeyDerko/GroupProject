using System;
using System.IO;
using System.Text;

namespace _10_Calculation_ScanDirectory.modal
{
    internal static class Scan
    {
        private const string FolderToScan = @"..\..\files\Tocount";
        private const string FolderResult = @"..\..\files\Result\";
        private const string FolderCompleted = @"..\..\files\Completed\";

        public static void StartCalculation()
        {
            var scanResult = ScanFolder(); // скан папки FolderToScan
            foreach (var pathfile in scanResult) // Пускаем файлы через цикл дя решения
            {
                var lastSlash = pathfile.LastIndexOf(@"\", StringComparison.Ordinal); // Выделение с  адреса имени файла
                var fileName = pathfile.Substring(lastSlash + 1);
                Console.Write(new string('-', 50) + "\n Файл: ");
                Green(fileName);
                foreach (var textInFile in File.ReadLines(pathfile)) // Считывание примера 
                {
                    var exampleInfile = new StringBuilder(); // Через стрингбилдер создается строка с примером
                    var examplereadytocalc = exampleInfile.Append(textInFile).ToString();
                    Console.Write(" Выражение считанное с файла: ");
                    Green(examplereadytocalc);
                    Console.Write(" Решение:\n");
                    var separator = new Separator();
                    separator.StartSeparator(examplereadytocalc); // старт вычеслений
                    var result = separator.WriteOut(); // Полечение результата
                    File.WriteAllText(FolderResult + $"Result of {fileName}", $"{examplereadytocalc} = {result}");
                }
                if (File.Exists(FolderCompleted + fileName))
                    // Если в папке Completed есть файлы с такимже именем - удаляем
                    File.Delete(FolderCompleted + fileName);
                File.Move(pathfile, FolderCompleted + fileName); // перемещение решенного примера в Completed 
            }
        }

        private static string[] ScanFolder()
        {
            var scanResult = Directory.GetFiles(FolderToScan, "*.txt");
            Green($"\n Найдено {scanResult.Length} файлов!\n");
            if (scanResult.Length == 0)
                Green(" В рабочей папке нет файлов! Добавте файлы для работы калькулятора!");
            return scanResult;
        }

        public static void Green(string x)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(x);
            Console.ResetColor();
        }
    }
}
