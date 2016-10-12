using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Warrior : IUser, IWarrior, IRecruit
    {

        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Str { get; set; }
        public int Agi { get; set; }
        public int Int { get; set; }
        public int Health { get; set; }
        public int Exp { get; set; }
        public int Lvl { get; set; }

        

        

        public int LevelUp()
        {
            throw new System.NotImplementedException();
        }
    }
}