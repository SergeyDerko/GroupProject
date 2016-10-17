
using System;
using UserProject.Characters;

namespace UserProject
{
    internal class Program
    {
        private static void Main()
        {

            var w = new Warrior {Exp = 100};
            w.LevelUp();
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}","Str is:"+ w.Str,"Agi is"+w.Agi,"w.Int is"+ w.Int, "Health is" + w.Health, "Mana is" + w.Mana, "Exp is " + w.Exp,"Lvl is " + w.Lvl);
            Console.ReadKey();
        }


    }
}
