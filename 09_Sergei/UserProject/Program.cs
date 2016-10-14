
using System;
using UserProject.Characters;

namespace UserProject
{
    internal class Program
    {
        private static void Main()
        {
            //var r = new Recruit() {Exp = 1000};
            //r.LevelUp();

            //var character = r.SelectClass() == new Rogue() ? new Rogue() : r.SelectClass(); 
            // Console.WriteLine(character);

            var w = new Warrior();
            w.Exp = 4000;
            w.LevelUp();
            Console.WriteLine("{0} {1} {3} {4} {5} {6}","Str is:"+ w.Str,"Agi is"+w.Agi,"w.Int is"+ w.Int, "Health is" + w.Health, "Mana is" + w.Mana, "Exp is " + w.Exp,"Lvl is " + w.Lvl);
            Console.ReadKey();
        }


    }
}
