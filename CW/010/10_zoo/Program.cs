using System.Collections.Generic;
using Common.modal;

namespace _10_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();
            animals.Add(new Mammals());
            animals.Add(new Birds());
            animals.Add(new Reptiles());
            animals.Add(new Fish());
            animals.Add(new Amphibian());
        }
    }
}
