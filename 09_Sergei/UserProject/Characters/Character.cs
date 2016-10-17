using System;
using System.Collections.Generic;

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
            Exp = 100;
            Lvl = 2;
            

            Attack += Str*5;
            Defence += Agi*5;
        }

        internal virtual int LevelUp()
        {     
            var newLvl = Exp >= 100 * Lvl ? Lvl++ : Lvl;
            
            Health = Str * 50;
            Mana = Int * 50;
            Attack += Str * 5;
            Defence += Agi * 5;
            newLvl = Exp >= newLvl*100 ? LevelUp() : newLvl;
            return newLvl;
        }
    }
}
