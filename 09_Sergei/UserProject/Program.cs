
using System;
using UserProject.Characters;

namespace UserProject
{
    internal class Program
    {
        private static void Main()
        {
            var r = new Recruit() {Exp = 1000};
            r.LevelUp();
            
            var character = r.SelectClass() == new Rogue() ? new Rogue() : r.SelectClass();
            
            Console.WriteLine(character);
            Console.ReadKey();
        }


    }
}
