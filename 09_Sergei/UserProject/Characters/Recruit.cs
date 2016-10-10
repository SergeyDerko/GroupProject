using System;

namespace UserProject
{
    internal class Recruit : IUser, IRecruit
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


        internal Recruit()
        {
            Str = 5;
            Agi = 5;
            Int = 5;
            Health = 100;
            Exp = 0;
            Lvl = 0;
        }

        public int LevelUp()
        {
            var newLvl = Exp > 100 * Lvl ? Lvl++ : Lvl;
            if (newLvl == 1)
            {
                SelectClass();
            }
            return newLvl;
        }

        protected internal void SelectClass()
        {
            Console.Write("Select class: \n" +
                          "1.Warrior \n" +
                          "2.Rogue \n" +
                          "3.Mage \n");
            Console.WriteLine();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("You selected Warrior!");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("You selected Rouge!");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("You selected Mage!");
                    break;
            }
        }

    }
}