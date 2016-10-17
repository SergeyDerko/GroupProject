using System;
using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Rogue : Character, IRogue
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        internal override int LevelUp()
        {
            Agi++;
            return base.LevelUp();
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