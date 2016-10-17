using System;
using Common.modal;

namespace _10_Zoo
{
    internal class AncientBirds : IAnimal
    {
        public int Id { get; set; }
        public TypeAnimal Type { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
    }

}