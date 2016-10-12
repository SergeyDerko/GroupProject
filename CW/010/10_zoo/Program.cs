using System.Collections.Generic;
using Common.modal;

namespace _10_zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>
            {
                new Mammals(),
                new Birds(),
                new Reptiles(),
                new Fish(),
                new Amphibian()
            };
        }
    }
}
