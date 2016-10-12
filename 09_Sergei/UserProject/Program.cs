
using System;
using UserProject.Characters;

namespace UserProject
{
    internal class Program
    {
        private static void Main()
        {
            var r = new Recruit() {};
            r.LevelUp();
            
            var character = r.SelectClass();
            Console.WriteLine(character);
            Console.ReadKey();
            if (character == new Warrior())
            {
                character = new Warrior();
               
            }


        }
    }
}
