using System;

namespace _402_Advanced_programming.Model
{
    public interface IPerson
    {
        string Name { get; set; }
        string SName { get; set; }
        DateTime Birthday { get; set; }
    }
}