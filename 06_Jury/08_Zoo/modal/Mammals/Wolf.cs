using System;

namespace _08_Zoo.modal.Mammals
{
    internal class Wolf : Mammals
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Mammals;
        public new MammalsRace MammalsRace { get; private set; } = MammalsRace.Wolf;
        public override void Voice() => Console.WriteLine("WOLF say anything");
        public override void Run() => Console.WriteLine("WOLF run fast");


    }
}
