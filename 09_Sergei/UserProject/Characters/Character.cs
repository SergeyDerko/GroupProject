using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UserProject.Characters
{
    internal abstract class Character
    {
         internal int Str { get; set; }
         internal int Agi { get; set; }
         internal int Int { get; set; }
         internal int Health { get; set; }
         internal int Mana { get; set; }
         internal int Exp { get; set; }
         internal int Lvl { get; set; }

         internal int Attack { get; set; }
         internal int Defence { get; set; }

        internal Character()
        {
            Str = 2;
            Agi = 2;
            Int = 2;
            Health = Str*50;
            Mana = Int*50;
            Exp = 0;
            Lvl = 0;
        }

        internal virtual int LevelUp()
        {

            
            Lvl++;
            var newLvl = Exp >= 1000 * Lvl ? Lvl++ : Lvl;
            if (newLvl == 1)
            {
                SelectClass();
            }
            
            

            return newLvl;
        }

        internal object SelectClass()
        {
            
            Console.Write("Select class: \n" +
                      "1.Warrior \n" +
                      "2.Rogue \n" +
                      "3.Mage \n");
            Console.WriteLine();

            var map = new Dictionary<ConsoleKey, object>()
            {
                {ConsoleKey.D1, new Warrior()},
                {ConsoleKey.D2, new Rogue()},
                {ConsoleKey.D3, new Mage()}
            };
            object outCharacter;
            return map.TryGetValue(Console.ReadKey().Key, out outCharacter) ? outCharacter : new Recruit() ;
        }
    }
}
