using System;

namespace _11_10_Plitochki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write
             ("Plitochka size: ");

            var plitochka = int.Parse(Console.ReadLine());

            var size = plitochka * plitochka;

            Console.Write
            ("Height: ");

            var height = int.Parse(Console.ReadLine());

            Console.Write
                ("Length: ");

            var length = int.Parse(Console.ReadLine());

            var stenochkaSize = height * length;

            var plitkaNumber = stenochkaSize / size;
            Console.Write("We need" + " " + plitkaNumber + " " + "plitok");
            Console.ReadKey();
        }
    }
}
