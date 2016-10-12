
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
            
            var character = r.SelectClass();
            Console.WriteLine(character);
            Console.ReadKey();
            /*if (character == new Rogue())
            {
                character = new Rogue();
                
                Console.WriteLine(character);  
            }*/


        }
    }
}
