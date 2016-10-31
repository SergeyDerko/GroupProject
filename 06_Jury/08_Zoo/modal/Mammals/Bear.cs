using System;

namespace _08_Zoo.modal.Mammals
{
    internal class Bear : Mammals
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Mammals;
        public new MammalsRace MammalsRace { get; private set; } = MammalsRace.Bear;
        public override void Voice() => Console.WriteLine("BEAR say anything");
        public override void Run() => Console.WriteLine("BEAR run slowly");


    }
}
