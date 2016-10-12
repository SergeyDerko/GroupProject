using System.Collections.Generic;
using Common.modal;

namespace _10_Zoo
{
    internal class Program
    {
        public static void Main()
        {
            var animals = new List<IAnimal>
            {
                new Mammals(),
                new Birds(),
                new Amphibian(),
                new Reptiles(),
                new Fish()
            };
        }
    }
}
