using Lib1User = Lib1.User;
using Lib2User = Lib2.User;

namespace Assembly
{
    class Program
    {
        static void Main()
        {
            var user1 = new Lib1User();
            var user2 = new Lib2User();
        }
    }
}
