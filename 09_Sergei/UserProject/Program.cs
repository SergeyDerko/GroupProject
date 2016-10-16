
using System;
using UserProject.Characters;

namespace UserProject
{
    internal class Program
    {
        private static void Main()
        {
            var r = new Recruit();
            Console.WriteLine("Recruit Lvl is: "+r.Lvl+"\n"+"Recruit Exp: "+r.Exp);
            

            var w = new Warrior {Exp = 200};
            w.LevelUp();
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}",
                "Str is: " + w.Str + "\n",
                "Agi is: " + w.Agi + "\n",
                "Int is: " + w.Int + "\n",
                "Health is: " + w.Health + "\n",
                "Mana is: " + w.Mana + "\n",
                "Attack is: " + w.Attack + "\n",
                "Defence is: " + w.Defence+"\n",
                "Exp is: " + w.Exp + "\n",
                "Lvl is: " + w.Lvl);
            Console.ReadKey();
        }
    }
}
