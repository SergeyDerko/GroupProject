using System;

namespace _08_Zoo.modal.Birds
{
    internal abstract class Birds : IAnimal, IBirds
    {
        public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public BirdsRace BirdsRace { get; set; }
        public virtual void Voice() => Console.WriteLine("BIRDS say anything");
        public virtual void Fly() => Console.WriteLine("BIRDS say anything");
    }
}
