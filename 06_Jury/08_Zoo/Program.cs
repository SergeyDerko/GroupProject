using System;
using System.Collections.Generic;
using _08_Zoo.modal;
using _08_Zoo.modal.Birds;
using _08_Zoo.modal.Mammals;

namespace _08_Zoo
{
    class Program
    {
        static void Main()
        {
            var birdsInZoo = new List<Birds>
            {
                new Dove {Id = 1, Nickname = "First", Sex = Sex.Male, Birthday = new DateTime(2016, 01, 01)},
                new Falcon {Id = 2, Nickname = "Falc", Sex = Sex.Female, Birthday = new DateTime(2016, 02, 02)},
                new Penguin {Id = 3, Nickname = "Peng", Sex = Sex.Male, Birthday = new DateTime(2016, 03, 03)},
                new Raven {Id = 4, Nickname = "Rav", Sex = Sex.Male, Birthday = new DateTime(2016, 01, 04)},
                new Woodpecker {Id = 5, Nickname = "Wood", Sex = Sex.Male, Birthday = new DateTime(2016, 05, 05)},
            };
            var mammalsInZoo = new List<Mammals>
            {
                new Bear {Id = 1, Nickname = "Bear", Sex = Sex.Male, Birthday = new DateTime(2016, 01, 01)},
                new Leopard {Id = 2, Nickname = "Leopard", Sex = Sex.Female, Birthday = new DateTime(2016, 02, 02)},
                new Monkey {Id = 3, Nickname = "Monkey", Sex = Sex.Male, Birthday = new DateTime(2016, 03, 03)},
                new Panda {Id = 4, Nickname = "Panda", Sex = Sex.Male, Birthday = new DateTime(2016, 01, 04)},
                new Wolf {Id = 5, Nickname = "Wolf", Sex = Sex.Male, Birthday = new DateTime(2016, 05, 05)},
            };
            Console.WriteLine("BIRDS");
            var animal1 = new Dove();
            var animal2 = new Falcon();
            Console.WriteLine("Voice");
            animal1.Voice();
            animal2.Voice();
            Console.WriteLine("Fly");
            animal1.Fly();
            animal2.Fly();
            Console.WriteLine("MAMMALS");
            var animal6 = new Bear();
            var animal7 = new Leopard();
            Console.WriteLine("Voice");
            animal6.Voice();
            animal7.Voice();
            Console.WriteLine("Run");
            animal6.Run();
            animal7.Run();


            Console.ReadKey();
        }
    }
}
