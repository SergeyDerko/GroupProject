using System;
using Common.modal;

namespace _10_Zoo
{
    internal interface IAncientBirds
    {
        int Id { get; set; }
        TypeAnimal Type { get; set; }
        string Nickname { get; set; }
        DateTime Birthday { get; set; }
        Sex Sex { get; set; }
    }
}