using System;
using System.IO;

namespace _10_calc_func
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new string('-', 10) + "Калькулятор решения примеров с файла" + new string('-', 10) +
                              "\n Файл с примерами для решения: Examples.txt\n Файл с решением примеров: Output.txt\n\n" +
                              new string('-', 56) + "\n Решение примеров:");
            var pathInput = @"Examples.txt";
            var pathOutput = @"Output.txt";
            if (File.Exists(pathOutput))//удаляем старый файл
                File.Delete(pathOutput);
            if (File.Exists(pathInput))
            {
                foreach (var i in File.ReadLines(pathInput))
                {
                    var example = i.Split(Convert.ToChar(" "));
                    CalcExample(example);
                }
            }
            else
                Console.WriteLine("Заданого файла не найдено!");
            Console.ReadKey();
        }
        private static void CalcExample(string[] example)
        {

            int verify;
            if (int.TryParse(example[0], out verify) && int.TryParse(example[2], out verify))
            {
                var pathOutput = @"Output.txt";
                var operand1 = int.Parse(example[0]);
                var whatDo = example[1];
                var operand2 = int.Parse(example[2]);
                int result = 0;
                switch (whatDo)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    default:
                        Console.WriteLine("Неправильный оператор");
                        break;
                }
                var exampleresult = $"{operand1} {whatDo} {operand2} = {result}" + Environment.NewLine;
                File.AppendAllText(pathOutput, exampleresult);
                Console.WriteLine($" {operand1} {whatDo} {operand2} = {result}");

            }
            else
                Console.WriteLine("Некоректный пример для решения, проверте файл с примерами");

        }

    }
}
