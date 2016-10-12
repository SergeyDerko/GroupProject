using System;
using UserProject.Interfaces;

namespace UserProject.Characters
{
    internal class Rogue :IUser, IRogue, IRecruit
    {
        public int Str { get; set; }
        public int Agi { get; set; }
        public int Int { get; set; }
        public int Health { get; set; }
        public int Exp { get; set; }
        public int Lvl { get; set; }

        public string Surname
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Age
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int LevelUp()
        {
            throw new System.NotImplementedException();
        }

        public int UsedTricks()
        {
            throw new System.NotImplementedException();
        }
    }
}