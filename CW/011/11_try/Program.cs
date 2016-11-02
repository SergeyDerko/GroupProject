using System;
using System.IO;
using System.Threading;

namespace _11_try
{
    internal class Program
    {
        private const int Count = 10;

        private static void Main(string[] args)
        {
            var str = "22+33*44";
            var index = str.LastIndexOf("*") + 1;
            var indexEnd = index;
            for (int i = index; i < str.Length; i++)
            {
                var c = str[i];
                if (char.IsDigit(c))
                {
                    indexEnd = i;
                    continue;
                }
            }
            if (index == indexEnd)
            {
                throw new MyException();
            }
            var substring = str.Substring(index, indexEnd - index);

            var directoryInfo = new DirectoryInfo(@"d:\tmp");
            var fileInfos = directoryInfo.GetFiles();
            foreach (var fileInfo in fileInfos)
            {
                
            }

            while (true)
            {
                Console.WriteLine("Программа деления на ноль)))");
                var line = "";
                try
                {
                    Console.Write("Введите число: ");
                    line = Console.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        throw new MyException();
                    }
                    else
                    {
                        var num = int.Parse(line);
                        Console.WriteLine("100/num = " + 100/num);
                        Console.ReadKey();
                    }
                }
                catch (MyException m)
                {
                    Console.WriteLine("MyException!!!\nm: {0}", m);
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException!!!\nline: " + line);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль!!!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("finally");
                }
                Console.WriteLine("Для выхода нажмите Escape");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            }

            var user = new User();
            user.BirthdayEvent += UserOnBirthdayEvent;
            user.BirthdayEvent += x => {Console.WriteLine(x);};
            Action<object> userOnBirthdayEvent = delegate(object o) {  };
            user.BirthdayEvent += userOnBirthdayEvent;
            user.BirthdayEvent += Console.WriteLine;
            var test = user.Test();


            ThreadPool.QueueUserWorkItem(x =>
            {
                var color = new Random().Next(1, 16);
                callBack(color);
                user.OnBirthday(new{});
            });
        }

        private static void UserOnBirthdayEvent(object obj)
        {
            Console.WriteLine("obj: " + obj);
        }

        private static void callBack(object color)
        {
            for (var i = 0; i < Count; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = (ConsoleColor) ((int)color%15 + 1);
            }
        }
    }

    internal class MyException : Exception
    {
        public override string ToString()
        {
            var s = base.ToString();
            return "MyException!!!\n" + s;
        }
    }
}