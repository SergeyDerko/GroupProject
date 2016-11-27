using System;
using Lib1User = Lib1.User;
using Lib2User = Lib2.User;

namespace Assembly
{
    class Program
    {
        static void Main()
        {
            var user1 = new Lib1User {Name = NewGuid(), SName = NewGuid(), Age = NewRandom()};
            var user2 = new Lib2User {Name = NewGuid(), SName = NewGuid(), Age = NewRandom()};
            Console.WriteLine(GetInstanceInformation(user1));
            Console.WriteLine(GetInstanceInformation(user2));
        }

        private static string GetInstanceInformation<T>(T type)
        {
            return $"Type: {typeof(T).Name}\t{type}";
        }

        private static int NewRandom(int minValue = 1, int maxValue = 99)
        {
            var random = new Random();
            return random.Next(minValue, maxValue);
        }

        private static string NewGuid()
        {
            return Guid.NewGuid().ToString("N").ToUpper();
        }

        //start "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\bin\dumpbin.exe" /headers "W:\repos\GroupProject\CW\02Module\201\Assembly\bin\Debug\Assembly.exe"
    }
}
