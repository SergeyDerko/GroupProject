using static System.Console;

namespace _02_parnist
{
    class Program
    {
        static void Main()
        {
            WriteLine("ВВедите число=>");
            var k=int.Parse(ReadLine());
            WriteLine(k%2 == 1 ? "Число непарне" : "Число парне");
        }
    }
}
