using System;
using System.IO;
using System.Text;
using System.Threading;

namespace GeneratorOfMathExpression
{
    public static class Generator
    {
        public static string ExpressionGenerator()
        {
            var count = 0;
            var expression = new StringBuilder();
            var rand = new Random();
            var countEnd = rand.Next(5, 10);
            do
            {
                var lenght = rand.Next(3, 10);
                for (var i = 0; i <= lenght; i++)
                {
                    if (i == 0)
                    {
                        expression.Append(rand.Next(1, 1000).ToString());
                        continue;
                    }
                    expression.Append(GetOperator());
                    expression.Append(rand.Next(1, 1000).ToString());
                    if (i == lenght)
                    {
                        expression.Append("= \r\n");
                        break;
                    }
                    Thread.Sleep(rand.Next(500, 1000));
                }
                count++;
            } while (count != countEnd);
            return expression.ToString();
        }

        private static char GetOperator()
        {
            var op = new[] { '*', '/', '+', '-' };
            var rand = new Random();
            return op[rand.Next(3)];
        }

        
        /// <summary>
        /// FileGenerator - генерирует файлы в  указанной директории, 
        /// </summary>
        /// <param name="path">принимает путь к директории.</param>
        /// <param name="text">принимает строку которая будет записана в файл при генерации</param>
        public static void FileGenerator(string path, string text)
        {
            var r = new Random();
            var count = r.Next(1, 20);
            for (var i = 0; i < count; i++)
            {
                var filename = TextGerenator();
                File.AppendAllText($@"{path}\{filename}.txt", text);
                Thread.Sleep(r.Next(500, 1000));
            }
        }
        /// <summary>
        /// Генерация случайной текстовой строки с заявленной длиной.
        /// </summary>
        /// <param name="lenght">определяет количество символов в генерируемой строке</param>
        /// <returns></returns>
        public static string TextGerenator(int lenght)
        {
            var str = new StringBuilder();
            var rand = new Random();
            for (var i = 0; i < lenght; i++)
            {
                str.Append((char)rand.Next(98, 123));
            }
            return str.ToString();
        }
        /// <summary>
        /// Генерация случайной текстовой строки
        /// </summary>
        /// <returns></returns>
        public static string TextGerenator()
        {
            var str = new StringBuilder();
            var r = new Random();
            var lenght = r.Next(4, 10);
            for (var i = 0; i < lenght; i++)
            {
                str.Append((char)r.Next(98, 123));
            }
            return str.ToString();
        }
    }
}