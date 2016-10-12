using System;
using System.Collections.Generic;

namespace UserProject.Characters
{
    internal abstract class Character
    {
        protected internal int Str { get; set; }
        protected internal int Agi { get; set; }
        protected internal int Int { get; set; }
        protected internal int Health { get; set; }
        protected internal int Exp { get; set; }
        protected internal int Lvl { get; set; }

        protected Character()
        {
            Str = 5;
            Agi = 5;
            Int = 5;
            Health = 100;
            Exp = 0;
            Lvl = 0;
        }

        protected internal int LevelUp()
        {
            var newLvl = Exp > 1000 * Lvl ? Lvl++ : Lvl;
            if (newLvl == 1)
            {
                SelectClass();
            }
            return newLvl;
        }

        protected internal object SelectClass()
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
            return map.TryGetValue(Console.ReadKey().Key, out outCharacter) ? outCharacter : new Recruit();
        }
    }
}
