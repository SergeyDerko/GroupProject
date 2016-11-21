using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Service_Calculation.Modal
{
    public class Calculator
    {
        //Метод калькулятора расчет или  Calculation
        protected internal double Calculation(string pattern, string expression)//принимает паттерн регулярного выражение и выражение которое будем считать
        {
            double result = 0;//переменная result будет хранить в себе полученный результат
            foreach (Match c in Regex.Matches(expression, pattern))
            {
                var value1 = double.Parse(c.Groups[1].Value);
                var value2 = double.Parse(c.Groups[3].Value);
                var action = c.Groups[2].Value;
                //проверяем какое действие нужно выполнить 
                switch (action)
                {
                    case "*": //если попадаем на знак/оператор умножение
                        {
                            var f = new Separator();//создаем и инстанцируем объект класса ScanDirectory() в данном случае с конструктором по умолчанию
                            Console.WriteLine("{0}" + "=" + "{1}", c.Value, value1 * value2);//выводим для наглядности выражение с результатом в консоль
                            result = value1 * value2;//считаем выражение
                            File.AppendAllText(f.PathResult, "\n" + value1 + "*" + value2 + "=" + result);//Проводим запись выражения с результатом в указанный файл
                            break;//выходим из ветвления
                        }
                    //если находим другие знаки/операторы делаем по аналогии как и со знаком умножение.
                    case "/":
                        {
                            var f = new Separator();
                            Console.WriteLine("{0}" + "=" + " {1:N2}", c.Value, value1 / value2);
                            result = value1 / value2;
                            File.AppendAllText(f.PathResult, "\n" + value1 + "/" + value2 + "=" + result);
                            break;
                        }
                    case "+":
                        {
                            var f = new Separator();
                            Console.WriteLine("{0} " + "=" + " {1}", c.Value, value1 + value2);
                            result = value1 + value2;
                            File.AppendAllText(f.PathResult, "\n" + value1 + "+" + value2 + "=" + result);
                            break;
                        }
                    case "-":
                        {
                            var f = new Separator();
                            Console.WriteLine("{0} " + "=" + " {1}", c.Value, value1 - value2);
                            result = value1 - value2;
                            File.AppendAllText(f.PathResult, "\n" + value1 + "-" + value2 + "=" + result);
                            break;
                        }
                }
            }
            return result;//возвращаем посчитанный результат
        }
    }
}
