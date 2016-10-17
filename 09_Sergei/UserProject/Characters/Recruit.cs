using System;
using System.Collections.Generic;
using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Recruit : Character, IUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        internal Recruit()
        {
            Exp -= 100;
            --Lvl;
        }

        internal override int LevelUp()
        {
            if (base.LevelUp() == 2)
            {
                SelectClass();
            }
            return base.LevelUp();
        }


        internal object SelectClass()
        {           
            Console.Write("Select class: \n" +
                          "1.Warrior \n" +
                          "2.Rogue \n" +
                          "3.Mage \n");
            Console.WriteLine();

            var pers = new Dictionary<ConsoleKey, object>
            {
                {ConsoleKey.D1, new Warrior()},
                {ConsoleKey.D2, new Rogue()},
                {ConsoleKey.D3, new Mage()}
            };
            object outCharacter;
            return pers.TryGetValue(Console.ReadKey().Key, out outCharacter) ? outCharacter : pers;
        }
    }
}