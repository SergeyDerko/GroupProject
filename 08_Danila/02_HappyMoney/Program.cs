using System;

namespace _02_HappyMoney
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа V 1.0 (Для ВЫХОДА нажать Esc)");
            Console.WriteLine("Управление осуществляется стрелками");
            Console.WriteLine("      Движение");
            var str = "     ВЕСЕЛОГО ";

            int strLen = str.Length;
            for (int i = 0; i < strLen; i++)
            {
                Console.ForegroundColor = (ConsoleColor)(i % 15 + 1);
                Console.Out.Write(str[i]);
            }
            const string dol = "$";
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$");
            }
            var x = 14; // Начальные координаты
            var y = 3;
            ConsoleKeyInfo k; //управлять курсором (добавил Решарпер)
            Console.CursorVisible = false; //скрыть курсор
            do
            {
                Console.SetCursorPosition(x, top: y); //Позиция курсора
                Console.WriteLine(dol);
                k = Console.ReadKey(true); //чтение управления 
                if (k.Key == ConsoleKey.UpArrow)//движ вверх
                    y--;
                else if (k.Key == ConsoleKey.DownArrow)//движ вниз
                    y++;
                else if (k.Key == ConsoleKey.LeftArrow)//движ влево
                    x--;
                else if (k.Key == ConsoleKey.RightArrow)//движ вправо
                    x++;

                Console.Clear(); //очистить после себя 
                                 // Console.CursorVisible = false; 
            } while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc
        }


    }
}