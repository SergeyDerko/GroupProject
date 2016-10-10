using System.Collections.Generic;

namespace Common.modal
{
    internal interface IAnimal
    {
        string Id { get; set; }
        TypeAnimal Type { get; set; }
        string Nickname { get; set; }
        int Age { get; set; }
        Sex Sex { get; set; }
       
    }
    
    internal enum TypeAnimal
    {
        Birds,
        Mammals,
        Reptiles
    }
    internal enum Sex
    {
        Male,
        Female,
        It
    }

}