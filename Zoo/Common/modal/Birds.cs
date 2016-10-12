using System;

namespace Common.modal
{
    public class Birds: IAnimal
    {
        public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public BirdsRace BirdsRace { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }

     
    }

    public enum BirdsRace
    {
        Raven = 1,
        Dove = 2,
        Falcon = 3,
        Owl = 4,
        Parrot = 5,
        Penguin = 6,
        Eagle = 7,
        Woodpecker = 8,
        Flamingo = 9,
        Chicken = 10
    }
}
