using System;

namespace UserProject.Characters
{
    internal class Mage : Character, IUser, IMage
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
    
        internal Mage()
        {
            Str += 1;
            Agi += 1;
            Int += 5;
            Health = Str*50;
            Mana = Int*50;
            Exp = 1000;
            Lvl = 1;
            Attack = Str*3;
            Defence = Agi*3;
        }


        public int CastSpell()
        {
            throw new NotImplementedException();
        }
    }
}