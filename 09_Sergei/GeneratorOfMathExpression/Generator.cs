using System;
using System.IO;
using System.Threading;

namespace GeneratorOfMathExpression
{
    public static class Generator
    {

        public static string ExpressionGenerator(int seconds)
        {
            var rand = new Random();
            var expression = string.Empty;
            var lenght = rand.Next(3, 10);
            for (var i = 0; i <= lenght; i++)
            {
                if (i == 0)
                {
                    expression += rand.Next(1, 1000).ToString();
                    continue;
                }
                expression += GetOperator();
                expression += rand.Next(1, 1000).ToString();
                if (i == lenght)
                {
                    expression += '=';
                    break;
                }
                Thread.Sleep(rand.Next(500,1000));
            }
            return expression;
        }

        private static char GetOperator()
        {
            var op = new[] { '*', '/', '+', '-' };
            var rand = new Random();
            return op[rand.Next(3)];
        }

        /// <summary>
        /// FileGenerator - генерирует файлы в указанной директории.
        /// Параметр path - принимает путь к директории.
        /// Параметр count - принимает целочисленное значение - кол-во файлов, которые будут сгенерированы.
        /// Параметр extension - принимает расширение имени файла/-ов.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="count"></param>
        public static void FileGenerator(string path)
        {
            File.Create($@"{path}\file.txt");
        }
        /// <summary>
        /// FileGenerator - отдельным потоком генерирует файлы в  указанной директории,
        /// параметр path - принимает путь к директории.
        /// параметр count - принимает целочисленное значение - кол-во файлов, которые будут сгенерированы
        /// параметр text - принимает строку которая будет записана при генерации файла
        /// </summary>
        /// <param name="path"></param>
        /// <param name="count"></param>
        /// <param name="text"></param>
        public static void FileGenerator(string path, string text)
        {
            var t = new Thread(x =>
            {
              //  for (var i = 1; i <= count; i++)
                    File.AppendAllText($@"{path}\file.txt", text);
            });
            t.Start();
        }

        public static void TextGerenator()
        {
            var rand = new Random();
            for (var i = 0; i < rand.Next(98,123); i++)
            {
                 Console.Write((char)rand.Next(98,123));
            }
        }
    }
}