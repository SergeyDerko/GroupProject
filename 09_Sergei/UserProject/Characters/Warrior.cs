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
            Str++;
            return base.LevelUp();
        }
    }
}