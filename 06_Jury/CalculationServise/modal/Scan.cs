using System;
using System.IO;
using System.Text;

namespace CalculationServise.modal
{
    internal static class Scan
    {
        // папка для сканирования
        private const string FolderToScan =
            @"C:\Users\admin\Documents\Visual Studio 2015\Projects\CalculationServise\files\Tocount";

        // папка для записи результата
        private const string FolderResult =
            @"C:\Users\admin\Documents\Visual Studio 2015\Projects\CalculationServise\files\Result\";

        // папка для перемещения решенных примеров
        private const string FolderCompleted =
            @"C:\Users\admin\Documents\Visual Studio 2015\Projects\CalculationServise\files\Completed\";


        public static void StartCalculation()
        {
            var scanResult = ScanFolder(); // сканирование директории FolderToScan 
            foreach (var pathfile in scanResult) // цикл для перебора найденных файлов
            {
                // Получение имени файла для дальнейшей записи файла з результатом
                var fileName = Path.GetFileName(pathfile);
                foreach (var textInFile in File.ReadLines(pathfile)) // цикл для считывания файла
                {
                    var separator = new Separator(textInFile); // отправка в сепаратор для решения
                    var result = separator.WriteOut(); // результат 
                    // запись в папку FolderResult
                    File.WriteAllText(FolderResult + $"Result of {fileName}", $"{textInFile} = {result}");
                }
                // перемещение отработаных файлов в папку FolderCompleted
                if (File.Exists(FolderCompleted + fileName))
                    File.Delete(FolderCompleted + fileName);
                File.Move(pathfile, FolderCompleted + fileName);
            }
        }

        private static string[] ScanFolder()
        {
            // поиск файлов с расширением txt
            var scanResult = Directory.GetFiles(FolderToScan, "*.txt");
            return scanResult;
        }
    }
}
