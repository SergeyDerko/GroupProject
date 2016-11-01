using System;

namespace _502_CW
{
    class Program
    {
        enum MyEnum
        {
            Black,
            DarkBlue = 200,
            DarkGreen,
            DarkCyan,
            DarkRed =300
        }
        static void Main(string[] args)
        {
            //FirstSample();
        }

        private static void FirstSample()
        {
            Console.WriteLine((int) MyEnum.Black);
            Console.WriteLine((int) MyEnum.DarkBlue);
            Console.WriteLine((int) MyEnum.DarkGreen);
            Console.WriteLine((int) MyEnum.DarkCyan);
            Console.WriteLine((int) MyEnum.DarkRed);
            Console.WriteLine(Enum.GetName(typeof(MyEnum), MyEnum.DarkBlue));
            Console.WriteLine(sizeof(ulong));
            Console.ReadKey();
        }
    }
}