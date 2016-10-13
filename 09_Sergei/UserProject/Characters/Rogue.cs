using System;
using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Rogue : Character, IRogue
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        

        internal Rogue()
        {
            Str += 3;
            Agi += 5;
            Int += 2;
            Health = Str*50;
            Mana = Int*50;
            Exp = 1000;
            Lvl = 1;
            Attack *= Str*3;
            Defence *= Agi*3;
        }

        public int Mutilate()
        {
            throw new NotImplementedException();
        }

        public int DeadlyPoison()
        {
            throw new NotImplementedException();
        }

        public int Stealth()
        {
            throw new NotImplementedException();
        }
    }
}