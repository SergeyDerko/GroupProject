using System;

namespace _08_Zoo.modal.Mammals
{
    internal class Leopard : Mammals
    {
        public new TypeAnimal Type { get; private set; } = TypeAnimal.Mammals;
        public new MammalsRace MammalsRace { get; private set; } = MammalsRace.Leopard;
        public override void Voice() => Console.WriteLine("LEOPARD say anything");
        public override void Run() => Console.WriteLine("LEOPARD run very fast");


    }
}
