using System;
using System.Collections.Generic;
using Common.modal;

namespace _10_Zoo_
{
    class Program
    {
        static void Main()
        {
            var birdsInMyZoo = new List<Birds>
            {
               new Birds() {Id = 1, BirdsRace = BirdsRace.Dove, Birthday = new DateTime(2011,04,04), Nickname = "First", Sex = Sex.Male},
               new Birds() {Id = 2, BirdsRace = BirdsRace.Chicken, Birthday = new DateTime(2012,05,10), Nickname = "koko", Sex = Sex.Male},
               new Birds() {Id = 3, BirdsRace = BirdsRace.Woodpecker, Birthday = new DateTime(2015,01,13), Nickname = "dudu", Sex = Sex.Male}
            };

            var reptilesInMyZoo = new List<Reptiles>
            {
                new Reptiles() {Id = 1, ReptilesRace = ReptilesRace.Crocodile, Birthday = new DateTime(2014, 04, 01),Nickname = "Croc", Sex = Sex.Female},
                new Reptiles() {Id = 1, ReptilesRace = ReptilesRace.Snake, Birthday = new DateTime(2011, 12, 01), Nickname = "Snek", Sex = Sex.Male},
                new Reptiles() {Id = 1, ReptilesRace = ReptilesRace.Turtle, Birthday = new DateTime(2009, 10, 11),Nickname = "Tur", Sex = Sex.Female}

            };
            var mammalsInMyZoo = new List<Mammals>
            {
                new Mammals() {Id = 1, MammalsRace = MammalsRace.Bear, Birthday = new DateTime(2014, 04, 01),Nickname = "Beer", Sex = Sex.Female},
                new Mammals() {Id = 1, MammalsRace = MammalsRace.Panda, Birthday = new DateTime(2011, 12, 01), Nickname = "White", Sex = Sex.Female},
                new Mammals() {Id = 1, MammalsRace = MammalsRace.Leopard, Birthday = new DateTime(2009, 10, 11),Nickname = "Leo", Sex = Sex.Male}

            };
            var fishInMyZoo = new List<Fish>
            {
                new Fish() {Id = 1, FishRace = FishRace.Pike, Birthday = new DateTime(2014, 05, 01),Nickname = "Pi", Sex = Sex.Female},
                new Fish() {Id = 1, FishRace = FishRace.Piranha, Birthday = new DateTime(2011, 05, 01),Nickname = "Pir", Sex = Sex.Male},
                new Fish() {Id = 1, FishRace = FishRace.Dolphin, Birthday = new DateTime(2016, 05, 01),Nickname = "Dol", Sex = Sex.Male}
            };

           

            Console.ReadKey();
        }
       

    }
}
