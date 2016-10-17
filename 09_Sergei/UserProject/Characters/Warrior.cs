using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Warrior : Character, IWarrior
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        internal override int LevelUp()
        {
            Str += 2;
            Agi += 1;
            Int = 1;
            Health += Str*50;
            Mana = 0;
            return base.LevelUp();
        }
    }
}