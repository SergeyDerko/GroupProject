//пример взят из http://professorweb.ru/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _502_RegularExpressions
{
    class Program
    {
        static void Main()
        {
            FirstSample();
            Console.Clear();
            ReplaceSample();
            Console.Clear();
            MatchesSample();
            Console.Clear();
            LmsSample();
            Console.ReadKey();
        }

        private static void LmsSample()
        {
            string[] values = {"000-111-22-33", "00-111-22-33"};
            string pattern = @"^\d{3}-\d{3}-\d{2}-\d{2}$";
            foreach (string value in values)
            {
                Console.WriteLine(Regex.IsMatch(value, pattern) ? "{0} is a valid phone number." : "{0}:Invalid", value);
            }


            var input = "There is is some text about about regular expression";
            pattern = @"\b(\w+)\W+(\1)\b";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                Console.WriteLine("Duplicate'{0}' found at position {1}.", match.Groups[1].Value, match.Groups[2].Index);
            }

            List<string> results = new List<string>();
            List<int> matchPosition = new List<int>();
            Regex r = new Regex("text");
            var matches = r.Matches("There is text about regular expression.Text include several words \"text\"");
            foreach (Match match in matches)
            {
                results.Add(match.Value);
                matchPosition.Add(match.Index);
            }
            for (int index = 0; index < results.Count; index++)
            {
                Console.WriteLine("'{0}' found at position {1}.", results[index], matchPosition[index]);
            }

        }

        private static void MatchesSample()
        {
            string myText = @"Сериализация представляет собой процесс сохранения объекта на диске. 
                В другой части приложения или даже в совершенно отдельном приложении может производиться
                десериализация объекта, возвращающая его в состояние, в котором он пребывал до сериализации.";

            const string myReg = "со";
            MatchCollection myMatch = Regex.Matches(myText, myReg);

            Console.WriteLine("Все вхождения строки \"{0}\" в исходной строке: ", myReg);
            foreach (Match i in myMatch)
            {
                Console.Write("\t" + i.Index);
            }

            // Усложним шаблон регулярного выражения
            // введя в него специальные метасимволы
            // \w	Любой текстовый символ, не являющийся пробелом, символом табуляции и т.п.
            // \W Любой символ, не являющийся текстовым символом
            // \b	Соответствует границе слова, т.е. соответствует позиции между символом \w и символом \W или между символом \w и началом или концом строки.
            // \S	Любой непробельный символ из набора Unicode. Обратите внимание, что символы \w и \S - это не одно и то же
            const string myReg1 = @"\b[с,д]\S*ериализац\S*";
            MatchCollection match1 = Regex.Matches(myText, myReg1, RegexOptions.IgnoreCase);
            FindMyText(myText, match1);

            Console.ReadLine();
        }

        static void FindMyText(string text, MatchCollection myMatch)
        {
            Console.WriteLine("\n\nИсходная строка:\n\n{0}\n\nВидоизмененная строка:\n", text);

            // Реализуем выделение ключевых слов в консоли другим цветом
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }
        }

        private static void ReplaceSample()
        {
            // Допустим в исходной строке нужно заменить "руб." на "$",
            // а стоимость переместить после знака $
            string input = "Добро пожаловать в наш магазин, вот наши цены: \n" +
                           "\t 1 кг. яблок - 20 руб. \n" +
                           "\t 2 кг. апельсинов - 30 руб. \n" +
                           "\t 0.5 кг. орехов - 50 руб. \n";

            Console.WriteLine("Исходная строка:\n {0}", input);

            // В шаблоне используются 2 группы
            // \w	Любой текстовый символ, не являющийся пробелом, символом табуляции и т.п.
            // \W Любой символ, не являющийся текстовым символом
            // \b	Соответствует границе слова, т.е. соответствует позиции между символом \w и символом \W или между символом \w и 
            // началом или концом строки.
            string pattern = @"\b(\d+)\W?(руб.)";

            // Строка замены "руб." на "$"
            string replacement1 = "$$$1"; // Перед первой группой ставится знак $,
            // вторая группа удаляется без замены

            input = Regex.Replace(input, pattern, replacement1);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);
        }

        private static void FirstSample()
        {
            // Массив тестируемых строк
            string[] test =
            {
                "Wuck World", "Hello world", "My wonderful world"
            };

            // Проверим, содержится ли в исходных строках слово World
            // при этом мы не укажем опции RegexOption
            Regex regex = new Regex("World");

            Console.WriteLine("Регистрозависимый поиск: ");
            foreach (string str in test)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            }
            Console.WriteLine();

            // Теперь укажем поиск, не зависимый от регистра
            regex = new Regex("World", RegexOptions.IgnoreCase);

            Console.WriteLine("РегистроНЕзависимый поиск: ");
            foreach (string str in test)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            }
        }
    }
}