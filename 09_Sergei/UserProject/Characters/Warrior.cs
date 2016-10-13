using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Warrior : Character, IWarrior
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}