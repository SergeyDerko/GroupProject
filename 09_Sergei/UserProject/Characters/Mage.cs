using System;
using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Mage : Character, IMage
    {

        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        internal override int LevelUp()
        {
            Int++;
            return base.LevelUp();
        }

        public int CastSpell()
        {
            throw new NotImplementedException();
        }

    }
}