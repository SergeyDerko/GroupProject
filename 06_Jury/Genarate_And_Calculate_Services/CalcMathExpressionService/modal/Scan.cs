using System.IO;
using Common;

namespace CalcMathExpressionService.modal
{
    internal static class Scan
    {
        // папка для сканирования
        private static readonly string FolderToScan =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            + @"..\..\..\files\Tocount";

        // папка для записи результата
        private static readonly string FolderResult =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            + @"..\..\..\files\Result\";

        // папка для перемещения решенных примеров
        private static readonly string FolderCompleted =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            + @"..\..\..\files\Completed\";


        public static void StartCalculation()
        {
            var scanResult = ScanFolder(); // сканирование директории FolderToScan 
            foreach (var pathfile in scanResult) // цикл для перебора найденных файлов
            {
                // Получение имени файла для дальнейшей записи файла з результатом
                var fileName = Path.GetFileName(pathfile);
                Logger.Write(Level.Info, $"Файл {fileName}");
                var count = 1;

                if (File.Exists(FolderResult + $"Result of {fileName}"))
                    File.Delete(FolderResult + $"Result of {fileName}");


                foreach (var textInFile in File.ReadLines(pathfile)) // цикл для считывания файла
                {
                    Logger.Write(Level.Info, $"Выражение {count++}: {textInFile}. Решение:");
                    var separator = new Separator(textInFile); // отправка в сепаратор для решения
                    var result = separator.WriteOut(); // результат 
                    // запись в папку FolderResult
                    File.AppendAllText(FolderResult + $"Result of {fileName}", $"\n {textInFile} = {result}");
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
            Logger.Write(Level.Info,
                scanResult.Length != 0
                    ? $"Обнаружены файлы в рабочей папке. Найдено {scanResult.Length} файлов."
                    : "В рабочей папке нет файлов.");

            return scanResult;
        }
    }
}
