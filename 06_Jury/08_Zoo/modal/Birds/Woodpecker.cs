using System;

namespace _08_Zoo.modal.Birds
{
    internal class Woodpecker : Birds
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Birds;
        public new BirdsRace BirdsRace { get; private set; } = BirdsRace.Woodpecker;
        public override void Voice() => Console.WriteLine("WOODPECKER say anything");
        public override void Fly() => Console.WriteLine("WOODPECKER can fly");
    }
}
