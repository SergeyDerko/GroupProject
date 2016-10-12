using System;

namespace Common.modal
{
    public interface IAnimal
    {
        int Id { get; set; }
        TypeAnimal Type { get; set; }
        string Nickname { get; set; }
        DateTime Birthday { get; set; }
        Sex Sex { get; set; }
       
    }

    public enum TypeAnimal
    {
        Mammals = 1,
        Birds = 2,
        Reptiles = 3,
        Fish = 4,
        Amphibians = 5,
     }

    public enum Sex
    {
        None = 0,
        Male = 1,
        Female = 2,
    }
}