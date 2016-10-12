using System;
using System.Threading;

namespace AnimeConsole
{
    class Program
    {
        static void Main()
        {
            string bar = "C# Brain Academy  ";
            var title = "Вас приветствует ";
            while (true)
            {
                for (int i = 0; i < bar.Length; i++)
                {
                    title += bar[i];
                    Console.Title = title;
                    Thread.Sleep(150);
                }
                title = "";
            }
        }
    }
}