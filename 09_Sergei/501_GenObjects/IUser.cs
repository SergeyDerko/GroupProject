using System;

namespace _501_GenObjects
{
    interface IUser
    {
        string Name { set; get; }
        string SName { get; set; }
        DateTime DateBirth { get; set; }
    }
}
