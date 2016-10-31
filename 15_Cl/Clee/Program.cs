using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clee
{
    class Program
    {
        static void Main(string[] args)
        {
            string exp;
            exp = '(' + File.ReadAllText(@"C: \Users\OLEG\Desktop\new\Set.txt").Replace(" ", "") + ')';
            Console.Write("Выражение: {0}\n", exp);
            File.WriteAllText(@"C: \Users\OLEG\Desktop\new\Get.txt", exp);
            Console.WriteLine("Ответ: " + exp);
            Console.ReadKey();
        }
    }
}
