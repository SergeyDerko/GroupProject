using System;


namespace _08_Zoo.modal.Mammals
{
    internal  abstract class  Mammals:IAnimal, IMammals
    {
        public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public virtual void Voice() => Console.WriteLine("MAMMALS say anything");
        public virtual void Run() => Console.WriteLine("MAMMALS say anything");
        public MammalsRace MammalsRace { get; set; }
    }
}
